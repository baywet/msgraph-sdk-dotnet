// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>
    /// Policy used to configure detailed management settings targeted to specific security groups and for a specified set of apps on an iOS device
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class IosManagedAppProtection : global::Microsoft.Graph.Models.TargetedManagedAppProtection, IParsable
    {
        /// <summary>Represents the level to which app data is encrypted for managed apps</summary>
        public global::Microsoft.Graph.Models.ManagedAppDataEncryptionType? AppDataEncryptionType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ManagedAppDataEncryptionType?>("appDataEncryptionType"); }
            set { BackingStore?.Set("appDataEncryptionType", value); }
        }
        /// <summary>List of apps to which the policy is deployed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.ManagedMobileApp>? Apps
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ManagedMobileApp>?>("apps"); }
            set { BackingStore?.Set("apps", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.ManagedMobileApp> Apps
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ManagedMobileApp>>("apps"); }
            set { BackingStore?.Set("apps", value); }
        }
#endif
        /// <summary>A custom browser protocol to open weblink on iOS. When this property is configured, ManagedBrowserToOpenLinksRequired should be true.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomBrowserProtocol
        {
            get { return BackingStore?.Get<string?>("customBrowserProtocol"); }
            set { BackingStore?.Set("customBrowserProtocol", value); }
        }
#nullable restore
#else
        public string CustomBrowserProtocol
        {
            get { return BackingStore?.Get<string>("customBrowserProtocol"); }
            set { BackingStore?.Set("customBrowserProtocol", value); }
        }
#endif
        /// <summary>Count of apps to which the current policy is deployed.</summary>
        public int? DeployedAppCount
        {
            get { return BackingStore?.Get<int?>("deployedAppCount"); }
            set { BackingStore?.Set("deployedAppCount", value); }
        }
        /// <summary>Navigation property to deployment summary of the configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ManagedAppPolicyDeploymentSummary? DeploymentSummary
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ManagedAppPolicyDeploymentSummary?>("deploymentSummary"); }
            set { BackingStore?.Set("deploymentSummary", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ManagedAppPolicyDeploymentSummary DeploymentSummary
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ManagedAppPolicyDeploymentSummary>("deploymentSummary"); }
            set { BackingStore?.Set("deploymentSummary", value); }
        }
#endif
        /// <summary>Indicates whether use of the FaceID is allowed in place of a pin if PinRequired is set to True.</summary>
        public bool? FaceIdBlocked
        {
            get { return BackingStore?.Get<bool?>("faceIdBlocked"); }
            set { BackingStore?.Set("faceIdBlocked", value); }
        }
        /// <summary>Versions less than the specified version will block the managed app from accessing company data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumRequiredSdkVersion
        {
            get { return BackingStore?.Get<string?>("minimumRequiredSdkVersion"); }
            set { BackingStore?.Set("minimumRequiredSdkVersion", value); }
        }
#nullable restore
#else
        public string MinimumRequiredSdkVersion
        {
            get { return BackingStore?.Get<string>("minimumRequiredSdkVersion"); }
            set { BackingStore?.Set("minimumRequiredSdkVersion", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.IosManagedAppProtection"/> and sets the default values.
        /// </summary>
        public IosManagedAppProtection() : base()
        {
            OdataType = "#microsoft.graph.iosManagedAppProtection";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.IosManagedAppProtection"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.IosManagedAppProtection CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.IosManagedAppProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "appDataEncryptionType", n => { AppDataEncryptionType = n.GetEnumValue<global::Microsoft.Graph.Models.ManagedAppDataEncryptionType>(); } },
                { "apps", n => { Apps = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.ManagedMobileApp>(global::Microsoft.Graph.Models.ManagedMobileApp.CreateFromDiscriminatorValue)?.AsList(); } },
                { "customBrowserProtocol", n => { CustomBrowserProtocol = n.GetStringValue(); } },
                { "deployedAppCount", n => { DeployedAppCount = n.GetIntValue(); } },
                { "deploymentSummary", n => { DeploymentSummary = n.GetObjectValue<global::Microsoft.Graph.Models.ManagedAppPolicyDeploymentSummary>(global::Microsoft.Graph.Models.ManagedAppPolicyDeploymentSummary.CreateFromDiscriminatorValue); } },
                { "faceIdBlocked", n => { FaceIdBlocked = n.GetBoolValue(); } },
                { "minimumRequiredSdkVersion", n => { MinimumRequiredSdkVersion = n.GetStringValue(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Models.ManagedAppDataEncryptionType>("appDataEncryptionType", AppDataEncryptionType);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.ManagedMobileApp>("apps", Apps);
            writer.WriteStringValue("customBrowserProtocol", CustomBrowserProtocol);
            writer.WriteIntValue("deployedAppCount", DeployedAppCount);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ManagedAppPolicyDeploymentSummary>("deploymentSummary", DeploymentSummary);
            writer.WriteBoolValue("faceIdBlocked", FaceIdBlocked);
            writer.WriteStringValue("minimumRequiredSdkVersion", MinimumRequiredSdkVersion);
        }
    }
}
