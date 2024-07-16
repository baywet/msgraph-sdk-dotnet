// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class AccessReviewInstance : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Returns the collection of reviewers who were contacted to complete this review. While the reviewers and fallbackReviewers properties of the accessReviewScheduleDefinition might specify group owners or managers as reviewers, contactedReviewers returns their individual identities. Supports $select. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AccessReviewReviewer>? ContactedReviewers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AccessReviewReviewer>?>("contactedReviewers"); }
            set { BackingStore?.Set("contactedReviewers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AccessReviewReviewer> ContactedReviewers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AccessReviewReviewer>>("contactedReviewers"); }
            set { BackingStore?.Set("contactedReviewers", value); }
        }
#endif
        /// <summary>Each user reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AccessReviewInstanceDecisionItem>? Decisions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AccessReviewInstanceDecisionItem>?>("decisions"); }
            set { BackingStore?.Set("decisions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AccessReviewInstanceDecisionItem> Decisions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AccessReviewInstanceDecisionItem>>("decisions"); }
            set { BackingStore?.Set("decisions", value); }
        }
#endif
        /// <summary>DateTime when review instance is scheduled to end.The DatetimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $select. Read-only.</summary>
        public DateTimeOffset? EndDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
        /// <summary>This collection of reviewer scopes is used to define the list of fallback reviewers. These fallback reviewers will be notified to take action if no users are found from the list of reviewers specified. This could occur when either the group owner is specified as the reviewer but the group owner does not exist, or manager is specified as reviewer but a user&apos;s manager does not exist. Supports $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AccessReviewReviewerScope>? FallbackReviewers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AccessReviewReviewerScope>?>("fallbackReviewers"); }
            set { BackingStore?.Set("fallbackReviewers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AccessReviewReviewerScope> FallbackReviewers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AccessReviewReviewerScope>>("fallbackReviewers"); }
            set { BackingStore?.Set("fallbackReviewers", value); }
        }
#endif
        /// <summary>This collection of access review scopes is used to define who the reviewers are. Supports $select. For examples of options for assigning reviewers, see Assign reviewers to your access review definition using the Microsoft Graph API.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AccessReviewReviewerScope>? Reviewers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AccessReviewReviewerScope>?>("reviewers"); }
            set { BackingStore?.Set("reviewers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AccessReviewReviewerScope> Reviewers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AccessReviewReviewerScope>>("reviewers"); }
            set { BackingStore?.Set("reviewers", value); }
        }
#endif
        /// <summary>Created based on scope and instanceEnumerationScope at the accessReviewScheduleDefinition level. Defines the scope of users reviewed in a group. Supports $select and $filter (contains only). Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AccessReviewScope? Scope
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessReviewScope?>("scope"); }
            set { BackingStore?.Set("scope", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AccessReviewScope Scope
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessReviewScope>("scope"); }
            set { BackingStore?.Set("scope", value); }
        }
#endif
        /// <summary>If the instance has multiple stages, this returns the collection of stages. A new stage will only be created when the previous stage ends. The existence, number, and settings of stages on a review instance are created based on the accessReviewStageSettings on the parent accessReviewScheduleDefinition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AccessReviewStage>? Stages
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AccessReviewStage>?>("stages"); }
            set { BackingStore?.Set("stages", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AccessReviewStage> Stages
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AccessReviewStage>>("stages"); }
            set { BackingStore?.Set("stages", value); }
        }
#endif
        /// <summary>DateTime when review instance is scheduled to start. May be in the future. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $select. Read-only.</summary>
        public DateTimeOffset? StartDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>Specifies the status of an accessReview. Possible values: Initializing, NotStarted, Starting, InProgress, Completing, Completed, AutoReviewing, and AutoReviewed. Supports $select, $orderby, and $filter (eq only). Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status
        {
            get { return BackingStore?.Get<string?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#nullable restore
#else
        public string Status
        {
            get { return BackingStore?.Get<string>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.AccessReviewInstance"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.AccessReviewInstance CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.AccessReviewInstance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "contactedReviewers", n => { ContactedReviewers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AccessReviewReviewer>(global::Microsoft.Graph.Models.AccessReviewReviewer.CreateFromDiscriminatorValue)?.AsList(); } },
                { "decisions", n => { Decisions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AccessReviewInstanceDecisionItem>(global::Microsoft.Graph.Models.AccessReviewInstanceDecisionItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                { "fallbackReviewers", n => { FallbackReviewers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AccessReviewReviewerScope>(global::Microsoft.Graph.Models.AccessReviewReviewerScope.CreateFromDiscriminatorValue)?.AsList(); } },
                { "reviewers", n => { Reviewers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AccessReviewReviewerScope>(global::Microsoft.Graph.Models.AccessReviewReviewerScope.CreateFromDiscriminatorValue)?.AsList(); } },
                { "scope", n => { Scope = n.GetObjectValue<global::Microsoft.Graph.Models.AccessReviewScope>(global::Microsoft.Graph.Models.AccessReviewScope.CreateFromDiscriminatorValue); } },
                { "stages", n => { Stages = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AccessReviewStage>(global::Microsoft.Graph.Models.AccessReviewStage.CreateFromDiscriminatorValue)?.AsList(); } },
                { "startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                { "status", n => { Status = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AccessReviewReviewer>("contactedReviewers", ContactedReviewers);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AccessReviewInstanceDecisionItem>("decisions", Decisions);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AccessReviewReviewerScope>("fallbackReviewers", FallbackReviewers);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AccessReviewReviewerScope>("reviewers", Reviewers);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AccessReviewScope>("scope", Scope);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AccessReviewStage>("stages", Stages);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("status", Status);
        }
    }
}
