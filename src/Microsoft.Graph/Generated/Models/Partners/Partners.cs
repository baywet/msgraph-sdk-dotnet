// <auto-generated/>
using Microsoft.Graph.Models.Partners.Billing;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Partners {
    public class Partners : Microsoft.Graph.Models.Entity, IParsable {
        /// <summary>Represents billing details for billed and unbilled data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Partners.Billing.Billing? Billing {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Partners.Billing.Billing?>("billing"); }
            set { BackingStore?.Set("billing", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Partners.Billing.Billing Billing {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Partners.Billing.Billing>("billing"); }
            set { BackingStore?.Set("billing", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Partners"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Partners CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Partners();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"billing", n => { Billing = n.GetObjectValue<Microsoft.Graph.Models.Partners.Billing.Billing>(Microsoft.Graph.Models.Partners.Billing.Billing.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Models.Partners.Billing.Billing>("billing", Billing);
        }
    }
}