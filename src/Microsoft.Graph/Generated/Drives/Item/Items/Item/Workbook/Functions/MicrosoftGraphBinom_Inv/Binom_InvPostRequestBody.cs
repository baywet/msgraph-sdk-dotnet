using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.MicrosoftGraphBinom_Inv {
    public class Binom_InvPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The alpha property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Alpha {
            get { return BackingStore?.Get<Json?>("alpha"); }
            set { BackingStore?.Set("alpha", value); }
        }
#nullable restore
#else
        public Json Alpha {
            get { return BackingStore?.Get<Json>("alpha"); }
            set { BackingStore?.Set("alpha", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The probabilityS property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? ProbabilityS {
            get { return BackingStore?.Get<Json?>("probabilityS"); }
            set { BackingStore?.Set("probabilityS", value); }
        }
#nullable restore
#else
        public Json ProbabilityS {
            get { return BackingStore?.Get<Json>("probabilityS"); }
            set { BackingStore?.Set("probabilityS", value); }
        }
#endif
        /// <summary>The trials property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Trials {
            get { return BackingStore?.Get<Json?>("trials"); }
            set { BackingStore?.Set("trials", value); }
        }
#nullable restore
#else
        public Json Trials {
            get { return BackingStore?.Get<Json>("trials"); }
            set { BackingStore?.Set("trials", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new binom_InvPostRequestBody and sets the default values.
        /// </summary>
        public Binom_InvPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Binom_InvPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Binom_InvPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"alpha", n => { Alpha = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"probabilityS", n => { ProbabilityS = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"trials", n => { Trials = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("alpha", Alpha);
            writer.WriteObjectValue<Json>("probabilityS", ProbabilityS);
            writer.WriteObjectValue<Json>("trials", Trials);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}