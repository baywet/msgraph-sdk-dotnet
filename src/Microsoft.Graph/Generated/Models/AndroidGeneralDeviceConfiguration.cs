using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class AndroidGeneralDeviceConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Indicates whether or not to block clipboard sharing to copy and paste between applications.</summary>
        public bool? AppsBlockClipboardSharing {
            get { return BackingStore?.Get<bool?>("appsBlockClipboardSharing"); }
            set { BackingStore?.Set("appsBlockClipboardSharing", value); }
        }
        /// <summary>Indicates whether or not to block copy and paste within applications.</summary>
        public bool? AppsBlockCopyPaste {
            get { return BackingStore?.Get<bool?>("appsBlockCopyPaste"); }
            set { BackingStore?.Set("appsBlockCopyPaste", value); }
        }
        /// <summary>Indicates whether or not to block the YouTube app.</summary>
        public bool? AppsBlockYouTube {
            get { return BackingStore?.Get<bool?>("appsBlockYouTube"); }
            set { BackingStore?.Set("appsBlockYouTube", value); }
        }
        /// <summary>List of apps to be hidden on the KNOX device. This collection can contain a maximum of 500 elements.</summary>
        public List<AppListItem> AppsHideList {
            get { return BackingStore?.Get<List<AppListItem>>("appsHideList"); }
            set { BackingStore?.Set("appsHideList", value); }
        }
        /// <summary>List of apps which can be installed on the KNOX device. This collection can contain a maximum of 500 elements.</summary>
        public List<AppListItem> AppsInstallAllowList {
            get { return BackingStore?.Get<List<AppListItem>>("appsInstallAllowList"); }
            set { BackingStore?.Set("appsInstallAllowList", value); }
        }
        /// <summary>List of apps which are blocked from being launched on the KNOX device. This collection can contain a maximum of 500 elements.</summary>
        public List<AppListItem> AppsLaunchBlockList {
            get { return BackingStore?.Get<List<AppListItem>>("appsLaunchBlockList"); }
            set { BackingStore?.Set("appsLaunchBlockList", value); }
        }
        /// <summary>Indicates whether or not to block Bluetooth.</summary>
        public bool? BluetoothBlocked {
            get { return BackingStore?.Get<bool?>("bluetoothBlocked"); }
            set { BackingStore?.Set("bluetoothBlocked", value); }
        }
        /// <summary>Indicates whether or not to block the use of the camera.</summary>
        public bool? CameraBlocked {
            get { return BackingStore?.Get<bool?>("cameraBlocked"); }
            set { BackingStore?.Set("cameraBlocked", value); }
        }
        /// <summary>Indicates whether or not to block data roaming.</summary>
        public bool? CellularBlockDataRoaming {
            get { return BackingStore?.Get<bool?>("cellularBlockDataRoaming"); }
            set { BackingStore?.Set("cellularBlockDataRoaming", value); }
        }
        /// <summary>Indicates whether or not to block SMS/MMS messaging.</summary>
        public bool? CellularBlockMessaging {
            get { return BackingStore?.Get<bool?>("cellularBlockMessaging"); }
            set { BackingStore?.Set("cellularBlockMessaging", value); }
        }
        /// <summary>Indicates whether or not to block voice roaming.</summary>
        public bool? CellularBlockVoiceRoaming {
            get { return BackingStore?.Get<bool?>("cellularBlockVoiceRoaming"); }
            set { BackingStore?.Set("cellularBlockVoiceRoaming", value); }
        }
        /// <summary>Indicates whether or not to block syncing Wi-Fi tethering.</summary>
        public bool? CellularBlockWiFiTethering {
            get { return BackingStore?.Get<bool?>("cellularBlockWiFiTethering"); }
            set { BackingStore?.Set("cellularBlockWiFiTethering", value); }
        }
        /// <summary>Possible values of the compliance app list.</summary>
        public AppListType? CompliantAppListType {
            get { return BackingStore?.Get<AppListType?>("compliantAppListType"); }
            set { BackingStore?.Set("compliantAppListType", value); }
        }
        /// <summary>List of apps in the compliance (either allow list or block list, controlled by CompliantAppListType). This collection can contain a maximum of 10000 elements.</summary>
        public List<AppListItem> CompliantAppsList {
            get { return BackingStore?.Get<List<AppListItem>>("compliantAppsList"); }
            set { BackingStore?.Set("compliantAppsList", value); }
        }
        /// <summary>Indicates whether or not to allow device sharing mode.</summary>
        public bool? DeviceSharingAllowed {
            get { return BackingStore?.Get<bool?>("deviceSharingAllowed"); }
            set { BackingStore?.Set("deviceSharingAllowed", value); }
        }
        /// <summary>Indicates whether or not to block diagnostic data submission.</summary>
        public bool? DiagnosticDataBlockSubmission {
            get { return BackingStore?.Get<bool?>("diagnosticDataBlockSubmission"); }
            set { BackingStore?.Set("diagnosticDataBlockSubmission", value); }
        }
        /// <summary>Indicates whether or not to block user performing a factory reset.</summary>
        public bool? FactoryResetBlocked {
            get { return BackingStore?.Get<bool?>("factoryResetBlocked"); }
            set { BackingStore?.Set("factoryResetBlocked", value); }
        }
        /// <summary>Indicates whether or not to block Google account auto sync.</summary>
        public bool? GoogleAccountBlockAutoSync {
            get { return BackingStore?.Get<bool?>("googleAccountBlockAutoSync"); }
            set { BackingStore?.Set("googleAccountBlockAutoSync", value); }
        }
        /// <summary>Indicates whether or not to block the Google Play store.</summary>
        public bool? GooglePlayStoreBlocked {
            get { return BackingStore?.Get<bool?>("googlePlayStoreBlocked"); }
            set { BackingStore?.Set("googlePlayStoreBlocked", value); }
        }
        /// <summary>A list of apps that will be allowed to run when the device is in Kiosk Mode. This collection can contain a maximum of 500 elements.</summary>
        public List<AppListItem> KioskModeApps {
            get { return BackingStore?.Get<List<AppListItem>>("kioskModeApps"); }
            set { BackingStore?.Set("kioskModeApps", value); }
        }
        /// <summary>Indicates whether or not to block the screen sleep button while in Kiosk Mode.</summary>
        public bool? KioskModeBlockSleepButton {
            get { return BackingStore?.Get<bool?>("kioskModeBlockSleepButton"); }
            set { BackingStore?.Set("kioskModeBlockSleepButton", value); }
        }
        /// <summary>Indicates whether or not to block the volume buttons while in Kiosk Mode.</summary>
        public bool? KioskModeBlockVolumeButtons {
            get { return BackingStore?.Get<bool?>("kioskModeBlockVolumeButtons"); }
            set { BackingStore?.Set("kioskModeBlockVolumeButtons", value); }
        }
        /// <summary>Indicates whether or not to block location services.</summary>
        public bool? LocationServicesBlocked {
            get { return BackingStore?.Get<bool?>("locationServicesBlocked"); }
            set { BackingStore?.Set("locationServicesBlocked", value); }
        }
        /// <summary>Indicates whether or not to block Near-Field Communication.</summary>
        public bool? NfcBlocked {
            get { return BackingStore?.Get<bool?>("nfcBlocked"); }
            set { BackingStore?.Set("nfcBlocked", value); }
        }
        /// <summary>Indicates whether or not to block fingerprint unlock.</summary>
        public bool? PasswordBlockFingerprintUnlock {
            get { return BackingStore?.Get<bool?>("passwordBlockFingerprintUnlock"); }
            set { BackingStore?.Set("passwordBlockFingerprintUnlock", value); }
        }
        /// <summary>Indicates whether or not to block Smart Lock and other trust agents.</summary>
        public bool? PasswordBlockTrustAgents {
            get { return BackingStore?.Get<bool?>("passwordBlockTrustAgents"); }
            set { BackingStore?.Set("passwordBlockTrustAgents", value); }
        }
        /// <summary>Number of days before the password expires. Valid values 1 to 365</summary>
        public int? PasswordExpirationDays {
            get { return BackingStore?.Get<int?>("passwordExpirationDays"); }
            set { BackingStore?.Set("passwordExpirationDays", value); }
        }
        /// <summary>Minimum length of passwords. Valid values 4 to 16</summary>
        public int? PasswordMinimumLength {
            get { return BackingStore?.Get<int?>("passwordMinimumLength"); }
            set { BackingStore?.Set("passwordMinimumLength", value); }
        }
        /// <summary>Minutes of inactivity before the screen times out.</summary>
        public int? PasswordMinutesOfInactivityBeforeScreenTimeout {
            get { return BackingStore?.Get<int?>("passwordMinutesOfInactivityBeforeScreenTimeout"); }
            set { BackingStore?.Set("passwordMinutesOfInactivityBeforeScreenTimeout", value); }
        }
        /// <summary>Number of previous passwords to block. Valid values 0 to 24</summary>
        public int? PasswordPreviousPasswordBlockCount {
            get { return BackingStore?.Get<int?>("passwordPreviousPasswordBlockCount"); }
            set { BackingStore?.Set("passwordPreviousPasswordBlockCount", value); }
        }
        /// <summary>Indicates whether or not to require a password.</summary>
        public bool? PasswordRequired {
            get { return BackingStore?.Get<bool?>("passwordRequired"); }
            set { BackingStore?.Set("passwordRequired", value); }
        }
        /// <summary>Android required password type.</summary>
        public AndroidRequiredPasswordType? PasswordRequiredType {
            get { return BackingStore?.Get<AndroidRequiredPasswordType?>("passwordRequiredType"); }
            set { BackingStore?.Set("passwordRequiredType", value); }
        }
        /// <summary>Number of sign in failures allowed before factory reset. Valid values 1 to 16</summary>
        public int? PasswordSignInFailureCountBeforeFactoryReset {
            get { return BackingStore?.Get<int?>("passwordSignInFailureCountBeforeFactoryReset"); }
            set { BackingStore?.Set("passwordSignInFailureCountBeforeFactoryReset", value); }
        }
        /// <summary>Indicates whether or not to block powering off the device.</summary>
        public bool? PowerOffBlocked {
            get { return BackingStore?.Get<bool?>("powerOffBlocked"); }
            set { BackingStore?.Set("powerOffBlocked", value); }
        }
        /// <summary>Indicates whether or not to block screenshots.</summary>
        public bool? ScreenCaptureBlocked {
            get { return BackingStore?.Get<bool?>("screenCaptureBlocked"); }
            set { BackingStore?.Set("screenCaptureBlocked", value); }
        }
        /// <summary>Require the Android Verify apps feature is turned on.</summary>
        public bool? SecurityRequireVerifyApps {
            get { return BackingStore?.Get<bool?>("securityRequireVerifyApps"); }
            set { BackingStore?.Set("securityRequireVerifyApps", value); }
        }
        /// <summary>Indicates whether or not to block Google Backup.</summary>
        public bool? StorageBlockGoogleBackup {
            get { return BackingStore?.Get<bool?>("storageBlockGoogleBackup"); }
            set { BackingStore?.Set("storageBlockGoogleBackup", value); }
        }
        /// <summary>Indicates whether or not to block removable storage usage.</summary>
        public bool? StorageBlockRemovableStorage {
            get { return BackingStore?.Get<bool?>("storageBlockRemovableStorage"); }
            set { BackingStore?.Set("storageBlockRemovableStorage", value); }
        }
        /// <summary>Indicates whether or not to require device encryption.</summary>
        public bool? StorageRequireDeviceEncryption {
            get { return BackingStore?.Get<bool?>("storageRequireDeviceEncryption"); }
            set { BackingStore?.Set("storageRequireDeviceEncryption", value); }
        }
        /// <summary>Indicates whether or not to require removable storage encryption.</summary>
        public bool? StorageRequireRemovableStorageEncryption {
            get { return BackingStore?.Get<bool?>("storageRequireRemovableStorageEncryption"); }
            set { BackingStore?.Set("storageRequireRemovableStorageEncryption", value); }
        }
        /// <summary>Indicates whether or not to block the use of the Voice Assistant.</summary>
        public bool? VoiceAssistantBlocked {
            get { return BackingStore?.Get<bool?>("voiceAssistantBlocked"); }
            set { BackingStore?.Set("voiceAssistantBlocked", value); }
        }
        /// <summary>Indicates whether or not to block voice dialing.</summary>
        public bool? VoiceDialingBlocked {
            get { return BackingStore?.Get<bool?>("voiceDialingBlocked"); }
            set { BackingStore?.Set("voiceDialingBlocked", value); }
        }
        /// <summary>Indicates whether or not to block the web browser&apos;s auto fill feature.</summary>
        public bool? WebBrowserBlockAutofill {
            get { return BackingStore?.Get<bool?>("webBrowserBlockAutofill"); }
            set { BackingStore?.Set("webBrowserBlockAutofill", value); }
        }
        /// <summary>Indicates whether or not to block the web browser.</summary>
        public bool? WebBrowserBlocked {
            get { return BackingStore?.Get<bool?>("webBrowserBlocked"); }
            set { BackingStore?.Set("webBrowserBlocked", value); }
        }
        /// <summary>Indicates whether or not to block JavaScript within the web browser.</summary>
        public bool? WebBrowserBlockJavaScript {
            get { return BackingStore?.Get<bool?>("webBrowserBlockJavaScript"); }
            set { BackingStore?.Set("webBrowserBlockJavaScript", value); }
        }
        /// <summary>Indicates whether or not to block popups within the web browser.</summary>
        public bool? WebBrowserBlockPopups {
            get { return BackingStore?.Get<bool?>("webBrowserBlockPopups"); }
            set { BackingStore?.Set("webBrowserBlockPopups", value); }
        }
        /// <summary>Web Browser Cookie Settings.</summary>
        public Microsoft.Graph.Models.WebBrowserCookieSettings? WebBrowserCookieSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Models.WebBrowserCookieSettings?>("webBrowserCookieSettings"); }
            set { BackingStore?.Set("webBrowserCookieSettings", value); }
        }
        /// <summary>Indicates whether or not to block syncing Wi-Fi.</summary>
        public bool? WiFiBlocked {
            get { return BackingStore?.Get<bool?>("wiFiBlocked"); }
            set { BackingStore?.Set("wiFiBlocked", value); }
        }
        /// <summary>
        /// Instantiates a new AndroidGeneralDeviceConfiguration and sets the default values.
        /// </summary>
        public AndroidGeneralDeviceConfiguration() : base() {
            OdataType = "#microsoft.graph.androidGeneralDeviceConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AndroidGeneralDeviceConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidGeneralDeviceConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appsBlockClipboardSharing", n => { AppsBlockClipboardSharing = n.GetBoolValue(); } },
                {"appsBlockCopyPaste", n => { AppsBlockCopyPaste = n.GetBoolValue(); } },
                {"appsBlockYouTube", n => { AppsBlockYouTube = n.GetBoolValue(); } },
                {"appsHideList", n => { AppsHideList = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"appsInstallAllowList", n => { AppsInstallAllowList = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"appsLaunchBlockList", n => { AppsLaunchBlockList = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"bluetoothBlocked", n => { BluetoothBlocked = n.GetBoolValue(); } },
                {"cameraBlocked", n => { CameraBlocked = n.GetBoolValue(); } },
                {"cellularBlockDataRoaming", n => { CellularBlockDataRoaming = n.GetBoolValue(); } },
                {"cellularBlockMessaging", n => { CellularBlockMessaging = n.GetBoolValue(); } },
                {"cellularBlockVoiceRoaming", n => { CellularBlockVoiceRoaming = n.GetBoolValue(); } },
                {"cellularBlockWiFiTethering", n => { CellularBlockWiFiTethering = n.GetBoolValue(); } },
                {"compliantAppListType", n => { CompliantAppListType = n.GetEnumValue<AppListType>(); } },
                {"compliantAppsList", n => { CompliantAppsList = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceSharingAllowed", n => { DeviceSharingAllowed = n.GetBoolValue(); } },
                {"diagnosticDataBlockSubmission", n => { DiagnosticDataBlockSubmission = n.GetBoolValue(); } },
                {"factoryResetBlocked", n => { FactoryResetBlocked = n.GetBoolValue(); } },
                {"googleAccountBlockAutoSync", n => { GoogleAccountBlockAutoSync = n.GetBoolValue(); } },
                {"googlePlayStoreBlocked", n => { GooglePlayStoreBlocked = n.GetBoolValue(); } },
                {"kioskModeApps", n => { KioskModeApps = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"kioskModeBlockSleepButton", n => { KioskModeBlockSleepButton = n.GetBoolValue(); } },
                {"kioskModeBlockVolumeButtons", n => { KioskModeBlockVolumeButtons = n.GetBoolValue(); } },
                {"locationServicesBlocked", n => { LocationServicesBlocked = n.GetBoolValue(); } },
                {"nfcBlocked", n => { NfcBlocked = n.GetBoolValue(); } },
                {"passwordBlockFingerprintUnlock", n => { PasswordBlockFingerprintUnlock = n.GetBoolValue(); } },
                {"passwordBlockTrustAgents", n => { PasswordBlockTrustAgents = n.GetBoolValue(); } },
                {"passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                {"passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                {"passwordMinutesOfInactivityBeforeScreenTimeout", n => { PasswordMinutesOfInactivityBeforeScreenTimeout = n.GetIntValue(); } },
                {"passwordPreviousPasswordBlockCount", n => { PasswordPreviousPasswordBlockCount = n.GetIntValue(); } },
                {"passwordRequired", n => { PasswordRequired = n.GetBoolValue(); } },
                {"passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<AndroidRequiredPasswordType>(); } },
                {"passwordSignInFailureCountBeforeFactoryReset", n => { PasswordSignInFailureCountBeforeFactoryReset = n.GetIntValue(); } },
                {"powerOffBlocked", n => { PowerOffBlocked = n.GetBoolValue(); } },
                {"screenCaptureBlocked", n => { ScreenCaptureBlocked = n.GetBoolValue(); } },
                {"securityRequireVerifyApps", n => { SecurityRequireVerifyApps = n.GetBoolValue(); } },
                {"storageBlockGoogleBackup", n => { StorageBlockGoogleBackup = n.GetBoolValue(); } },
                {"storageBlockRemovableStorage", n => { StorageBlockRemovableStorage = n.GetBoolValue(); } },
                {"storageRequireDeviceEncryption", n => { StorageRequireDeviceEncryption = n.GetBoolValue(); } },
                {"storageRequireRemovableStorageEncryption", n => { StorageRequireRemovableStorageEncryption = n.GetBoolValue(); } },
                {"voiceAssistantBlocked", n => { VoiceAssistantBlocked = n.GetBoolValue(); } },
                {"voiceDialingBlocked", n => { VoiceDialingBlocked = n.GetBoolValue(); } },
                {"webBrowserBlockAutofill", n => { WebBrowserBlockAutofill = n.GetBoolValue(); } },
                {"webBrowserBlocked", n => { WebBrowserBlocked = n.GetBoolValue(); } },
                {"webBrowserBlockJavaScript", n => { WebBrowserBlockJavaScript = n.GetBoolValue(); } },
                {"webBrowserBlockPopups", n => { WebBrowserBlockPopups = n.GetBoolValue(); } },
                {"webBrowserCookieSettings", n => { WebBrowserCookieSettings = n.GetEnumValue<WebBrowserCookieSettings>(); } },
                {"wiFiBlocked", n => { WiFiBlocked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("appsBlockClipboardSharing", AppsBlockClipboardSharing);
            writer.WriteBoolValue("appsBlockCopyPaste", AppsBlockCopyPaste);
            writer.WriteBoolValue("appsBlockYouTube", AppsBlockYouTube);
            writer.WriteCollectionOfObjectValues<AppListItem>("appsHideList", AppsHideList);
            writer.WriteCollectionOfObjectValues<AppListItem>("appsInstallAllowList", AppsInstallAllowList);
            writer.WriteCollectionOfObjectValues<AppListItem>("appsLaunchBlockList", AppsLaunchBlockList);
            writer.WriteBoolValue("bluetoothBlocked", BluetoothBlocked);
            writer.WriteBoolValue("cameraBlocked", CameraBlocked);
            writer.WriteBoolValue("cellularBlockDataRoaming", CellularBlockDataRoaming);
            writer.WriteBoolValue("cellularBlockMessaging", CellularBlockMessaging);
            writer.WriteBoolValue("cellularBlockVoiceRoaming", CellularBlockVoiceRoaming);
            writer.WriteBoolValue("cellularBlockWiFiTethering", CellularBlockWiFiTethering);
            writer.WriteEnumValue<AppListType>("compliantAppListType", CompliantAppListType);
            writer.WriteCollectionOfObjectValues<AppListItem>("compliantAppsList", CompliantAppsList);
            writer.WriteBoolValue("deviceSharingAllowed", DeviceSharingAllowed);
            writer.WriteBoolValue("diagnosticDataBlockSubmission", DiagnosticDataBlockSubmission);
            writer.WriteBoolValue("factoryResetBlocked", FactoryResetBlocked);
            writer.WriteBoolValue("googleAccountBlockAutoSync", GoogleAccountBlockAutoSync);
            writer.WriteBoolValue("googlePlayStoreBlocked", GooglePlayStoreBlocked);
            writer.WriteCollectionOfObjectValues<AppListItem>("kioskModeApps", KioskModeApps);
            writer.WriteBoolValue("kioskModeBlockSleepButton", KioskModeBlockSleepButton);
            writer.WriteBoolValue("kioskModeBlockVolumeButtons", KioskModeBlockVolumeButtons);
            writer.WriteBoolValue("locationServicesBlocked", LocationServicesBlocked);
            writer.WriteBoolValue("nfcBlocked", NfcBlocked);
            writer.WriteBoolValue("passwordBlockFingerprintUnlock", PasswordBlockFingerprintUnlock);
            writer.WriteBoolValue("passwordBlockTrustAgents", PasswordBlockTrustAgents);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeScreenTimeout", PasswordMinutesOfInactivityBeforeScreenTimeout);
            writer.WriteIntValue("passwordPreviousPasswordBlockCount", PasswordPreviousPasswordBlockCount);
            writer.WriteBoolValue("passwordRequired", PasswordRequired);
            writer.WriteEnumValue<AndroidRequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteIntValue("passwordSignInFailureCountBeforeFactoryReset", PasswordSignInFailureCountBeforeFactoryReset);
            writer.WriteBoolValue("powerOffBlocked", PowerOffBlocked);
            writer.WriteBoolValue("screenCaptureBlocked", ScreenCaptureBlocked);
            writer.WriteBoolValue("securityRequireVerifyApps", SecurityRequireVerifyApps);
            writer.WriteBoolValue("storageBlockGoogleBackup", StorageBlockGoogleBackup);
            writer.WriteBoolValue("storageBlockRemovableStorage", StorageBlockRemovableStorage);
            writer.WriteBoolValue("storageRequireDeviceEncryption", StorageRequireDeviceEncryption);
            writer.WriteBoolValue("storageRequireRemovableStorageEncryption", StorageRequireRemovableStorageEncryption);
            writer.WriteBoolValue("voiceAssistantBlocked", VoiceAssistantBlocked);
            writer.WriteBoolValue("voiceDialingBlocked", VoiceDialingBlocked);
            writer.WriteBoolValue("webBrowserBlockAutofill", WebBrowserBlockAutofill);
            writer.WriteBoolValue("webBrowserBlocked", WebBrowserBlocked);
            writer.WriteBoolValue("webBrowserBlockJavaScript", WebBrowserBlockJavaScript);
            writer.WriteBoolValue("webBrowserBlockPopups", WebBrowserBlockPopups);
            writer.WriteEnumValue<WebBrowserCookieSettings>("webBrowserCookieSettings", WebBrowserCookieSettings);
            writer.WriteBoolValue("wiFiBlocked", WiFiBlocked);
        }
    }
}