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
    public partial class DomainDnsRecord : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>If false, the customer must configure this record at the DNS host for Microsoft Online Services to operate correctly with the domain.</summary>
        public bool? IsOptional
        {
            get { return BackingStore?.Get<bool?>("isOptional"); }
            set { BackingStore?.Set("isOptional", value); }
        }
        /// <summary>Value used when configuring the name of the DNS record at the DNS host.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Label
        {
            get { return BackingStore?.Get<string?>("label"); }
            set { BackingStore?.Set("label", value); }
        }
#nullable restore
#else
        public string Label
        {
            get { return BackingStore?.Get<string>("label"); }
            set { BackingStore?.Set("label", value); }
        }
#endif
        /// <summary>Indicates what type of DNS record this entity represents. The value can be CName, Mx, Srv, or Txt.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordType
        {
            get { return BackingStore?.Get<string?>("recordType"); }
            set { BackingStore?.Set("recordType", value); }
        }
#nullable restore
#else
        public string RecordType
        {
            get { return BackingStore?.Get<string>("recordType"); }
            set { BackingStore?.Set("recordType", value); }
        }
#endif
        /// <summary>Microsoft Online Service or feature that has a dependency on this DNS record. Can be one of the following values: null, Email, Sharepoint, EmailInternalRelayOnly, OfficeCommunicationsOnline, SharePointDefaultDomain, FullRedelegation, SharePointPublic, OrgIdAuthentication, Yammer, Intune.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SupportedService
        {
            get { return BackingStore?.Get<string?>("supportedService"); }
            set { BackingStore?.Set("supportedService", value); }
        }
#nullable restore
#else
        public string SupportedService
        {
            get { return BackingStore?.Get<string>("supportedService"); }
            set { BackingStore?.Set("supportedService", value); }
        }
#endif
        /// <summary>Value to use when configuring the time-to-live (ttl) property of the DNS record at the DNS host. Not nullable.</summary>
        public int? Ttl
        {
            get { return BackingStore?.Get<int?>("ttl"); }
            set { BackingStore?.Set("ttl", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.DomainDnsRecord"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.DomainDnsRecord CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.domainDnsCnameRecord" => new global::Microsoft.Graph.Models.DomainDnsCnameRecord(),
                "#microsoft.graph.domainDnsMxRecord" => new global::Microsoft.Graph.Models.DomainDnsMxRecord(),
                "#microsoft.graph.domainDnsSrvRecord" => new global::Microsoft.Graph.Models.DomainDnsSrvRecord(),
                "#microsoft.graph.domainDnsTxtRecord" => new global::Microsoft.Graph.Models.DomainDnsTxtRecord(),
                "#microsoft.graph.domainDnsUnavailableRecord" => new global::Microsoft.Graph.Models.DomainDnsUnavailableRecord(),
                _ => new global::Microsoft.Graph.Models.DomainDnsRecord(),
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
                { "isOptional", n => { IsOptional = n.GetBoolValue(); } },
                { "label", n => { Label = n.GetStringValue(); } },
                { "recordType", n => { RecordType = n.GetStringValue(); } },
                { "supportedService", n => { SupportedService = n.GetStringValue(); } },
                { "ttl", n => { Ttl = n.GetIntValue(); } },
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
            writer.WriteBoolValue("isOptional", IsOptional);
            writer.WriteStringValue("label", Label);
            writer.WriteStringValue("recordType", RecordType);
            writer.WriteStringValue("supportedService", SupportedService);
            writer.WriteIntValue("ttl", Ttl);
        }
    }
}
