// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class AccessPackageApprovalStage : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The number of days that a request can be pending a response before it is automatically denied.</summary>
        public TimeSpan? DurationBeforeAutomaticDenial
        {
            get { return BackingStore?.Get<TimeSpan?>("durationBeforeAutomaticDenial"); }
            set { BackingStore?.Set("durationBeforeAutomaticDenial", value); }
        }
        /// <summary>If escalation is required, the time a request can be pending a response from a primary approver.</summary>
        public TimeSpan? DurationBeforeEscalation
        {
            get { return BackingStore?.Get<TimeSpan?>("durationBeforeEscalation"); }
            set { BackingStore?.Set("durationBeforeEscalation", value); }
        }
        /// <summary>If escalation is enabled and the primary approvers do not respond before the escalation time, the escalationApprovers are the users who will be asked to approve requests.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.SubjectSet>? EscalationApprovers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SubjectSet>?>("escalationApprovers"); }
            set { BackingStore?.Set("escalationApprovers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.SubjectSet> EscalationApprovers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SubjectSet>>("escalationApprovers"); }
            set { BackingStore?.Set("escalationApprovers", value); }
        }
#endif
        /// <summary>The subjects, typically users, who are the fallback escalation approvers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.SubjectSet>? FallbackEscalationApprovers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SubjectSet>?>("fallbackEscalationApprovers"); }
            set { BackingStore?.Set("fallbackEscalationApprovers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.SubjectSet> FallbackEscalationApprovers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SubjectSet>>("fallbackEscalationApprovers"); }
            set { BackingStore?.Set("fallbackEscalationApprovers", value); }
        }
#endif
        /// <summary>The subjects, typically users, who are the fallback primary approvers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.SubjectSet>? FallbackPrimaryApprovers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SubjectSet>?>("fallbackPrimaryApprovers"); }
            set { BackingStore?.Set("fallbackPrimaryApprovers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.SubjectSet> FallbackPrimaryApprovers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SubjectSet>>("fallbackPrimaryApprovers"); }
            set { BackingStore?.Set("fallbackPrimaryApprovers", value); }
        }
#endif
        /// <summary>Indicates whether the approver is required to provide a justification for approving a request.</summary>
        public bool? IsApproverJustificationRequired
        {
            get { return BackingStore?.Get<bool?>("isApproverJustificationRequired"); }
            set { BackingStore?.Set("isApproverJustificationRequired", value); }
        }
        /// <summary>If true, then one or more escalationApprovers are configured in this approval stage.</summary>
        public bool? IsEscalationEnabled
        {
            get { return BackingStore?.Get<bool?>("isEscalationEnabled"); }
            set { BackingStore?.Set("isEscalationEnabled", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The subjects, typically users, who will be asked to approve requests. A collection of singleUser, groupMembers, requestorManager, internalSponsors, externalSponsors, or targetUserSponsors.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.SubjectSet>? PrimaryApprovers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SubjectSet>?>("primaryApprovers"); }
            set { BackingStore?.Set("primaryApprovers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.SubjectSet> PrimaryApprovers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SubjectSet>>("primaryApprovers"); }
            set { BackingStore?.Set("primaryApprovers", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.AccessPackageApprovalStage"/> and sets the default values.
        /// </summary>
        public AccessPackageApprovalStage()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.AccessPackageApprovalStage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.AccessPackageApprovalStage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.AccessPackageApprovalStage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "durationBeforeAutomaticDenial", n => { DurationBeforeAutomaticDenial = n.GetTimeSpanValue(); } },
                { "durationBeforeEscalation", n => { DurationBeforeEscalation = n.GetTimeSpanValue(); } },
                { "escalationApprovers", n => { EscalationApprovers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.SubjectSet>(global::Microsoft.Graph.Models.SubjectSet.CreateFromDiscriminatorValue)?.AsList(); } },
                { "fallbackEscalationApprovers", n => { FallbackEscalationApprovers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.SubjectSet>(global::Microsoft.Graph.Models.SubjectSet.CreateFromDiscriminatorValue)?.AsList(); } },
                { "fallbackPrimaryApprovers", n => { FallbackPrimaryApprovers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.SubjectSet>(global::Microsoft.Graph.Models.SubjectSet.CreateFromDiscriminatorValue)?.AsList(); } },
                { "isApproverJustificationRequired", n => { IsApproverJustificationRequired = n.GetBoolValue(); } },
                { "isEscalationEnabled", n => { IsEscalationEnabled = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "primaryApprovers", n => { PrimaryApprovers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.SubjectSet>(global::Microsoft.Graph.Models.SubjectSet.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteTimeSpanValue("durationBeforeAutomaticDenial", DurationBeforeAutomaticDenial);
            writer.WriteTimeSpanValue("durationBeforeEscalation", DurationBeforeEscalation);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.SubjectSet>("escalationApprovers", EscalationApprovers);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.SubjectSet>("fallbackEscalationApprovers", FallbackEscalationApprovers);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.SubjectSet>("fallbackPrimaryApprovers", FallbackPrimaryApprovers);
            writer.WriteBoolValue("isApproverJustificationRequired", IsApproverJustificationRequired);
            writer.WriteBoolValue("isEscalationEnabled", IsEscalationEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.SubjectSet>("primaryApprovers", PrimaryApprovers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
