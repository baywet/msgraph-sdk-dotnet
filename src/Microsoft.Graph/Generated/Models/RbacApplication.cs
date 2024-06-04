// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class RbacApplication : Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The resourceNamespaces property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.UnifiedRbacResourceNamespace>? ResourceNamespaces
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UnifiedRbacResourceNamespace>?>("resourceNamespaces"); }
            set { BackingStore?.Set("resourceNamespaces", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.UnifiedRbacResourceNamespace> ResourceNamespaces
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UnifiedRbacResourceNamespace>>("resourceNamespaces"); }
            set { BackingStore?.Set("resourceNamespaces", value); }
        }
#endif
        /// <summary>Resource to grant access to users or groups.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.UnifiedRoleAssignment>? RoleAssignments
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UnifiedRoleAssignment>?>("roleAssignments"); }
            set { BackingStore?.Set("roleAssignments", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.UnifiedRoleAssignment> RoleAssignments
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UnifiedRoleAssignment>>("roleAssignments"); }
            set { BackingStore?.Set("roleAssignments", value); }
        }
#endif
        /// <summary>Instances for active role assignments.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.UnifiedRoleAssignmentScheduleInstance>? RoleAssignmentScheduleInstances
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UnifiedRoleAssignmentScheduleInstance>?>("roleAssignmentScheduleInstances"); }
            set { BackingStore?.Set("roleAssignmentScheduleInstances", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.UnifiedRoleAssignmentScheduleInstance> RoleAssignmentScheduleInstances
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UnifiedRoleAssignmentScheduleInstance>>("roleAssignmentScheduleInstances"); }
            set { BackingStore?.Set("roleAssignmentScheduleInstances", value); }
        }
#endif
        /// <summary>Requests for active role assignments to principals through PIM.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.UnifiedRoleAssignmentScheduleRequest>? RoleAssignmentScheduleRequests
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UnifiedRoleAssignmentScheduleRequest>?>("roleAssignmentScheduleRequests"); }
            set { BackingStore?.Set("roleAssignmentScheduleRequests", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.UnifiedRoleAssignmentScheduleRequest> RoleAssignmentScheduleRequests
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UnifiedRoleAssignmentScheduleRequest>>("roleAssignmentScheduleRequests"); }
            set { BackingStore?.Set("roleAssignmentScheduleRequests", value); }
        }
#endif
        /// <summary>Schedules for active role assignment operations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.UnifiedRoleAssignmentSchedule>? RoleAssignmentSchedules
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UnifiedRoleAssignmentSchedule>?>("roleAssignmentSchedules"); }
            set { BackingStore?.Set("roleAssignmentSchedules", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.UnifiedRoleAssignmentSchedule> RoleAssignmentSchedules
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UnifiedRoleAssignmentSchedule>>("roleAssignmentSchedules"); }
            set { BackingStore?.Set("roleAssignmentSchedules", value); }
        }
#endif
        /// <summary>Resource representing the roles allowed by RBAC providers and the permissions assigned to the roles.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.UnifiedRoleDefinition>? RoleDefinitions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UnifiedRoleDefinition>?>("roleDefinitions"); }
            set { BackingStore?.Set("roleDefinitions", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.UnifiedRoleDefinition> RoleDefinitions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UnifiedRoleDefinition>>("roleDefinitions"); }
            set { BackingStore?.Set("roleDefinitions", value); }
        }
#endif
        /// <summary>Instances for role eligibility requests.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.UnifiedRoleEligibilityScheduleInstance>? RoleEligibilityScheduleInstances
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UnifiedRoleEligibilityScheduleInstance>?>("roleEligibilityScheduleInstances"); }
            set { BackingStore?.Set("roleEligibilityScheduleInstances", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.UnifiedRoleEligibilityScheduleInstance> RoleEligibilityScheduleInstances
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UnifiedRoleEligibilityScheduleInstance>>("roleEligibilityScheduleInstances"); }
            set { BackingStore?.Set("roleEligibilityScheduleInstances", value); }
        }
#endif
        /// <summary>Requests for role eligibilities for principals through PIM.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.UnifiedRoleEligibilityScheduleRequest>? RoleEligibilityScheduleRequests
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UnifiedRoleEligibilityScheduleRequest>?>("roleEligibilityScheduleRequests"); }
            set { BackingStore?.Set("roleEligibilityScheduleRequests", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.UnifiedRoleEligibilityScheduleRequest> RoleEligibilityScheduleRequests
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UnifiedRoleEligibilityScheduleRequest>>("roleEligibilityScheduleRequests"); }
            set { BackingStore?.Set("roleEligibilityScheduleRequests", value); }
        }
#endif
        /// <summary>Schedules for role eligibility operations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.UnifiedRoleEligibilitySchedule>? RoleEligibilitySchedules
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UnifiedRoleEligibilitySchedule>?>("roleEligibilitySchedules"); }
            set { BackingStore?.Set("roleEligibilitySchedules", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.UnifiedRoleEligibilitySchedule> RoleEligibilitySchedules
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UnifiedRoleEligibilitySchedule>>("roleEligibilitySchedules"); }
            set { BackingStore?.Set("roleEligibilitySchedules", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.RbacApplication"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.RbacApplication CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.RbacApplication();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "resourceNamespaces", n => { ResourceNamespaces = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.UnifiedRbacResourceNamespace>(Microsoft.Graph.Models.UnifiedRbacResourceNamespace.CreateFromDiscriminatorValue)?.ToList(); } },
                { "roleAssignmentScheduleInstances", n => { RoleAssignmentScheduleInstances = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.UnifiedRoleAssignmentScheduleInstance>(Microsoft.Graph.Models.UnifiedRoleAssignmentScheduleInstance.CreateFromDiscriminatorValue)?.ToList(); } },
                { "roleAssignmentScheduleRequests", n => { RoleAssignmentScheduleRequests = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.UnifiedRoleAssignmentScheduleRequest>(Microsoft.Graph.Models.UnifiedRoleAssignmentScheduleRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                { "roleAssignmentSchedules", n => { RoleAssignmentSchedules = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.UnifiedRoleAssignmentSchedule>(Microsoft.Graph.Models.UnifiedRoleAssignmentSchedule.CreateFromDiscriminatorValue)?.ToList(); } },
                { "roleAssignments", n => { RoleAssignments = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.UnifiedRoleAssignment>(Microsoft.Graph.Models.UnifiedRoleAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                { "roleDefinitions", n => { RoleDefinitions = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.UnifiedRoleDefinition>(Microsoft.Graph.Models.UnifiedRoleDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                { "roleEligibilityScheduleInstances", n => { RoleEligibilityScheduleInstances = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.UnifiedRoleEligibilityScheduleInstance>(Microsoft.Graph.Models.UnifiedRoleEligibilityScheduleInstance.CreateFromDiscriminatorValue)?.ToList(); } },
                { "roleEligibilityScheduleRequests", n => { RoleEligibilityScheduleRequests = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.UnifiedRoleEligibilityScheduleRequest>(Microsoft.Graph.Models.UnifiedRoleEligibilityScheduleRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                { "roleEligibilitySchedules", n => { RoleEligibilitySchedules = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.UnifiedRoleEligibilitySchedule>(Microsoft.Graph.Models.UnifiedRoleEligibilitySchedule.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.UnifiedRbacResourceNamespace>("resourceNamespaces", ResourceNamespaces);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.UnifiedRoleAssignment>("roleAssignments", RoleAssignments);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.UnifiedRoleAssignmentScheduleInstance>("roleAssignmentScheduleInstances", RoleAssignmentScheduleInstances);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.UnifiedRoleAssignmentScheduleRequest>("roleAssignmentScheduleRequests", RoleAssignmentScheduleRequests);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.UnifiedRoleAssignmentSchedule>("roleAssignmentSchedules", RoleAssignmentSchedules);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.UnifiedRoleDefinition>("roleDefinitions", RoleDefinitions);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.UnifiedRoleEligibilityScheduleInstance>("roleEligibilityScheduleInstances", RoleEligibilityScheduleInstances);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.UnifiedRoleEligibilityScheduleRequest>("roleEligibilityScheduleRequests", RoleEligibilityScheduleRequests);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.UnifiedRoleEligibilitySchedule>("roleEligibilitySchedules", RoleEligibilitySchedules);
        }
    }
}
