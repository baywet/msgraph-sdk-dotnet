using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class Trending : Entity, IParsable {
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Used for navigating to the trending document.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Entity? Resource {
            get { return BackingStore?.Get<Entity?>("resource"); }
            set { BackingStore?.Set("resource", value); }
        }
#nullable restore
#else
        public Entity Resource {
            get { return BackingStore?.Get<Entity>("resource"); }
            set { BackingStore?.Set("resource", value); }
        }
#endif
        /// <summary>Reference properties of the trending document, such as the url and type of the document.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ResourceReference? ResourceReference {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ResourceReference?>("resourceReference"); }
            set { BackingStore?.Set("resourceReference", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ResourceReference ResourceReference {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ResourceReference>("resourceReference"); }
            set { BackingStore?.Set("resourceReference", value); }
        }
#endif
        /// <summary>Properties that you can use to visualize the document in your experience.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ResourceVisualization? ResourceVisualization {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ResourceVisualization?>("resourceVisualization"); }
            set { BackingStore?.Set("resourceVisualization", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ResourceVisualization ResourceVisualization {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ResourceVisualization>("resourceVisualization"); }
            set { BackingStore?.Set("resourceVisualization", value); }
        }
#endif
        /// <summary>Value indicating how much the document is currently trending. The larger the number, the more the document is currently trending around the user (the more relevant it is). Returned documents are sorted by this value.</summary>
        public double? Weight {
            get { return BackingStore?.Get<double?>("weight"); }
            set { BackingStore?.Set("weight", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Trending CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Trending();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"resource", n => { Resource = n.GetObjectValue<Entity>(Entity.CreateFromDiscriminatorValue); } },
                {"resourceReference", n => { ResourceReference = n.GetObjectValue<Microsoft.Graph.Models.ResourceReference>(Microsoft.Graph.Models.ResourceReference.CreateFromDiscriminatorValue); } },
                {"resourceVisualization", n => { ResourceVisualization = n.GetObjectValue<Microsoft.Graph.Models.ResourceVisualization>(Microsoft.Graph.Models.ResourceVisualization.CreateFromDiscriminatorValue); } },
                {"weight", n => { Weight = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<Entity>("resource", Resource);
            writer.WriteDoubleValue("weight", Weight);
        }
    }
}