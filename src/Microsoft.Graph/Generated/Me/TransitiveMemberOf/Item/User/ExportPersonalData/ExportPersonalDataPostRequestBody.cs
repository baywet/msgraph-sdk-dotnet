using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Me.TransitiveMemberOf.Item.User.ExportPersonalData {
    /// <summary>Provides operations to call the exportPersonalData method.</summary>
    public class ExportPersonalDataPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The storageLocation property</summary>
        public string StorageLocation {
            get { return BackingStore?.Get<string>(nameof(StorageLocation)); }
            set { BackingStore?.Set(nameof(StorageLocation), value); }
        }
        /// <summary>
        /// Instantiates a new exportPersonalDataPostRequestBody and sets the default values.
        /// </summary>
        public ExportPersonalDataPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ExportPersonalDataPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExportPersonalDataPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"storageLocation", n => { StorageLocation = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("storageLocation", StorageLocation);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}