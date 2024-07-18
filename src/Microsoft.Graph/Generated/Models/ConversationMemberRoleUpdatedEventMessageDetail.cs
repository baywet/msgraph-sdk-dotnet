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
    public partial class ConversationMemberRoleUpdatedEventMessageDetail : global::Microsoft.Graph.Models.EventMessageDetail, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Roles for the coversation member user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ConversationMemberRoles
        {
            get { return BackingStore?.Get<List<string>?>("conversationMemberRoles"); }
            set { BackingStore?.Set("conversationMemberRoles", value); }
        }
#nullable restore
#else
        public List<string> ConversationMemberRoles
        {
            get { return BackingStore?.Get<List<string>>("conversationMemberRoles"); }
            set { BackingStore?.Set("conversationMemberRoles", value); }
        }
#endif
        /// <summary>Identity of the conversation member user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.TeamworkUserIdentity? ConversationMemberUser
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TeamworkUserIdentity?>("conversationMemberUser"); }
            set { BackingStore?.Set("conversationMemberUser", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.TeamworkUserIdentity ConversationMemberUser
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TeamworkUserIdentity>("conversationMemberUser"); }
            set { BackingStore?.Set("conversationMemberUser", value); }
        }
#endif
        /// <summary>Initiator of the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.IdentitySet? Initiator
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentitySet?>("initiator"); }
            set { BackingStore?.Set("initiator", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.IdentitySet Initiator
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentitySet>("initiator"); }
            set { BackingStore?.Set("initiator", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.ConversationMemberRoleUpdatedEventMessageDetail"/> and sets the default values.
        /// </summary>
        public ConversationMemberRoleUpdatedEventMessageDetail() : base()
        {
            OdataType = "#microsoft.graph.conversationMemberRoleUpdatedEventMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ConversationMemberRoleUpdatedEventMessageDetail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.ConversationMemberRoleUpdatedEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.ConversationMemberRoleUpdatedEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "conversationMemberRoles", n => { ConversationMemberRoles = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "conversationMemberUser", n => { ConversationMemberUser = n.GetObjectValue<global::Microsoft.Graph.Models.TeamworkUserIdentity>(global::Microsoft.Graph.Models.TeamworkUserIdentity.CreateFromDiscriminatorValue); } },
                { "initiator", n => { Initiator = n.GetObjectValue<global::Microsoft.Graph.Models.IdentitySet>(global::Microsoft.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("conversationMemberRoles", ConversationMemberRoles);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.TeamworkUserIdentity>("conversationMemberUser", ConversationMemberUser);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.IdentitySet>("initiator", Initiator);
        }
    }
}
