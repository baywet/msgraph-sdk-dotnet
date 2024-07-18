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
    public partial class IoTDeviceEvidence : global::Microsoft.Graph.Models.Security.AlertEvidence, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The deviceId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId
        {
            get { return BackingStore?.Get<string?>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#nullable restore
#else
        public string DeviceId
        {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#endif
        /// <summary>The deviceName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName
        {
            get { return BackingStore?.Get<string?>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#nullable restore
#else
        public string DeviceName
        {
            get { return BackingStore?.Get<string>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#endif
        /// <summary>The devicePageLink property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DevicePageLink
        {
            get { return BackingStore?.Get<string?>("devicePageLink"); }
            set { BackingStore?.Set("devicePageLink", value); }
        }
#nullable restore
#else
        public string DevicePageLink
        {
            get { return BackingStore?.Get<string>("devicePageLink"); }
            set { BackingStore?.Set("devicePageLink", value); }
        }
#endif
        /// <summary>The deviceSubType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceSubType
        {
            get { return BackingStore?.Get<string?>("deviceSubType"); }
            set { BackingStore?.Set("deviceSubType", value); }
        }
#nullable restore
#else
        public string DeviceSubType
        {
            get { return BackingStore?.Get<string>("deviceSubType"); }
            set { BackingStore?.Set("deviceSubType", value); }
        }
#endif
        /// <summary>The deviceType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceType
        {
            get { return BackingStore?.Get<string?>("deviceType"); }
            set { BackingStore?.Set("deviceType", value); }
        }
#nullable restore
#else
        public string DeviceType
        {
            get { return BackingStore?.Get<string>("deviceType"); }
            set { BackingStore?.Set("deviceType", value); }
        }
#endif
        /// <summary>The importance property</summary>
        public global::Microsoft.Graph.Models.Security.IoTDeviceImportanceType? Importance
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.IoTDeviceImportanceType?>("importance"); }
            set { BackingStore?.Set("importance", value); }
        }
        /// <summary>The ioTHub property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.AzureResourceEvidence? IoTHub
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.AzureResourceEvidence?>("ioTHub"); }
            set { BackingStore?.Set("ioTHub", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.AzureResourceEvidence IoTHub
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.AzureResourceEvidence>("ioTHub"); }
            set { BackingStore?.Set("ioTHub", value); }
        }
#endif
        /// <summary>The ioTSecurityAgentId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IoTSecurityAgentId
        {
            get { return BackingStore?.Get<string?>("ioTSecurityAgentId"); }
            set { BackingStore?.Set("ioTSecurityAgentId", value); }
        }
#nullable restore
#else
        public string IoTSecurityAgentId
        {
            get { return BackingStore?.Get<string>("ioTSecurityAgentId"); }
            set { BackingStore?.Set("ioTSecurityAgentId", value); }
        }
#endif
        /// <summary>The ipAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.IpEvidence? IpAddress
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.IpEvidence?>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.IpEvidence IpAddress
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.IpEvidence>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
        }
#endif
        /// <summary>The isAuthorized property</summary>
        public bool? IsAuthorized
        {
            get { return BackingStore?.Get<bool?>("isAuthorized"); }
            set { BackingStore?.Set("isAuthorized", value); }
        }
        /// <summary>The isProgramming property</summary>
        public bool? IsProgramming
        {
            get { return BackingStore?.Get<bool?>("isProgramming"); }
            set { BackingStore?.Set("isProgramming", value); }
        }
        /// <summary>The isScanner property</summary>
        public bool? IsScanner
        {
            get { return BackingStore?.Get<bool?>("isScanner"); }
            set { BackingStore?.Set("isScanner", value); }
        }
        /// <summary>The macAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MacAddress
        {
            get { return BackingStore?.Get<string?>("macAddress"); }
            set { BackingStore?.Set("macAddress", value); }
        }
#nullable restore
#else
        public string MacAddress
        {
            get { return BackingStore?.Get<string>("macAddress"); }
            set { BackingStore?.Set("macAddress", value); }
        }
#endif
        /// <summary>The manufacturer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manufacturer
        {
            get { return BackingStore?.Get<string?>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#nullable restore
#else
        public string Manufacturer
        {
            get { return BackingStore?.Get<string>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#endif
        /// <summary>The model property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Model
        {
            get { return BackingStore?.Get<string?>("model"); }
            set { BackingStore?.Set("model", value); }
        }
#nullable restore
#else
        public string Model
        {
            get { return BackingStore?.Get<string>("model"); }
            set { BackingStore?.Set("model", value); }
        }
#endif
        /// <summary>The nics property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.NicEvidence? Nics
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.NicEvidence?>("nics"); }
            set { BackingStore?.Set("nics", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.NicEvidence Nics
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.NicEvidence>("nics"); }
            set { BackingStore?.Set("nics", value); }
        }
#endif
        /// <summary>The operatingSystem property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OperatingSystem
        {
            get { return BackingStore?.Get<string?>("operatingSystem"); }
            set { BackingStore?.Set("operatingSystem", value); }
        }
#nullable restore
#else
        public string OperatingSystem
        {
            get { return BackingStore?.Get<string>("operatingSystem"); }
            set { BackingStore?.Set("operatingSystem", value); }
        }
#endif
        /// <summary>The owners property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Owners
        {
            get { return BackingStore?.Get<List<string>?>("owners"); }
            set { BackingStore?.Set("owners", value); }
        }
#nullable restore
#else
        public List<string> Owners
        {
            get { return BackingStore?.Get<List<string>>("owners"); }
            set { BackingStore?.Set("owners", value); }
        }
#endif
        /// <summary>The protocols property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Protocols
        {
            get { return BackingStore?.Get<List<string>?>("protocols"); }
            set { BackingStore?.Set("protocols", value); }
        }
#nullable restore
#else
        public List<string> Protocols
        {
            get { return BackingStore?.Get<List<string>>("protocols"); }
            set { BackingStore?.Set("protocols", value); }
        }
#endif
        /// <summary>The purdueLayer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PurdueLayer
        {
            get { return BackingStore?.Get<string?>("purdueLayer"); }
            set { BackingStore?.Set("purdueLayer", value); }
        }
#nullable restore
#else
        public string PurdueLayer
        {
            get { return BackingStore?.Get<string>("purdueLayer"); }
            set { BackingStore?.Set("purdueLayer", value); }
        }
#endif
        /// <summary>The sensor property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sensor
        {
            get { return BackingStore?.Get<string?>("sensor"); }
            set { BackingStore?.Set("sensor", value); }
        }
#nullable restore
#else
        public string Sensor
        {
            get { return BackingStore?.Get<string>("sensor"); }
            set { BackingStore?.Set("sensor", value); }
        }
#endif
        /// <summary>The serialNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SerialNumber
        {
            get { return BackingStore?.Get<string?>("serialNumber"); }
            set { BackingStore?.Set("serialNumber", value); }
        }
#nullable restore
#else
        public string SerialNumber
        {
            get { return BackingStore?.Get<string>("serialNumber"); }
            set { BackingStore?.Set("serialNumber", value); }
        }
#endif
        /// <summary>The site property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Site
        {
            get { return BackingStore?.Get<string?>("site"); }
            set { BackingStore?.Set("site", value); }
        }
#nullable restore
#else
        public string Site
        {
            get { return BackingStore?.Get<string>("site"); }
            set { BackingStore?.Set("site", value); }
        }
#endif
        /// <summary>The source property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Source
        {
            get { return BackingStore?.Get<string?>("source"); }
            set { BackingStore?.Set("source", value); }
        }
#nullable restore
#else
        public string Source
        {
            get { return BackingStore?.Get<string>("source"); }
            set { BackingStore?.Set("source", value); }
        }
#endif
        /// <summary>The sourceRef property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.UrlEvidence? SourceRef
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.UrlEvidence?>("sourceRef"); }
            set { BackingStore?.Set("sourceRef", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.UrlEvidence SourceRef
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.UrlEvidence>("sourceRef"); }
            set { BackingStore?.Set("sourceRef", value); }
        }
#endif
        /// <summary>The zone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Zone
        {
            get { return BackingStore?.Get<string?>("zone"); }
            set { BackingStore?.Set("zone", value); }
        }
#nullable restore
#else
        public string Zone
        {
            get { return BackingStore?.Get<string>("zone"); }
            set { BackingStore?.Set("zone", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.Security.IoTDeviceEvidence"/> and sets the default values.
        /// </summary>
        public IoTDeviceEvidence() : base()
        {
            OdataType = "#microsoft.graph.security.ioTDeviceEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Security.IoTDeviceEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Security.IoTDeviceEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Security.IoTDeviceEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "deviceId", n => { DeviceId = n.GetStringValue(); } },
                { "deviceName", n => { DeviceName = n.GetStringValue(); } },
                { "devicePageLink", n => { DevicePageLink = n.GetStringValue(); } },
                { "deviceSubType", n => { DeviceSubType = n.GetStringValue(); } },
                { "deviceType", n => { DeviceType = n.GetStringValue(); } },
                { "importance", n => { Importance = n.GetEnumValue<global::Microsoft.Graph.Models.Security.IoTDeviceImportanceType>(); } },
                { "ioTHub", n => { IoTHub = n.GetObjectValue<global::Microsoft.Graph.Models.Security.AzureResourceEvidence>(global::Microsoft.Graph.Models.Security.AzureResourceEvidence.CreateFromDiscriminatorValue); } },
                { "ioTSecurityAgentId", n => { IoTSecurityAgentId = n.GetStringValue(); } },
                { "ipAddress", n => { IpAddress = n.GetObjectValue<global::Microsoft.Graph.Models.Security.IpEvidence>(global::Microsoft.Graph.Models.Security.IpEvidence.CreateFromDiscriminatorValue); } },
                { "isAuthorized", n => { IsAuthorized = n.GetBoolValue(); } },
                { "isProgramming", n => { IsProgramming = n.GetBoolValue(); } },
                { "isScanner", n => { IsScanner = n.GetBoolValue(); } },
                { "macAddress", n => { MacAddress = n.GetStringValue(); } },
                { "manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                { "model", n => { Model = n.GetStringValue(); } },
                { "nics", n => { Nics = n.GetObjectValue<global::Microsoft.Graph.Models.Security.NicEvidence>(global::Microsoft.Graph.Models.Security.NicEvidence.CreateFromDiscriminatorValue); } },
                { "operatingSystem", n => { OperatingSystem = n.GetStringValue(); } },
                { "owners", n => { Owners = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "protocols", n => { Protocols = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "purdueLayer", n => { PurdueLayer = n.GetStringValue(); } },
                { "sensor", n => { Sensor = n.GetStringValue(); } },
                { "serialNumber", n => { SerialNumber = n.GetStringValue(); } },
                { "site", n => { Site = n.GetStringValue(); } },
                { "source", n => { Source = n.GetStringValue(); } },
                { "sourceRef", n => { SourceRef = n.GetObjectValue<global::Microsoft.Graph.Models.Security.UrlEvidence>(global::Microsoft.Graph.Models.Security.UrlEvidence.CreateFromDiscriminatorValue); } },
                { "zone", n => { Zone = n.GetStringValue(); } },
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
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("devicePageLink", DevicePageLink);
            writer.WriteStringValue("deviceSubType", DeviceSubType);
            writer.WriteStringValue("deviceType", DeviceType);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Security.IoTDeviceImportanceType>("importance", Importance);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.AzureResourceEvidence>("ioTHub", IoTHub);
            writer.WriteStringValue("ioTSecurityAgentId", IoTSecurityAgentId);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.IpEvidence>("ipAddress", IpAddress);
            writer.WriteBoolValue("isAuthorized", IsAuthorized);
            writer.WriteBoolValue("isProgramming", IsProgramming);
            writer.WriteBoolValue("isScanner", IsScanner);
            writer.WriteStringValue("macAddress", MacAddress);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.NicEvidence>("nics", Nics);
            writer.WriteStringValue("operatingSystem", OperatingSystem);
            writer.WriteCollectionOfPrimitiveValues<string>("owners", Owners);
            writer.WriteCollectionOfPrimitiveValues<string>("protocols", Protocols);
            writer.WriteStringValue("purdueLayer", PurdueLayer);
            writer.WriteStringValue("sensor", Sensor);
            writer.WriteStringValue("serialNumber", SerialNumber);
            writer.WriteStringValue("site", Site);
            writer.WriteStringValue("source", Source);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.UrlEvidence>("sourceRef", SourceRef);
            writer.WriteStringValue("zone", Zone);
        }
    }
}
