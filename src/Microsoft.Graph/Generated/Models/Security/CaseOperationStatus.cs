namespace Microsoft.Graph.Models.Security {
    /// <summary>Provides operations to manage the collection of agreementAcceptance entities.</summary>
    public enum CaseOperationStatus {
        NotStarted,
        SubmissionFailed,
        Running,
        Succeeded,
        PartiallySucceeded,
        Failed,
        UnknownFutureValue,
    }
}