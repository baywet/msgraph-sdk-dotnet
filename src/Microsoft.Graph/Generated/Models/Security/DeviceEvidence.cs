// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class DeviceEvidence : global::Microsoft.Graph.Models.Security.AlertEvidence, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A unique identifier assigned to a device by Microsoft Entra ID when device is Microsoft Entra joined.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureAdDeviceId
        {
            get { return BackingStore?.Get<string?>("azureAdDeviceId"); }
            set { BackingStore?.Set("azureAdDeviceId", value); }
        }
#nullable restore
#else
        public string AzureAdDeviceId
        {
            get { return BackingStore?.Get<string>("azureAdDeviceId"); }
            set { BackingStore?.Set("azureAdDeviceId", value); }
        }
#endif
        /// <summary>State of the Defender AntiMalware engine. The possible values are: notReporting, disabled, notUpdated, updated, unknown, notSupported, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.Security.DefenderAvStatus? DefenderAvStatus
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.DefenderAvStatus?>("defenderAvStatus"); }
            set { BackingStore?.Set("defenderAvStatus", value); }
        }
        /// <summary>The fully qualified domain name (FQDN) for the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceDnsName
        {
            get { return BackingStore?.Get<string?>("deviceDnsName"); }
            set { BackingStore?.Set("deviceDnsName", value); }
        }
#nullable restore
#else
        public string DeviceDnsName
        {
            get { return BackingStore?.Get<string>("deviceDnsName"); }
            set { BackingStore?.Set("deviceDnsName", value); }
        }
#endif
        /// <summary>The date and time when the device was first seen.</summary>
        public DateTimeOffset? FirstSeenDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("firstSeenDateTime"); }
            set { BackingStore?.Set("firstSeenDateTime", value); }
        }
        /// <summary>The health state of the device. The possible values are: active, inactive, impairedCommunication, noSensorData, noSensorDataImpairedCommunication, unknown, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.Security.DeviceHealthStatus? HealthStatus
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.DeviceHealthStatus?>("healthStatus"); }
            set { BackingStore?.Set("healthStatus", value); }
        }
        /// <summary>Ip interfaces of the device during the time of the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? IpInterfaces
        {
            get { return BackingStore?.Get<List<string>?>("ipInterfaces"); }
            set { BackingStore?.Set("ipInterfaces", value); }
        }
#nullable restore
#else
        public List<string> IpInterfaces
        {
            get { return BackingStore?.Get<List<string>>("ipInterfaces"); }
            set { BackingStore?.Set("ipInterfaces", value); }
        }
#endif
        /// <summary>The lastExternalIpAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastExternalIpAddress
        {
            get { return BackingStore?.Get<string?>("lastExternalIpAddress"); }
            set { BackingStore?.Set("lastExternalIpAddress", value); }
        }
#nullable restore
#else
        public string LastExternalIpAddress
        {
            get { return BackingStore?.Get<string>("lastExternalIpAddress"); }
            set { BackingStore?.Set("lastExternalIpAddress", value); }
        }
#endif
        /// <summary>The lastIpAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastIpAddress
        {
            get { return BackingStore?.Get<string?>("lastIpAddress"); }
            set { BackingStore?.Set("lastIpAddress", value); }
        }
#nullable restore
#else
        public string LastIpAddress
        {
            get { return BackingStore?.Get<string>("lastIpAddress"); }
            set { BackingStore?.Set("lastIpAddress", value); }
        }
#endif
        /// <summary>Users that were logged on the machine during the time of the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.LoggedOnUser>? LoggedOnUsers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.LoggedOnUser>?>("loggedOnUsers"); }
            set { BackingStore?.Set("loggedOnUsers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.LoggedOnUser> LoggedOnUsers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.LoggedOnUser>>("loggedOnUsers"); }
            set { BackingStore?.Set("loggedOnUsers", value); }
        }
#endif
        /// <summary>A unique identifier assigned to a device by Microsoft Defender for Endpoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MdeDeviceId
        {
            get { return BackingStore?.Get<string?>("mdeDeviceId"); }
            set { BackingStore?.Set("mdeDeviceId", value); }
        }
#nullable restore
#else
        public string MdeDeviceId
        {
            get { return BackingStore?.Get<string>("mdeDeviceId"); }
            set { BackingStore?.Set("mdeDeviceId", value); }
        }
#endif
        /// <summary>The status of the machine onboarding to Microsoft Defender for Endpoint. The possible values are: insufficientInfo, onboarded, canBeOnboarded, unsupported, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.Security.OnboardingStatus? OnboardingStatus
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.OnboardingStatus?>("onboardingStatus"); }
            set { BackingStore?.Set("onboardingStatus", value); }
        }
        /// <summary>The build version for the operating system the device is running.</summary>
        public long? OsBuild
        {
            get { return BackingStore?.Get<long?>("osBuild"); }
            set { BackingStore?.Set("osBuild", value); }
        }
        /// <summary>The operating system platform the device is running.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsPlatform
        {
            get { return BackingStore?.Get<string?>("osPlatform"); }
            set { BackingStore?.Set("osPlatform", value); }
        }
#nullable restore
#else
        public string OsPlatform
        {
            get { return BackingStore?.Get<string>("osPlatform"); }
            set { BackingStore?.Set("osPlatform", value); }
        }
#endif
        /// <summary>The ID of the role-based access control (RBAC) device group.</summary>
        public int? RbacGroupId
        {
            get { return BackingStore?.Get<int?>("rbacGroupId"); }
            set { BackingStore?.Set("rbacGroupId", value); }
        }
        /// <summary>The name of the RBAC device group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RbacGroupName
        {
            get { return BackingStore?.Get<string?>("rbacGroupName"); }
            set { BackingStore?.Set("rbacGroupName", value); }
        }
#nullable restore
#else
        public string RbacGroupName
        {
            get { return BackingStore?.Get<string>("rbacGroupName"); }
            set { BackingStore?.Set("rbacGroupName", value); }
        }
#endif
        /// <summary>Risk score as evaluated by Microsoft Defender for Endpoint. The possible values are: none, informational, low, medium, high, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.Security.DeviceRiskScore? RiskScore
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.DeviceRiskScore?>("riskScore"); }
            set { BackingStore?.Set("riskScore", value); }
        }
        /// <summary>The version of the operating system platform.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version
        {
            get { return BackingStore?.Get<string?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#nullable restore
#else
        public string Version
        {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#endif
        /// <summary>Metadata of the virtual machine (VM) on which Microsoft Defender for Endpoint is running.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.VmMetadata? VmMetadata
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.VmMetadata?>("vmMetadata"); }
            set { BackingStore?.Set("vmMetadata", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.VmMetadata VmMetadata
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.VmMetadata>("vmMetadata"); }
            set { BackingStore?.Set("vmMetadata", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.Security.DeviceEvidence"/> and sets the default values.
        /// </summary>
        public DeviceEvidence() : base()
        {
            OdataType = "#microsoft.graph.security.deviceEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Security.DeviceEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Security.DeviceEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Security.DeviceEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "azureAdDeviceId", n => { AzureAdDeviceId = n.GetStringValue(); } },
                { "defenderAvStatus", n => { DefenderAvStatus = n.GetEnumValue<global::Microsoft.Graph.Models.Security.DefenderAvStatus>(); } },
                { "deviceDnsName", n => { DeviceDnsName = n.GetStringValue(); } },
                { "firstSeenDateTime", n => { FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                { "healthStatus", n => { HealthStatus = n.GetEnumValue<global::Microsoft.Graph.Models.Security.DeviceHealthStatus>(); } },
                { "ipInterfaces", n => { IpInterfaces = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "lastExternalIpAddress", n => { LastExternalIpAddress = n.GetStringValue(); } },
                { "lastIpAddress", n => { LastIpAddress = n.GetStringValue(); } },
                { "loggedOnUsers", n => { LoggedOnUsers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.LoggedOnUser>(global::Microsoft.Graph.Models.Security.LoggedOnUser.CreateFromDiscriminatorValue)?.AsList(); } },
                { "mdeDeviceId", n => { MdeDeviceId = n.GetStringValue(); } },
                { "onboardingStatus", n => { OnboardingStatus = n.GetEnumValue<global::Microsoft.Graph.Models.Security.OnboardingStatus>(); } },
                { "osBuild", n => { OsBuild = n.GetLongValue(); } },
                { "osPlatform", n => { OsPlatform = n.GetStringValue(); } },
                { "rbacGroupId", n => { RbacGroupId = n.GetIntValue(); } },
                { "rbacGroupName", n => { RbacGroupName = n.GetStringValue(); } },
                { "riskScore", n => { RiskScore = n.GetEnumValue<global::Microsoft.Graph.Models.Security.DeviceRiskScore>(); } },
                { "version", n => { Version = n.GetStringValue(); } },
                { "vmMetadata", n => { VmMetadata = n.GetObjectValue<global::Microsoft.Graph.Models.Security.VmMetadata>(global::Microsoft.Graph.Models.Security.VmMetadata.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("azureAdDeviceId", AzureAdDeviceId);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Security.DefenderAvStatus>("defenderAvStatus", DefenderAvStatus);
            writer.WriteStringValue("deviceDnsName", DeviceDnsName);
            writer.WriteDateTimeOffsetValue("firstSeenDateTime", FirstSeenDateTime);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Security.DeviceHealthStatus>("healthStatus", HealthStatus);
            writer.WriteCollectionOfPrimitiveValues<string>("ipInterfaces", IpInterfaces);
            writer.WriteStringValue("lastExternalIpAddress", LastExternalIpAddress);
            writer.WriteStringValue("lastIpAddress", LastIpAddress);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.LoggedOnUser>("loggedOnUsers", LoggedOnUsers);
            writer.WriteStringValue("mdeDeviceId", MdeDeviceId);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Security.OnboardingStatus>("onboardingStatus", OnboardingStatus);
            writer.WriteLongValue("osBuild", OsBuild);
            writer.WriteStringValue("osPlatform", OsPlatform);
            writer.WriteIntValue("rbacGroupId", RbacGroupId);
            writer.WriteStringValue("rbacGroupName", RbacGroupName);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Security.DeviceRiskScore>("riskScore", RiskScore);
            writer.WriteStringValue("version", Version);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.VmMetadata>("vmMetadata", VmMetadata);
        }
    }
}
