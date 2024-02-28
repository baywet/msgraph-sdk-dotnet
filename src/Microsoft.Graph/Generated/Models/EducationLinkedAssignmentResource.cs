// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class EducationLinkedAssignmentResource : EducationResource, IParsable {
        /// <summary>URL of the actual assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url {
            get { return BackingStore?.Get<string?>("url"); }
            set { BackingStore?.Set("url", value); }
        }
#nullable restore
#else
        public string Url {
            get { return BackingStore?.Get<string>("url"); }
            set { BackingStore?.Set("url", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="EducationLinkedAssignmentResource"/> and sets the default values.
        /// </summary>
        public EducationLinkedAssignmentResource() : base() {
            OdataType = "#microsoft.graph.educationLinkedAssignmentResource";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EducationLinkedAssignmentResource"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EducationLinkedAssignmentResource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationLinkedAssignmentResource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("url", Url);
        }
    }
}