// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>
    /// Network Proxy Server Policy.
    /// </summary>
    public class Windows10NetworkProxyServer : IAdditionalDataHolder, IBackedModel, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Address to the proxy server. Specify an address in the format [&apos;:&apos;]</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Address
        {
            get { return BackingStore?.Get<string?>("address"); }
            set { BackingStore?.Set("address", value); }
        }
#nullable restore
#else
        public string Address
        {
            get { return BackingStore?.Get<string>("address"); }
            set { BackingStore?.Set("address", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Addresses that should not use the proxy server. The system will not use the proxy server for addresses beginning with what is specified in this node.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Exceptions
        {
            get { return BackingStore?.Get<List<string>?>("exceptions"); }
            set { BackingStore?.Set("exceptions", value); }
        }
#nullable restore
#else
        public List<string> Exceptions
        {
            get { return BackingStore?.Get<List<string>>("exceptions"); }
            set { BackingStore?.Set("exceptions", value); }
        }
#endif
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
        /// <summary>Specifies whether the proxy server should be used for local (intranet) addresses.</summary>
        public bool? UseForLocalAddresses
        {
            get { return BackingStore?.Get<bool?>("useForLocalAddresses"); }
            set { BackingStore?.Set("useForLocalAddresses", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Models.Windows10NetworkProxyServer"/> and sets the default values.
        /// </summary>
        public Windows10NetworkProxyServer()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.Windows10NetworkProxyServer"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Models.Windows10NetworkProxyServer CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.Windows10NetworkProxyServer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "address", n => { Address = n.GetStringValue(); } },
                { "exceptions", n => { Exceptions = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "useForLocalAddresses", n => { UseForLocalAddresses = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("address", Address);
            writer.WriteCollectionOfPrimitiveValues<string>("exceptions", Exceptions);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("useForLocalAddresses", UseForLocalAddresses);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
