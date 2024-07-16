// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.IdentityGovernance
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class Run : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The date time that the run completed. Value is null if the workflow hasn&apos;t completed.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public DateTimeOffset? CompletedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("completedDateTime"); }
            set { BackingStore?.Set("completedDateTime", value); }
        }
        /// <summary>The number of tasks that failed in the run execution.</summary>
        public int? FailedTasksCount
        {
            get { return BackingStore?.Get<int?>("failedTasksCount"); }
            set { BackingStore?.Set("failedTasksCount", value); }
        }
        /// <summary>The number of users that failed in the run execution.</summary>
        public int? FailedUsersCount
        {
            get { return BackingStore?.Get<int?>("failedUsersCount"); }
            set { BackingStore?.Set("failedUsersCount", value); }
        }
        /// <summary>The datetime that the run was last updated.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public DateTimeOffset? LastUpdatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>The processingStatus property</summary>
        public global::Microsoft.Graph.Models.IdentityGovernance.LifecycleWorkflowProcessingStatus? ProcessingStatus
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentityGovernance.LifecycleWorkflowProcessingStatus?>("processingStatus"); }
            set { BackingStore?.Set("processingStatus", value); }
        }
        /// <summary>The date time that the run is scheduled to be executed for a workflow.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public DateTimeOffset? ScheduledDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("scheduledDateTime"); }
            set { BackingStore?.Set("scheduledDateTime", value); }
        }
        /// <summary>The date time that the run execution started.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public DateTimeOffset? StartedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("startedDateTime"); }
            set { BackingStore?.Set("startedDateTime", value); }
        }
        /// <summary>The number of successfully completed users in the run.</summary>
        public int? SuccessfulUsersCount
        {
            get { return BackingStore?.Get<int?>("successfulUsersCount"); }
            set { BackingStore?.Set("successfulUsersCount", value); }
        }
        /// <summary>The related taskProcessingResults.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.IdentityGovernance.TaskProcessingResult>? TaskProcessingResults
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.IdentityGovernance.TaskProcessingResult>?>("taskProcessingResults"); }
            set { BackingStore?.Set("taskProcessingResults", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.IdentityGovernance.TaskProcessingResult> TaskProcessingResults
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.IdentityGovernance.TaskProcessingResult>>("taskProcessingResults"); }
            set { BackingStore?.Set("taskProcessingResults", value); }
        }
#endif
        /// <summary>The totalTasksCount property</summary>
        public int? TotalTasksCount
        {
            get { return BackingStore?.Get<int?>("totalTasksCount"); }
            set { BackingStore?.Set("totalTasksCount", value); }
        }
        /// <summary>The total number of unprocessed tasks in the run execution.</summary>
        public int? TotalUnprocessedTasksCount
        {
            get { return BackingStore?.Get<int?>("totalUnprocessedTasksCount"); }
            set { BackingStore?.Set("totalUnprocessedTasksCount", value); }
        }
        /// <summary>The total number of users in the workflow execution.</summary>
        public int? TotalUsersCount
        {
            get { return BackingStore?.Get<int?>("totalUsersCount"); }
            set { BackingStore?.Set("totalUsersCount", value); }
        }
        /// <summary>The associated individual user execution.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.IdentityGovernance.UserProcessingResult>? UserProcessingResults
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.IdentityGovernance.UserProcessingResult>?>("userProcessingResults"); }
            set { BackingStore?.Set("userProcessingResults", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.IdentityGovernance.UserProcessingResult> UserProcessingResults
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.IdentityGovernance.UserProcessingResult>>("userProcessingResults"); }
            set { BackingStore?.Set("userProcessingResults", value); }
        }
#endif
        /// <summary>The workflowExecutionType property</summary>
        public global::Microsoft.Graph.Models.IdentityGovernance.WorkflowExecutionType? WorkflowExecutionType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentityGovernance.WorkflowExecutionType?>("workflowExecutionType"); }
            set { BackingStore?.Set("workflowExecutionType", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.IdentityGovernance.Run"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.IdentityGovernance.Run CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.IdentityGovernance.Run();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "completedDateTime", n => { CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                { "failedTasksCount", n => { FailedTasksCount = n.GetIntValue(); } },
                { "failedUsersCount", n => { FailedUsersCount = n.GetIntValue(); } },
                { "lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "processingStatus", n => { ProcessingStatus = n.GetEnumValue<global::Microsoft.Graph.Models.IdentityGovernance.LifecycleWorkflowProcessingStatus>(); } },
                { "scheduledDateTime", n => { ScheduledDateTime = n.GetDateTimeOffsetValue(); } },
                { "startedDateTime", n => { StartedDateTime = n.GetDateTimeOffsetValue(); } },
                { "successfulUsersCount", n => { SuccessfulUsersCount = n.GetIntValue(); } },
                { "taskProcessingResults", n => { TaskProcessingResults = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.IdentityGovernance.TaskProcessingResult>(global::Microsoft.Graph.Models.IdentityGovernance.TaskProcessingResult.CreateFromDiscriminatorValue)?.AsList(); } },
                { "totalTasksCount", n => { TotalTasksCount = n.GetIntValue(); } },
                { "totalUnprocessedTasksCount", n => { TotalUnprocessedTasksCount = n.GetIntValue(); } },
                { "totalUsersCount", n => { TotalUsersCount = n.GetIntValue(); } },
                { "userProcessingResults", n => { UserProcessingResults = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.IdentityGovernance.UserProcessingResult>(global::Microsoft.Graph.Models.IdentityGovernance.UserProcessingResult.CreateFromDiscriminatorValue)?.AsList(); } },
                { "workflowExecutionType", n => { WorkflowExecutionType = n.GetEnumValue<global::Microsoft.Graph.Models.IdentityGovernance.WorkflowExecutionType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteIntValue("failedTasksCount", FailedTasksCount);
            writer.WriteIntValue("failedUsersCount", FailedUsersCount);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.IdentityGovernance.LifecycleWorkflowProcessingStatus>("processingStatus", ProcessingStatus);
            writer.WriteDateTimeOffsetValue("scheduledDateTime", ScheduledDateTime);
            writer.WriteDateTimeOffsetValue("startedDateTime", StartedDateTime);
            writer.WriteIntValue("successfulUsersCount", SuccessfulUsersCount);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.IdentityGovernance.TaskProcessingResult>("taskProcessingResults", TaskProcessingResults);
            writer.WriteIntValue("totalTasksCount", TotalTasksCount);
            writer.WriteIntValue("totalUnprocessedTasksCount", TotalUnprocessedTasksCount);
            writer.WriteIntValue("totalUsersCount", TotalUsersCount);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.IdentityGovernance.UserProcessingResult>("userProcessingResults", UserProcessingResults);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.IdentityGovernance.WorkflowExecutionType>("workflowExecutionType", WorkflowExecutionType);
        }
    }
}
