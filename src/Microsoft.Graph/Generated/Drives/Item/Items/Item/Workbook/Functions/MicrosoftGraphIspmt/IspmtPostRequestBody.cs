using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.MicrosoftGraphIspmt {
    public class IspmtPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The nper property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Nper {
            get { return BackingStore?.Get<Json?>("nper"); }
            set { BackingStore?.Set("nper", value); }
        }
#nullable restore
#else
        public Json Nper {
            get { return BackingStore?.Get<Json>("nper"); }
            set { BackingStore?.Set("nper", value); }
        }
#endif
        /// <summary>The per property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Per {
            get { return BackingStore?.Get<Json?>("per"); }
            set { BackingStore?.Set("per", value); }
        }
#nullable restore
#else
        public Json Per {
            get { return BackingStore?.Get<Json>("per"); }
            set { BackingStore?.Set("per", value); }
        }
#endif
        /// <summary>The pv property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Pv {
            get { return BackingStore?.Get<Json?>("pv"); }
            set { BackingStore?.Set("pv", value); }
        }
#nullable restore
#else
        public Json Pv {
            get { return BackingStore?.Get<Json>("pv"); }
            set { BackingStore?.Set("pv", value); }
        }
#endif
        /// <summary>The rate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Rate {
            get { return BackingStore?.Get<Json?>("rate"); }
            set { BackingStore?.Set("rate", value); }
        }
#nullable restore
#else
        public Json Rate {
            get { return BackingStore?.Get<Json>("rate"); }
            set { BackingStore?.Set("rate", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new ispmtPostRequestBody and sets the default values.
        /// </summary>
        public IspmtPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IspmtPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IspmtPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"nper", n => { Nper = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"per", n => { Per = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"pv", n => { Pv = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"rate", n => { Rate = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("nper", Nper);
            writer.WriteObjectValue<Json>("per", Per);
            writer.WriteObjectValue<Json>("pv", Pv);
            writer.WriteObjectValue<Json>("rate", Rate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}