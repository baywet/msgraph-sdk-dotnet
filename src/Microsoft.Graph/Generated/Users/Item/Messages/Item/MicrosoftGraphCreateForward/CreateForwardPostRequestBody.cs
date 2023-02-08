using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Users.Item.Messages.Item.MicrosoftGraphCreateForward {
    public class CreateForwardPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The Comment property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comment {
            get { return BackingStore?.Get<string?>("Comment"); }
            set { BackingStore?.Set("Comment", value); }
        }
#nullable restore
#else
        public string Comment {
            get { return BackingStore?.Get<string>("Comment"); }
            set { BackingStore?.Set("Comment", value); }
        }
#endif
        /// <summary>The Message property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Message? Message {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Message?>("Message"); }
            set { BackingStore?.Set("Message", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Message Message {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Message>("Message"); }
            set { BackingStore?.Set("Message", value); }
        }
#endif
        /// <summary>The ToRecipients property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Recipient>? ToRecipients {
            get { return BackingStore?.Get<List<Recipient>?>("ToRecipients"); }
            set { BackingStore?.Set("ToRecipients", value); }
        }
#nullable restore
#else
        public List<Recipient> ToRecipients {
            get { return BackingStore?.Get<List<Recipient>>("ToRecipients"); }
            set { BackingStore?.Set("ToRecipients", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new createForwardPostRequestBody and sets the default values.
        /// </summary>
        public CreateForwardPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CreateForwardPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateForwardPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Comment", n => { Comment = n.GetStringValue(); } },
                {"Message", n => { Message = n.GetObjectValue<Microsoft.Graph.Models.Message>(Microsoft.Graph.Models.Message.CreateFromDiscriminatorValue); } },
                {"ToRecipients", n => { ToRecipients = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Comment", Comment);
            writer.WriteObjectValue<Microsoft.Graph.Models.Message>("Message", Message);
            writer.WriteCollectionOfObjectValues<Recipient>("ToRecipients", ToRecipients);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}