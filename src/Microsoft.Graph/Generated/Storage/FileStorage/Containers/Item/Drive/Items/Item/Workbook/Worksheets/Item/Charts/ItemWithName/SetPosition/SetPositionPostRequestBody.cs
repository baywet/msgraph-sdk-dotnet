// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Charts.ItemWithName.SetPosition
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class SetPositionPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The endCell property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? EndCell
        {
            get { return BackingStore?.Get<UntypedNode?>("endCell"); }
            set { BackingStore?.Set("endCell", value); }
        }
#nullable restore
#else
        public UntypedNode EndCell
        {
            get { return BackingStore?.Get<UntypedNode>("endCell"); }
            set { BackingStore?.Set("endCell", value); }
        }
#endif
        /// <summary>The startCell property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? StartCell
        {
            get { return BackingStore?.Get<UntypedNode?>("startCell"); }
            set { BackingStore?.Set("startCell", value); }
        }
#nullable restore
#else
        public UntypedNode StartCell
        {
            get { return BackingStore?.Get<UntypedNode>("startCell"); }
            set { BackingStore?.Set("startCell", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Charts.ItemWithName.SetPosition.SetPositionPostRequestBody"/> and sets the default values.
        /// </summary>
        public SetPositionPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Charts.ItemWithName.SetPosition.SetPositionPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Charts.ItemWithName.SetPosition.SetPositionPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Charts.ItemWithName.SetPosition.SetPositionPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "endCell", n => { EndCell = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "startCell", n => { StartCell = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UntypedNode>("endCell", EndCell);
            writer.WriteObjectValue<UntypedNode>("startCell", StartCell);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
