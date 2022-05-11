using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class NumberColumn : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>How many decimal places to display. See below for information about the possible values.</summary>
        public string DecimalPlaces { get; set; }
        /// <summary>How the value should be presented in the UX. Must be one of number or percentage. If unspecified, treated as number.</summary>
        public string DisplayAs { get; set; }
        /// <summary>The maximum permitted value.</summary>
        public double? Maximum { get; set; }
        /// <summary>The minimum permitted value.</summary>
        public double? Minimum { get; set; }
        /// <summary>
        /// Instantiates a new numberColumn and sets the default values.
        /// </summary>
        public NumberColumn() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static NumberColumn CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NumberColumn();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"decimalPlaces", n => { DecimalPlaces = n.GetStringValue(); } },
                {"displayAs", n => { DisplayAs = n.GetStringValue(); } },
                {"maximum", n => { Maximum = n.GetDoubleValue(); } },
                {"minimum", n => { Minimum = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("decimalPlaces", DecimalPlaces);
            writer.WriteStringValue("displayAs", DisplayAs);
            writer.WriteDoubleValue("maximum", Maximum);
            writer.WriteDoubleValue("minimum", Minimum);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}