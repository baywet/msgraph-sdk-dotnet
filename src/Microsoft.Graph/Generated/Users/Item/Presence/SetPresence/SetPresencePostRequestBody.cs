using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Users.Item.Presence.SetPresence {
    /// <summary>Provides operations to call the setPresence method.</summary>
    public class SetPresencePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The activity property</summary>
        public string Activity {
            get { return BackingStore?.Get<string>(nameof(Activity)); }
            set { BackingStore?.Set(nameof(Activity), value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>The availability property</summary>
        public string Availability {
            get { return BackingStore?.Get<string>(nameof(Availability)); }
            set { BackingStore?.Set(nameof(Availability), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The expirationDuration property</summary>
        public TimeSpan? ExpirationDuration {
            get { return BackingStore?.Get<TimeSpan?>(nameof(ExpirationDuration)); }
            set { BackingStore?.Set(nameof(ExpirationDuration), value); }
        }
        /// <summary>The sessionId property</summary>
        public string SessionId {
            get { return BackingStore?.Get<string>(nameof(SessionId)); }
            set { BackingStore?.Set(nameof(SessionId), value); }
        }
        /// <summary>
        /// Instantiates a new setPresencePostRequestBody and sets the default values.
        /// </summary>
        public SetPresencePostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SetPresencePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SetPresencePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"activity", n => { Activity = n.GetStringValue(); } },
                {"availability", n => { Availability = n.GetStringValue(); } },
                {"expirationDuration", n => { ExpirationDuration = n.GetTimeSpanValue(); } },
                {"sessionId", n => { SessionId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("activity", Activity);
            writer.WriteStringValue("availability", Availability);
            writer.WriteTimeSpanValue("expirationDuration", ExpirationDuration);
            writer.WriteStringValue("sessionId", SessionId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}