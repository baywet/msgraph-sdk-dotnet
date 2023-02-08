using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.MicrosoftGraphDollarDe {
    public class DollarDePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The fraction property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Fraction {
            get { return BackingStore?.Get<Json?>("fraction"); }
            set { BackingStore?.Set("fraction", value); }
        }
#nullable restore
#else
        public Json Fraction {
            get { return BackingStore?.Get<Json>("fraction"); }
            set { BackingStore?.Set("fraction", value); }
        }
#endif
        /// <summary>The fractionalDollar property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? FractionalDollar {
            get { return BackingStore?.Get<Json?>("fractionalDollar"); }
            set { BackingStore?.Set("fractionalDollar", value); }
        }
#nullable restore
#else
        public Json FractionalDollar {
            get { return BackingStore?.Get<Json>("fractionalDollar"); }
            set { BackingStore?.Set("fractionalDollar", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new dollarDePostRequestBody and sets the default values.
        /// </summary>
        public DollarDePostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DollarDePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DollarDePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"fraction", n => { Fraction = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"fractionalDollar", n => { FractionalDollar = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("fraction", Fraction);
            writer.WriteObjectValue<Json>("fractionalDollar", FractionalDollar);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}