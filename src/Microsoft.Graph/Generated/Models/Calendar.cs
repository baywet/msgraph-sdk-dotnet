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
    public partial class Calendar : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represent the online meeting service providers that can be used to create online meetings in this calendar. Possible values are: unknown, skypeForBusiness, skypeForConsumer, teamsForBusiness.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.OnlineMeetingProviderType?>? AllowedOnlineMeetingProviders
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.OnlineMeetingProviderType?>?>("allowedOnlineMeetingProviders"); }
            set { BackingStore?.Set("allowedOnlineMeetingProviders", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.OnlineMeetingProviderType?> AllowedOnlineMeetingProviders
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.OnlineMeetingProviderType?>>("allowedOnlineMeetingProviders"); }
            set { BackingStore?.Set("allowedOnlineMeetingProviders", value); }
        }
#endif
        /// <summary>The permissions of the users with whom the calendar is shared.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.CalendarPermission>? CalendarPermissions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.CalendarPermission>?>("calendarPermissions"); }
            set { BackingStore?.Set("calendarPermissions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.CalendarPermission> CalendarPermissions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.CalendarPermission>>("calendarPermissions"); }
            set { BackingStore?.Set("calendarPermissions", value); }
        }
#endif
        /// <summary>The calendar view for the calendar. Navigation property. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Event>? CalendarView
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Event>?>("calendarView"); }
            set { BackingStore?.Set("calendarView", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Event> CalendarView
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Event>>("calendarView"); }
            set { BackingStore?.Set("calendarView", value); }
        }
#endif
        /// <summary>true if the user can write to the calendar, false otherwise. This property is true for the user who created the calendar. This property is also true for a user who has been shared a calendar and granted write access.</summary>
        public bool? CanEdit
        {
            get { return BackingStore?.Get<bool?>("canEdit"); }
            set { BackingStore?.Set("canEdit", value); }
        }
        /// <summary>true if the user has the permission to share the calendar, false otherwise. Only the user who created the calendar can share it.</summary>
        public bool? CanShare
        {
            get { return BackingStore?.Get<bool?>("canShare"); }
            set { BackingStore?.Set("canShare", value); }
        }
        /// <summary>true if the user can read calendar items that have been marked private, false otherwise.</summary>
        public bool? CanViewPrivateItems
        {
            get { return BackingStore?.Get<bool?>("canViewPrivateItems"); }
            set { BackingStore?.Set("canViewPrivateItems", value); }
        }
        /// <summary>Identifies the version of the calendar object. Every time the calendar is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChangeKey
        {
            get { return BackingStore?.Get<string?>("changeKey"); }
            set { BackingStore?.Set("changeKey", value); }
        }
#nullable restore
#else
        public string ChangeKey
        {
            get { return BackingStore?.Get<string>("changeKey"); }
            set { BackingStore?.Set("changeKey", value); }
        }
#endif
        /// <summary>Specifies the color theme to distinguish the calendar from other calendars in a UI. The property values are: auto, lightBlue, lightGreen, lightOrange, lightGray, lightYellow, lightTeal, lightPink, lightBrown, lightRed, maxColor.</summary>
        public global::Microsoft.Graph.Models.CalendarColor? Color
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CalendarColor?>("color"); }
            set { BackingStore?.Set("color", value); }
        }
        /// <summary>The default online meeting provider for meetings sent from this calendar. Possible values are: unknown, skypeForBusiness, skypeForConsumer, teamsForBusiness.</summary>
        public global::Microsoft.Graph.Models.OnlineMeetingProviderType? DefaultOnlineMeetingProvider
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.OnlineMeetingProviderType?>("defaultOnlineMeetingProvider"); }
            set { BackingStore?.Set("defaultOnlineMeetingProvider", value); }
        }
        /// <summary>The events in the calendar. Navigation property. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Event>? Events
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Event>?>("events"); }
            set { BackingStore?.Set("events", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Event> Events
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Event>>("events"); }
            set { BackingStore?.Set("events", value); }
        }
#endif
        /// <summary>The calendar color, expressed in a hex color code of three hexadecimal values, each ranging from 00 to FF and representing the red, green, or blue components of the color in the RGB color space. If the user has never explicitly set a color for the calendar, this property is empty. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HexColor
        {
            get { return BackingStore?.Get<string?>("hexColor"); }
            set { BackingStore?.Set("hexColor", value); }
        }
#nullable restore
#else
        public string HexColor
        {
            get { return BackingStore?.Get<string>("hexColor"); }
            set { BackingStore?.Set("hexColor", value); }
        }
#endif
        /// <summary>true if this is the default calendar where new events are created by default, false otherwise.</summary>
        public bool? IsDefaultCalendar
        {
            get { return BackingStore?.Get<bool?>("isDefaultCalendar"); }
            set { BackingStore?.Set("isDefaultCalendar", value); }
        }
        /// <summary>Indicates whether this user calendar can be deleted from the user mailbox.</summary>
        public bool? IsRemovable
        {
            get { return BackingStore?.Get<bool?>("isRemovable"); }
            set { BackingStore?.Set("isRemovable", value); }
        }
        /// <summary>Indicates whether this user calendar supports tracking of meeting responses. Only meeting invites sent from users&apos; primary calendars support tracking of meeting responses.</summary>
        public bool? IsTallyingResponses
        {
            get { return BackingStore?.Get<bool?>("isTallyingResponses"); }
            set { BackingStore?.Set("isTallyingResponses", value); }
        }
        /// <summary>The collection of multi-value extended properties defined for the calendar. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.MultiValueLegacyExtendedProperty>? MultiValueExtendedProperties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.MultiValueLegacyExtendedProperty>?>("multiValueExtendedProperties"); }
            set { BackingStore?.Set("multiValueExtendedProperties", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.MultiValueLegacyExtendedProperty> MultiValueExtendedProperties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.MultiValueLegacyExtendedProperty>>("multiValueExtendedProperties"); }
            set { BackingStore?.Set("multiValueExtendedProperties", value); }
        }
#endif
        /// <summary>The calendar name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name
        {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name
        {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>If set, this represents the user who created or added the calendar. For a calendar that the user created or added, the owner property is set to the user. For a calendar shared with the user, the owner property is set to the person who shared that calendar with the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.EmailAddress? Owner
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EmailAddress?>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.EmailAddress Owner
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EmailAddress>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
#endif
        /// <summary>The collection of single-value extended properties defined for the calendar. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.SingleValueLegacyExtendedProperty>? SingleValueExtendedProperties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SingleValueLegacyExtendedProperty>?>("singleValueExtendedProperties"); }
            set { BackingStore?.Set("singleValueExtendedProperties", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.SingleValueLegacyExtendedProperty> SingleValueExtendedProperties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SingleValueLegacyExtendedProperty>>("singleValueExtendedProperties"); }
            set { BackingStore?.Set("singleValueExtendedProperties", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Calendar"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Calendar CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Calendar();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowedOnlineMeetingProviders", n => { AllowedOnlineMeetingProviders = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Models.OnlineMeetingProviderType>()?.AsList(); } },
                { "calendarPermissions", n => { CalendarPermissions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.CalendarPermission>(global::Microsoft.Graph.Models.CalendarPermission.CreateFromDiscriminatorValue)?.AsList(); } },
                { "calendarView", n => { CalendarView = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Event>(global::Microsoft.Graph.Models.Event.CreateFromDiscriminatorValue)?.AsList(); } },
                { "canEdit", n => { CanEdit = n.GetBoolValue(); } },
                { "canShare", n => { CanShare = n.GetBoolValue(); } },
                { "canViewPrivateItems", n => { CanViewPrivateItems = n.GetBoolValue(); } },
                { "changeKey", n => { ChangeKey = n.GetStringValue(); } },
                { "color", n => { Color = n.GetEnumValue<global::Microsoft.Graph.Models.CalendarColor>(); } },
                { "defaultOnlineMeetingProvider", n => { DefaultOnlineMeetingProvider = n.GetEnumValue<global::Microsoft.Graph.Models.OnlineMeetingProviderType>(); } },
                { "events", n => { Events = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Event>(global::Microsoft.Graph.Models.Event.CreateFromDiscriminatorValue)?.AsList(); } },
                { "hexColor", n => { HexColor = n.GetStringValue(); } },
                { "isDefaultCalendar", n => { IsDefaultCalendar = n.GetBoolValue(); } },
                { "isRemovable", n => { IsRemovable = n.GetBoolValue(); } },
                { "isTallyingResponses", n => { IsTallyingResponses = n.GetBoolValue(); } },
                { "multiValueExtendedProperties", n => { MultiValueExtendedProperties = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.MultiValueLegacyExtendedProperty>(global::Microsoft.Graph.Models.MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.AsList(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "owner", n => { Owner = n.GetObjectValue<global::Microsoft.Graph.Models.EmailAddress>(global::Microsoft.Graph.Models.EmailAddress.CreateFromDiscriminatorValue); } },
                { "singleValueExtendedProperties", n => { SingleValueExtendedProperties = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.SingleValueLegacyExtendedProperty>(global::Microsoft.Graph.Models.SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Models.OnlineMeetingProviderType>("allowedOnlineMeetingProviders", AllowedOnlineMeetingProviders);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.CalendarPermission>("calendarPermissions", CalendarPermissions);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Event>("calendarView", CalendarView);
            writer.WriteBoolValue("canEdit", CanEdit);
            writer.WriteBoolValue("canShare", CanShare);
            writer.WriteBoolValue("canViewPrivateItems", CanViewPrivateItems);
            writer.WriteStringValue("changeKey", ChangeKey);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.CalendarColor>("color", Color);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.OnlineMeetingProviderType>("defaultOnlineMeetingProvider", DefaultOnlineMeetingProvider);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Event>("events", Events);
            writer.WriteStringValue("hexColor", HexColor);
            writer.WriteBoolValue("isDefaultCalendar", IsDefaultCalendar);
            writer.WriteBoolValue("isRemovable", IsRemovable);
            writer.WriteBoolValue("isTallyingResponses", IsTallyingResponses);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.EmailAddress>("owner", Owner);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
        }
    }
}
