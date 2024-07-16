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
    public partial class UnifiedRoleManagementPolicyNotificationRule : global::Microsoft.Graph.Models.UnifiedRoleManagementPolicyRule, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Indicates whether a default recipient will receive the notification email.</summary>
        public bool? IsDefaultRecipientsEnabled
        {
            get { return BackingStore?.Get<bool?>("isDefaultRecipientsEnabled"); }
            set { BackingStore?.Set("isDefaultRecipientsEnabled", value); }
        }
        /// <summary>The level of notification. The possible values are None, Critical, All.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NotificationLevel
        {
            get { return BackingStore?.Get<string?>("notificationLevel"); }
            set { BackingStore?.Set("notificationLevel", value); }
        }
#nullable restore
#else
        public string NotificationLevel
        {
            get { return BackingStore?.Get<string>("notificationLevel"); }
            set { BackingStore?.Set("notificationLevel", value); }
        }
#endif
        /// <summary>The list of recipients of the email notifications.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? NotificationRecipients
        {
            get { return BackingStore?.Get<List<string>?>("notificationRecipients"); }
            set { BackingStore?.Set("notificationRecipients", value); }
        }
#nullable restore
#else
        public List<string> NotificationRecipients
        {
            get { return BackingStore?.Get<List<string>>("notificationRecipients"); }
            set { BackingStore?.Set("notificationRecipients", value); }
        }
#endif
        /// <summary>The type of notification. Only Email is supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NotificationType
        {
            get { return BackingStore?.Get<string?>("notificationType"); }
            set { BackingStore?.Set("notificationType", value); }
        }
#nullable restore
#else
        public string NotificationType
        {
            get { return BackingStore?.Get<string>("notificationType"); }
            set { BackingStore?.Set("notificationType", value); }
        }
#endif
        /// <summary>The type of recipient of the notification. The possible values are Requestor, Approver, Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecipientType
        {
            get { return BackingStore?.Get<string?>("recipientType"); }
            set { BackingStore?.Set("recipientType", value); }
        }
#nullable restore
#else
        public string RecipientType
        {
            get { return BackingStore?.Get<string>("recipientType"); }
            set { BackingStore?.Set("recipientType", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.UnifiedRoleManagementPolicyNotificationRule"/> and sets the default values.
        /// </summary>
        public UnifiedRoleManagementPolicyNotificationRule() : base()
        {
            OdataType = "#microsoft.graph.unifiedRoleManagementPolicyNotificationRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.UnifiedRoleManagementPolicyNotificationRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.UnifiedRoleManagementPolicyNotificationRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.UnifiedRoleManagementPolicyNotificationRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "isDefaultRecipientsEnabled", n => { IsDefaultRecipientsEnabled = n.GetBoolValue(); } },
                { "notificationLevel", n => { NotificationLevel = n.GetStringValue(); } },
                { "notificationRecipients", n => { NotificationRecipients = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "notificationType", n => { NotificationType = n.GetStringValue(); } },
                { "recipientType", n => { RecipientType = n.GetStringValue(); } },
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
            writer.WriteBoolValue("isDefaultRecipientsEnabled", IsDefaultRecipientsEnabled);
            writer.WriteStringValue("notificationLevel", NotificationLevel);
            writer.WriteCollectionOfPrimitiveValues<string>("notificationRecipients", NotificationRecipients);
            writer.WriteStringValue("notificationType", NotificationType);
            writer.WriteStringValue("recipientType", RecipientType);
        }
    }
}
