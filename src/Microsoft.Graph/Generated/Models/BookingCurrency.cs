using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class BookingCurrency : Entity, IParsable {
        /// <summary>The currency symbol. For example, the currency symbol for the US dollar and for the Australian dollar is $.</summary>
        public string Symbol {
            get { return BackingStore?.Get<string>("symbol"); }
            set { BackingStore?.Set("symbol", value); }
        }
        /// <summary>
        /// Instantiates a new BookingCurrency and sets the default values.
        /// </summary>
        public BookingCurrency() : base() {
            OdataType = "#microsoft.graph.bookingCurrency";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new BookingCurrency CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BookingCurrency();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"symbol", n => { Symbol = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("symbol", Symbol);
        }
    }
}
