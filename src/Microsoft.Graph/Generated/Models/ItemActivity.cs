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
    public partial class ItemActivity : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>An item was accessed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AccessAction? Access
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessAction?>("access"); }
            set { BackingStore?.Set("access", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AccessAction Access
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AccessAction>("access"); }
            set { BackingStore?.Set("access", value); }
        }
#endif
        /// <summary>Details about when the activity took place. Read-only.</summary>
        public DateTimeOffset? ActivityDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("activityDateTime"); }
            set { BackingStore?.Set("activityDateTime", value); }
        }
        /// <summary>Identity of who performed the action. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.IdentitySet? Actor
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentitySet?>("actor"); }
            set { BackingStore?.Set("actor", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.IdentitySet Actor
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentitySet>("actor"); }
            set { BackingStore?.Set("actor", value); }
        }
#endif
        /// <summary>Exposes the driveItem that was the target of this activity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.DriveItem? DriveItem
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DriveItem?>("driveItem"); }
            set { BackingStore?.Set("driveItem", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.DriveItem DriveItem
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DriveItem>("driveItem"); }
            set { BackingStore?.Set("driveItem", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ItemActivity"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.ItemActivity CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.ItemActivity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "access", n => { Access = n.GetObjectValue<global::Microsoft.Graph.Models.AccessAction>(global::Microsoft.Graph.Models.AccessAction.CreateFromDiscriminatorValue); } },
                { "activityDateTime", n => { ActivityDateTime = n.GetDateTimeOffsetValue(); } },
                { "actor", n => { Actor = n.GetObjectValue<global::Microsoft.Graph.Models.IdentitySet>(global::Microsoft.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "driveItem", n => { DriveItem = n.GetObjectValue<global::Microsoft.Graph.Models.DriveItem>(global::Microsoft.Graph.Models.DriveItem.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AccessAction>("access", Access);
            writer.WriteDateTimeOffsetValue("activityDateTime", ActivityDateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.IdentitySet>("actor", Actor);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.DriveItem>("driveItem", DriveItem);
        }
    }
}
