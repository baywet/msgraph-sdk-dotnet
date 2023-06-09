using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Security {
    public class GoogleCloudResourceEvidence : AlertEvidence, IParsable {
        /// <summary>The zone or region where the resource is located.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Location {
            get { return BackingStore?.Get<string?>("location"); }
            set { BackingStore?.Set("location", value); }
        }
#nullable restore
#else
        public string Location {
            get { return BackingStore?.Get<string>("location"); }
            set { BackingStore?.Set("location", value); }
        }
#endif
        /// <summary>The type of location. Possible values are: unknown, regional, zonal, global, unknownFutureValue.</summary>
        public GoogleCloudLocationType? LocationType {
            get { return BackingStore?.Get<GoogleCloudLocationType?>("locationType"); }
            set { BackingStore?.Set("locationType", value); }
        }
        /// <summary>The Google project ID as defined by the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProjectId {
            get { return BackingStore?.Get<string?>("projectId"); }
            set { BackingStore?.Set("projectId", value); }
        }
#nullable restore
#else
        public string ProjectId {
            get { return BackingStore?.Get<string>("projectId"); }
            set { BackingStore?.Set("projectId", value); }
        }
#endif
        /// <summary>The project number assigned by Google.</summary>
        public long? ProjectNumber {
            get { return BackingStore?.Get<long?>("projectNumber"); }
            set { BackingStore?.Set("projectNumber", value); }
        }
        /// <summary>The name of the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceName {
            get { return BackingStore?.Get<string?>("resourceName"); }
            set { BackingStore?.Set("resourceName", value); }
        }
#nullable restore
#else
        public string ResourceName {
            get { return BackingStore?.Get<string>("resourceName"); }
            set { BackingStore?.Set("resourceName", value); }
        }
#endif
        /// <summary>The type of the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceType {
            get { return BackingStore?.Get<string?>("resourceType"); }
            set { BackingStore?.Set("resourceType", value); }
        }
#nullable restore
#else
        public string ResourceType {
            get { return BackingStore?.Get<string>("resourceType"); }
            set { BackingStore?.Set("resourceType", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GoogleCloudResourceEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GoogleCloudResourceEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"location", n => { Location = n.GetStringValue(); } },
                {"locationType", n => { LocationType = n.GetEnumValue<GoogleCloudLocationType>(); } },
                {"projectId", n => { ProjectId = n.GetStringValue(); } },
                {"projectNumber", n => { ProjectNumber = n.GetLongValue(); } },
                {"resourceName", n => { ResourceName = n.GetStringValue(); } },
                {"resourceType", n => { ResourceType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("location", Location);
            writer.WriteEnumValue<GoogleCloudLocationType>("locationType", LocationType);
            writer.WriteStringValue("projectId", ProjectId);
            writer.WriteLongValue("projectNumber", ProjectNumber);
            writer.WriteStringValue("resourceName", ResourceName);
            writer.WriteStringValue("resourceType", ResourceType);
        }
    }
}