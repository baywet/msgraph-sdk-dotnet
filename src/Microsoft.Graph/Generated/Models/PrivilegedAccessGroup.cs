// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class PrivilegedAccessGroup : Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The assignmentApprovals property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.Approval>? AssignmentApprovals
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.Approval>?>("assignmentApprovals"); }
            set { BackingStore?.Set("assignmentApprovals", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.Approval> AssignmentApprovals
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.Approval>>("assignmentApprovals"); }
            set { BackingStore?.Set("assignmentApprovals", value); }
        }
#endif
        /// <summary>The instances of assignment schedules to activate a just-in-time access.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.PrivilegedAccessGroupAssignmentScheduleInstance>? AssignmentScheduleInstances
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.PrivilegedAccessGroupAssignmentScheduleInstance>?>("assignmentScheduleInstances"); }
            set { BackingStore?.Set("assignmentScheduleInstances", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.PrivilegedAccessGroupAssignmentScheduleInstance> AssignmentScheduleInstances
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.PrivilegedAccessGroupAssignmentScheduleInstance>>("assignmentScheduleInstances"); }
            set { BackingStore?.Set("assignmentScheduleInstances", value); }
        }
#endif
        /// <summary>The schedule requests for operations to create, update, delete, extend, and renew an assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.PrivilegedAccessGroupAssignmentScheduleRequest>? AssignmentScheduleRequests
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.PrivilegedAccessGroupAssignmentScheduleRequest>?>("assignmentScheduleRequests"); }
            set { BackingStore?.Set("assignmentScheduleRequests", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.PrivilegedAccessGroupAssignmentScheduleRequest> AssignmentScheduleRequests
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.PrivilegedAccessGroupAssignmentScheduleRequest>>("assignmentScheduleRequests"); }
            set { BackingStore?.Set("assignmentScheduleRequests", value); }
        }
#endif
        /// <summary>The assignment schedules to activate a just-in-time access.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.PrivilegedAccessGroupAssignmentSchedule>? AssignmentSchedules
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.PrivilegedAccessGroupAssignmentSchedule>?>("assignmentSchedules"); }
            set { BackingStore?.Set("assignmentSchedules", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.PrivilegedAccessGroupAssignmentSchedule> AssignmentSchedules
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.PrivilegedAccessGroupAssignmentSchedule>>("assignmentSchedules"); }
            set { BackingStore?.Set("assignmentSchedules", value); }
        }
#endif
        /// <summary>The instances of eligibility schedules to activate a just-in-time access.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.PrivilegedAccessGroupEligibilityScheduleInstance>? EligibilityScheduleInstances
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.PrivilegedAccessGroupEligibilityScheduleInstance>?>("eligibilityScheduleInstances"); }
            set { BackingStore?.Set("eligibilityScheduleInstances", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.PrivilegedAccessGroupEligibilityScheduleInstance> EligibilityScheduleInstances
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.PrivilegedAccessGroupEligibilityScheduleInstance>>("eligibilityScheduleInstances"); }
            set { BackingStore?.Set("eligibilityScheduleInstances", value); }
        }
#endif
        /// <summary>The schedule requests for operations to create, update, delete, extend, and renew an eligibility.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.PrivilegedAccessGroupEligibilityScheduleRequest>? EligibilityScheduleRequests
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.PrivilegedAccessGroupEligibilityScheduleRequest>?>("eligibilityScheduleRequests"); }
            set { BackingStore?.Set("eligibilityScheduleRequests", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.PrivilegedAccessGroupEligibilityScheduleRequest> EligibilityScheduleRequests
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.PrivilegedAccessGroupEligibilityScheduleRequest>>("eligibilityScheduleRequests"); }
            set { BackingStore?.Set("eligibilityScheduleRequests", value); }
        }
#endif
        /// <summary>The eligibility schedules to activate a just-in-time access.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.PrivilegedAccessGroupEligibilitySchedule>? EligibilitySchedules
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.PrivilegedAccessGroupEligibilitySchedule>?>("eligibilitySchedules"); }
            set { BackingStore?.Set("eligibilitySchedules", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.PrivilegedAccessGroupEligibilitySchedule> EligibilitySchedules
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.PrivilegedAccessGroupEligibilitySchedule>>("eligibilitySchedules"); }
            set { BackingStore?.Set("eligibilitySchedules", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.PrivilegedAccessGroup"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.PrivilegedAccessGroup CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.PrivilegedAccessGroup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "assignmentApprovals", n => { AssignmentApprovals = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.Approval>(Microsoft.Graph.Models.Approval.CreateFromDiscriminatorValue)?.ToList(); } },
                { "assignmentScheduleInstances", n => { AssignmentScheduleInstances = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.PrivilegedAccessGroupAssignmentScheduleInstance>(Microsoft.Graph.Models.PrivilegedAccessGroupAssignmentScheduleInstance.CreateFromDiscriminatorValue)?.ToList(); } },
                { "assignmentScheduleRequests", n => { AssignmentScheduleRequests = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.PrivilegedAccessGroupAssignmentScheduleRequest>(Microsoft.Graph.Models.PrivilegedAccessGroupAssignmentScheduleRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                { "assignmentSchedules", n => { AssignmentSchedules = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.PrivilegedAccessGroupAssignmentSchedule>(Microsoft.Graph.Models.PrivilegedAccessGroupAssignmentSchedule.CreateFromDiscriminatorValue)?.ToList(); } },
                { "eligibilityScheduleInstances", n => { EligibilityScheduleInstances = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.PrivilegedAccessGroupEligibilityScheduleInstance>(Microsoft.Graph.Models.PrivilegedAccessGroupEligibilityScheduleInstance.CreateFromDiscriminatorValue)?.ToList(); } },
                { "eligibilityScheduleRequests", n => { EligibilityScheduleRequests = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.PrivilegedAccessGroupEligibilityScheduleRequest>(Microsoft.Graph.Models.PrivilegedAccessGroupEligibilityScheduleRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                { "eligibilitySchedules", n => { EligibilitySchedules = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.PrivilegedAccessGroupEligibilitySchedule>(Microsoft.Graph.Models.PrivilegedAccessGroupEligibilitySchedule.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.Approval>("assignmentApprovals", AssignmentApprovals);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.PrivilegedAccessGroupAssignmentScheduleInstance>("assignmentScheduleInstances", AssignmentScheduleInstances);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.PrivilegedAccessGroupAssignmentScheduleRequest>("assignmentScheduleRequests", AssignmentScheduleRequests);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.PrivilegedAccessGroupAssignmentSchedule>("assignmentSchedules", AssignmentSchedules);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.PrivilegedAccessGroupEligibilityScheduleInstance>("eligibilityScheduleInstances", EligibilityScheduleInstances);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.PrivilegedAccessGroupEligibilityScheduleRequest>("eligibilityScheduleRequests", EligibilityScheduleRequests);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.PrivilegedAccessGroupEligibilitySchedule>("eligibilitySchedules", EligibilitySchedules);
        }
    }
}
