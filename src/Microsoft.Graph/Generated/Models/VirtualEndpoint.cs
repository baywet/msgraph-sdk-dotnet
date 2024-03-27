// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class VirtualEndpoint : Entity, IParsable 
    {
        /// <summary>A collection of Cloud PC audit events.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcAuditEvent>? AuditEvents {
            get { return BackingStore?.Get<List<CloudPcAuditEvent>?>("auditEvents"); }
            set { BackingStore?.Set("auditEvents", value); }
        }
#nullable restore
#else
        public List<CloudPcAuditEvent> AuditEvents {
            get { return BackingStore?.Get<List<CloudPcAuditEvent>>("auditEvents"); }
            set { BackingStore?.Set("auditEvents", value); }
        }
#endif
        /// <summary>A collection of cloud-managed virtual desktops.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPC>? CloudPCs {
            get { return BackingStore?.Get<List<CloudPC>?>("cloudPCs"); }
            set { BackingStore?.Set("cloudPCs", value); }
        }
#nullable restore
#else
        public List<CloudPC> CloudPCs {
            get { return BackingStore?.Get<List<CloudPC>>("cloudPCs"); }
            set { BackingStore?.Set("cloudPCs", value); }
        }
#endif
        /// <summary>A collection of device image resources on Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcDeviceImage>? DeviceImages {
            get { return BackingStore?.Get<List<CloudPcDeviceImage>?>("deviceImages"); }
            set { BackingStore?.Set("deviceImages", value); }
        }
#nullable restore
#else
        public List<CloudPcDeviceImage> DeviceImages {
            get { return BackingStore?.Get<List<CloudPcDeviceImage>>("deviceImages"); }
            set { BackingStore?.Set("deviceImages", value); }
        }
#endif
        /// <summary>A collection of gallery image resources on Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcGalleryImage>? GalleryImages {
            get { return BackingStore?.Get<List<CloudPcGalleryImage>?>("galleryImages"); }
            set { BackingStore?.Set("galleryImages", value); }
        }
#nullable restore
#else
        public List<CloudPcGalleryImage> GalleryImages {
            get { return BackingStore?.Get<List<CloudPcGalleryImage>>("galleryImages"); }
            set { BackingStore?.Set("galleryImages", value); }
        }
#endif
        /// <summary>A defined collection of Azure resource information that can be used to establish Azure network connections for Cloud PCs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcOnPremisesConnection>? OnPremisesConnections {
            get { return BackingStore?.Get<List<CloudPcOnPremisesConnection>?>("onPremisesConnections"); }
            set { BackingStore?.Set("onPremisesConnections", value); }
        }
#nullable restore
#else
        public List<CloudPcOnPremisesConnection> OnPremisesConnections {
            get { return BackingStore?.Get<List<CloudPcOnPremisesConnection>>("onPremisesConnections"); }
            set { BackingStore?.Set("onPremisesConnections", value); }
        }
#endif
        /// <summary>A collection of Cloud PC provisioning policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcProvisioningPolicy>? ProvisioningPolicies {
            get { return BackingStore?.Get<List<CloudPcProvisioningPolicy>?>("provisioningPolicies"); }
            set { BackingStore?.Set("provisioningPolicies", value); }
        }
#nullable restore
#else
        public List<CloudPcProvisioningPolicy> ProvisioningPolicies {
            get { return BackingStore?.Get<List<CloudPcProvisioningPolicy>>("provisioningPolicies"); }
            set { BackingStore?.Set("provisioningPolicies", value); }
        }
#endif
        /// <summary>A collection of Cloud PC user settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcUserSetting>? UserSettings {
            get { return BackingStore?.Get<List<CloudPcUserSetting>?>("userSettings"); }
            set { BackingStore?.Set("userSettings", value); }
        }
#nullable restore
#else
        public List<CloudPcUserSetting> UserSettings {
            get { return BackingStore?.Get<List<CloudPcUserSetting>>("userSettings"); }
            set { BackingStore?.Set("userSettings", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="VirtualEndpoint"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new VirtualEndpoint CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VirtualEndpoint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"auditEvents", n => { AuditEvents = n.GetCollectionOfObjectValues<CloudPcAuditEvent>(CloudPcAuditEvent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"cloudPCs", n => { CloudPCs = n.GetCollectionOfObjectValues<CloudPC>(CloudPC.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceImages", n => { DeviceImages = n.GetCollectionOfObjectValues<CloudPcDeviceImage>(CloudPcDeviceImage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"galleryImages", n => { GalleryImages = n.GetCollectionOfObjectValues<CloudPcGalleryImage>(CloudPcGalleryImage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"onPremisesConnections", n => { OnPremisesConnections = n.GetCollectionOfObjectValues<CloudPcOnPremisesConnection>(CloudPcOnPremisesConnection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"provisioningPolicies", n => { ProvisioningPolicies = n.GetCollectionOfObjectValues<CloudPcProvisioningPolicy>(CloudPcProvisioningPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userSettings", n => { UserSettings = n.GetCollectionOfObjectValues<CloudPcUserSetting>(CloudPcUserSetting.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<CloudPcAuditEvent>("auditEvents", AuditEvents);
            writer.WriteCollectionOfObjectValues<CloudPC>("cloudPCs", CloudPCs);
            writer.WriteCollectionOfObjectValues<CloudPcDeviceImage>("deviceImages", DeviceImages);
            writer.WriteCollectionOfObjectValues<CloudPcGalleryImage>("galleryImages", GalleryImages);
            writer.WriteCollectionOfObjectValues<CloudPcOnPremisesConnection>("onPremisesConnections", OnPremisesConnections);
            writer.WriteCollectionOfObjectValues<CloudPcProvisioningPolicy>("provisioningPolicies", ProvisioningPolicies);
            writer.WriteCollectionOfObjectValues<CloudPcUserSetting>("userSettings", UserSettings);
        }
    }
}
