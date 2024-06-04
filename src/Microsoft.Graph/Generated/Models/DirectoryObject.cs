// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class DirectoryObject : Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Date and time when this object was deleted. Always null when the object hasn&apos;t been deleted.</summary>
        public DateTimeOffset? DeletedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("deletedDateTime"); }
            set { BackingStore?.Set("deletedDateTime", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.DirectoryObject"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.DirectoryObject CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.activityBasedTimeoutPolicy" => new Microsoft.Graph.Models.ActivityBasedTimeoutPolicy(),
                "#microsoft.graph.administrativeUnit" => new Microsoft.Graph.Models.AdministrativeUnit(),
                "#microsoft.graph.application" => new Microsoft.Graph.Models.Application(),
                "#microsoft.graph.appManagementPolicy" => new Microsoft.Graph.Models.AppManagementPolicy(),
                "#microsoft.graph.appRoleAssignment" => new Microsoft.Graph.Models.AppRoleAssignment(),
                "#microsoft.graph.authorizationPolicy" => new Microsoft.Graph.Models.AuthorizationPolicy(),
                "#microsoft.graph.claimsMappingPolicy" => new Microsoft.Graph.Models.ClaimsMappingPolicy(),
                "#microsoft.graph.contract" => new Microsoft.Graph.Models.Contract(),
                "#microsoft.graph.crossTenantAccessPolicy" => new Microsoft.Graph.Models.CrossTenantAccessPolicy(),
                "#microsoft.graph.device" => new Microsoft.Graph.Models.Device(),
                "#microsoft.graph.directoryObjectPartnerReference" => new Microsoft.Graph.Models.DirectoryObjectPartnerReference(),
                "#microsoft.graph.directoryRole" => new Microsoft.Graph.Models.DirectoryRole(),
                "#microsoft.graph.directoryRoleTemplate" => new Microsoft.Graph.Models.DirectoryRoleTemplate(),
                "#microsoft.graph.endpoint" => new Microsoft.Graph.Models.Endpoint(),
                "#microsoft.graph.extensionProperty" => new Microsoft.Graph.Models.ExtensionProperty(),
                "#microsoft.graph.group" => new Microsoft.Graph.Models.Group(),
                "#microsoft.graph.groupSettingTemplate" => new Microsoft.Graph.Models.GroupSettingTemplate(),
                "#microsoft.graph.homeRealmDiscoveryPolicy" => new Microsoft.Graph.Models.HomeRealmDiscoveryPolicy(),
                "#microsoft.graph.identitySecurityDefaultsEnforcementPolicy" => new Microsoft.Graph.Models.IdentitySecurityDefaultsEnforcementPolicy(),
                "#microsoft.graph.multiTenantOrganizationMember" => new Microsoft.Graph.Models.MultiTenantOrganizationMember(),
                "#microsoft.graph.organization" => new Microsoft.Graph.Models.Organization(),
                "#microsoft.graph.orgContact" => new Microsoft.Graph.Models.OrgContact(),
                "#microsoft.graph.permissionGrantPolicy" => new Microsoft.Graph.Models.PermissionGrantPolicy(),
                "#microsoft.graph.policyBase" => new Microsoft.Graph.Models.PolicyBase(),
                "#microsoft.graph.resourceSpecificPermissionGrant" => new Microsoft.Graph.Models.ResourceSpecificPermissionGrant(),
                "#microsoft.graph.servicePrincipal" => new Microsoft.Graph.Models.ServicePrincipal(),
                "#microsoft.graph.stsPolicy" => new Microsoft.Graph.Models.StsPolicy(),
                "#microsoft.graph.tenantAppManagementPolicy" => new Microsoft.Graph.Models.TenantAppManagementPolicy(),
                "#microsoft.graph.tokenIssuancePolicy" => new Microsoft.Graph.Models.TokenIssuancePolicy(),
                "#microsoft.graph.tokenLifetimePolicy" => new Microsoft.Graph.Models.TokenLifetimePolicy(),
                "#microsoft.graph.user" => new Microsoft.Graph.Models.User(),
                _ => new Microsoft.Graph.Models.DirectoryObject(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "deletedDateTime", n => { DeletedDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteDateTimeOffsetValue("deletedDateTime", DeletedDateTime);
        }
    }
}
