// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Security {
    public class WhoisRecord : WhoisBaseRecord, IParsable {
        /// <summary>The collection of historical records associated to this WHOIS object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WhoisHistoryRecord>? History {
            get { return BackingStore?.Get<List<WhoisHistoryRecord>?>("history"); }
            set { BackingStore?.Set("history", value); }
        }
#nullable restore
#else
        public List<WhoisHistoryRecord> History {
            get { return BackingStore?.Get<List<WhoisHistoryRecord>>("history"); }
            set { BackingStore?.Set("history", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new whoisRecord and sets the default values.
        /// </summary>
        public WhoisRecord() : base() {
            OdataType = "#microsoft.graph.security.whoisRecord";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WhoisRecord CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WhoisRecord();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"history", n => { History = n.GetCollectionOfObjectValues<WhoisHistoryRecord>(WhoisHistoryRecord.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<WhoisHistoryRecord>("history", History);
        }
    }
}
