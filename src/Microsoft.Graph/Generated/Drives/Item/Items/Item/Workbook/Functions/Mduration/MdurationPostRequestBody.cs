// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Mduration
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class MdurationPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The basis property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Basis
        {
            get { return BackingStore?.Get<UntypedNode?>("basis"); }
            set { BackingStore?.Set("basis", value); }
        }
#nullable restore
#else
        public UntypedNode Basis
        {
            get { return BackingStore?.Get<UntypedNode>("basis"); }
            set { BackingStore?.Set("basis", value); }
        }
#endif
        /// <summary>The coupon property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Coupon
        {
            get { return BackingStore?.Get<UntypedNode?>("coupon"); }
            set { BackingStore?.Set("coupon", value); }
        }
#nullable restore
#else
        public UntypedNode Coupon
        {
            get { return BackingStore?.Get<UntypedNode>("coupon"); }
            set { BackingStore?.Set("coupon", value); }
        }
#endif
        /// <summary>The frequency property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Frequency
        {
            get { return BackingStore?.Get<UntypedNode?>("frequency"); }
            set { BackingStore?.Set("frequency", value); }
        }
#nullable restore
#else
        public UntypedNode Frequency
        {
            get { return BackingStore?.Get<UntypedNode>("frequency"); }
            set { BackingStore?.Set("frequency", value); }
        }
#endif
        /// <summary>The maturity property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Maturity
        {
            get { return BackingStore?.Get<UntypedNode?>("maturity"); }
            set { BackingStore?.Set("maturity", value); }
        }
#nullable restore
#else
        public UntypedNode Maturity
        {
            get { return BackingStore?.Get<UntypedNode>("maturity"); }
            set { BackingStore?.Set("maturity", value); }
        }
#endif
        /// <summary>The settlement property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Settlement
        {
            get { return BackingStore?.Get<UntypedNode?>("settlement"); }
            set { BackingStore?.Set("settlement", value); }
        }
#nullable restore
#else
        public UntypedNode Settlement
        {
            get { return BackingStore?.Get<UntypedNode>("settlement"); }
            set { BackingStore?.Set("settlement", value); }
        }
#endif
        /// <summary>The yld property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Yld
        {
            get { return BackingStore?.Get<UntypedNode?>("yld"); }
            set { BackingStore?.Set("yld", value); }
        }
#nullable restore
#else
        public UntypedNode Yld
        {
            get { return BackingStore?.Get<UntypedNode>("yld"); }
            set { BackingStore?.Set("yld", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Mduration.MdurationPostRequestBody"/> and sets the default values.
        /// </summary>
        public MdurationPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Mduration.MdurationPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Mduration.MdurationPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.Mduration.MdurationPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "basis", n => { Basis = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "coupon", n => { Coupon = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "frequency", n => { Frequency = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "maturity", n => { Maturity = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "settlement", n => { Settlement = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "yld", n => { Yld = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UntypedNode>("basis", Basis);
            writer.WriteObjectValue<UntypedNode>("coupon", Coupon);
            writer.WriteObjectValue<UntypedNode>("frequency", Frequency);
            writer.WriteObjectValue<UntypedNode>("maturity", Maturity);
            writer.WriteObjectValue<UntypedNode>("settlement", Settlement);
            writer.WriteObjectValue<UntypedNode>("yld", Yld);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
