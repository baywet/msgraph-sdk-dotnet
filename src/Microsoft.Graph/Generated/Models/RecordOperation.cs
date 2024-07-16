// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class RecordOperation : global::Microsoft.Graph.Models.CommsOperation, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The access token required to retrieve the recording.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordingAccessToken
        {
            get { return BackingStore?.Get<string?>("recordingAccessToken"); }
            set { BackingStore?.Set("recordingAccessToken", value); }
        }
#nullable restore
#else
        public string RecordingAccessToken
        {
            get { return BackingStore?.Get<string>("recordingAccessToken"); }
            set { BackingStore?.Set("recordingAccessToken", value); }
        }
#endif
        /// <summary>The location where the recording is located.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordingLocation
        {
            get { return BackingStore?.Get<string?>("recordingLocation"); }
            set { BackingStore?.Set("recordingLocation", value); }
        }
#nullable restore
#else
        public string RecordingLocation
        {
            get { return BackingStore?.Get<string>("recordingLocation"); }
            set { BackingStore?.Set("recordingLocation", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.RecordOperation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.RecordOperation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.RecordOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "recordingAccessToken", n => { RecordingAccessToken = n.GetStringValue(); } },
                { "recordingLocation", n => { RecordingLocation = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("recordingAccessToken", RecordingAccessToken);
            writer.WriteStringValue("recordingLocation", RecordingLocation);
        }
    }
}
