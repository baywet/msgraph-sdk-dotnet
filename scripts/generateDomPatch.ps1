param (
	[string]
	$fileNameToDiff = "kiota-dom-export.txt",
    [string]
    $initialCommitSha = "",
    [string]
    $finalCommitSha = ""
)
$relativePath = Get-ChildItem -Recurse -Filter $fileNameToDiff | Select-Object -First 1
if ($null -ne $relativePath) {
    if ($initialCommitSha -eq "" -or $finalCommitSha -eq "") {
        $result = git format-patch -1 HEAD --minimal -U0 -w $relativePath
    } else {
        $result = git format-patch $initialCommitSha..$finalCommitSha --minimal -U0 -w $relativePath
    }

    if ((Test-Path $result) -and (Test-Path Env:GITHUB_OUTPUT)) {
        write-host "Patch file generated at $result"
        "isFilePresent=true" | Out-File -FilePath $env:GITHUB_OUTPUT -Append
        "patchFilePath=$result" | Out-File -FilePath $env:GITHUB_OUTPUT -Append
        exit 0
    }
}
if (Test-Path Env:GITHUB_OUTPUT) {
    write-host "No patch file generated"
    "isFilePresent=false" | Out-File -FilePath $env:GITHUB_OUTPUT -Append
}