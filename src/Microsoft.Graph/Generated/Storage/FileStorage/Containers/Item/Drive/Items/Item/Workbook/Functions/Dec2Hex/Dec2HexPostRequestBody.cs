// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Functions.Dec2Hex
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class Dec2HexPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The number property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Number
        {
            get { return BackingStore?.Get<UntypedNode?>("number"); }
            set { BackingStore?.Set("number", value); }
        }
#nullable restore
#else
        public UntypedNode Number
        {
            get { return BackingStore?.Get<UntypedNode>("number"); }
            set { BackingStore?.Set("number", value); }
        }
#endif
        /// <summary>The places property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Places
        {
            get { return BackingStore?.Get<UntypedNode?>("places"); }
            set { BackingStore?.Set("places", value); }
        }
#nullable restore
#else
        public UntypedNode Places
        {
            get { return BackingStore?.Get<UntypedNode>("places"); }
            set { BackingStore?.Set("places", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Functions.Dec2Hex.Dec2HexPostRequestBody"/> and sets the default values.
        /// </summary>
        public Dec2HexPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Functions.Dec2Hex.Dec2HexPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Functions.Dec2Hex.Dec2HexPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Functions.Dec2Hex.Dec2HexPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "number", n => { Number = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "places", n => { Places = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UntypedNode>("number", Number);
            writer.WriteObjectValue<UntypedNode>("places", Places);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
