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
    public partial class Participant : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The info property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ParticipantInfo? Info
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ParticipantInfo?>("info"); }
            set { BackingStore?.Set("info", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ParticipantInfo Info
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ParticipantInfo>("info"); }
            set { BackingStore?.Set("info", value); }
        }
#endif
        /// <summary>true if the participant is in lobby.</summary>
        public bool? IsInLobby
        {
            get { return BackingStore?.Get<bool?>("isInLobby"); }
            set { BackingStore?.Set("isInLobby", value); }
        }
        /// <summary>true if the participant is muted (client or server muted).</summary>
        public bool? IsMuted
        {
            get { return BackingStore?.Get<bool?>("isMuted"); }
            set { BackingStore?.Set("isMuted", value); }
        }
        /// <summary>The list of media streams.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.MediaStream>? MediaStreams
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.MediaStream>?>("mediaStreams"); }
            set { BackingStore?.Set("mediaStreams", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.MediaStream> MediaStreams
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.MediaStream>>("mediaStreams"); }
            set { BackingStore?.Set("mediaStreams", value); }
        }
#endif
        /// <summary>A blob of data provided by the participant in the roster.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Metadata
        {
            get { return BackingStore?.Get<string?>("metadata"); }
            set { BackingStore?.Set("metadata", value); }
        }
#nullable restore
#else
        public string Metadata
        {
            get { return BackingStore?.Get<string>("metadata"); }
            set { BackingStore?.Set("metadata", value); }
        }
#endif
        /// <summary>Information about whether the participant has recording capability.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.RecordingInfo? RecordingInfo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.RecordingInfo?>("recordingInfo"); }
            set { BackingStore?.Set("recordingInfo", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.RecordingInfo RecordingInfo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.RecordingInfo>("recordingInfo"); }
            set { BackingStore?.Set("recordingInfo", value); }
        }
#endif
        /// <summary>Indicates the reason why the participant was removed from the roster.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.RemovedState? RemovedState
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.RemovedState?>("removedState"); }
            set { BackingStore?.Set("removedState", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.RemovedState RemovedState
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.RemovedState>("removedState"); }
            set { BackingStore?.Set("removedState", value); }
        }
#endif
        /// <summary>Indicates the reason or reasons media content from this participant is restricted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.OnlineMeetingRestricted? RestrictedExperience
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.OnlineMeetingRestricted?>("restrictedExperience"); }
            set { BackingStore?.Set("restrictedExperience", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.OnlineMeetingRestricted RestrictedExperience
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.OnlineMeetingRestricted>("restrictedExperience"); }
            set { BackingStore?.Set("restrictedExperience", value); }
        }
#endif
        /// <summary>Indicates the roster sequence number in which the participant was last updated.</summary>
        public long? RosterSequenceNumber
        {
            get { return BackingStore?.Get<long?>("rosterSequenceNumber"); }
            set { BackingStore?.Set("rosterSequenceNumber", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Participant"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Participant CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Participant();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "info", n => { Info = n.GetObjectValue<global::Microsoft.Graph.Models.ParticipantInfo>(global::Microsoft.Graph.Models.ParticipantInfo.CreateFromDiscriminatorValue); } },
                { "isInLobby", n => { IsInLobby = n.GetBoolValue(); } },
                { "isMuted", n => { IsMuted = n.GetBoolValue(); } },
                { "mediaStreams", n => { MediaStreams = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.MediaStream>(global::Microsoft.Graph.Models.MediaStream.CreateFromDiscriminatorValue)?.AsList(); } },
                { "metadata", n => { Metadata = n.GetStringValue(); } },
                { "recordingInfo", n => { RecordingInfo = n.GetObjectValue<global::Microsoft.Graph.Models.RecordingInfo>(global::Microsoft.Graph.Models.RecordingInfo.CreateFromDiscriminatorValue); } },
                { "removedState", n => { RemovedState = n.GetObjectValue<global::Microsoft.Graph.Models.RemovedState>(global::Microsoft.Graph.Models.RemovedState.CreateFromDiscriminatorValue); } },
                { "restrictedExperience", n => { RestrictedExperience = n.GetObjectValue<global::Microsoft.Graph.Models.OnlineMeetingRestricted>(global::Microsoft.Graph.Models.OnlineMeetingRestricted.CreateFromDiscriminatorValue); } },
                { "rosterSequenceNumber", n => { RosterSequenceNumber = n.GetLongValue(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ParticipantInfo>("info", Info);
            writer.WriteBoolValue("isInLobby", IsInLobby);
            writer.WriteBoolValue("isMuted", IsMuted);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.MediaStream>("mediaStreams", MediaStreams);
            writer.WriteStringValue("metadata", Metadata);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.RecordingInfo>("recordingInfo", RecordingInfo);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.RemovedState>("removedState", RemovedState);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.OnlineMeetingRestricted>("restrictedExperience", RestrictedExperience);
            writer.WriteLongValue("rosterSequenceNumber", RosterSequenceNumber);
        }
    }
}
