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
    public partial class ColumnDefinition : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>This column stores boolean values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.BooleanColumn? Boolean
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.BooleanColumn?>("boolean"); }
            set { BackingStore?.Set("boolean", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.BooleanColumn Boolean
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.BooleanColumn>("boolean"); }
            set { BackingStore?.Set("boolean", value); }
        }
#endif
        /// <summary>This column&apos;s data is calculated based on other columns.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.CalculatedColumn? Calculated
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CalculatedColumn?>("calculated"); }
            set { BackingStore?.Set("calculated", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.CalculatedColumn Calculated
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CalculatedColumn>("calculated"); }
            set { BackingStore?.Set("calculated", value); }
        }
#endif
        /// <summary>This column stores data from a list of choices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ChoiceColumn? Choice
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ChoiceColumn?>("choice"); }
            set { BackingStore?.Set("choice", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ChoiceColumn Choice
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ChoiceColumn>("choice"); }
            set { BackingStore?.Set("choice", value); }
        }
#endif
        /// <summary>For site columns, the name of the group this column belongs to. Helps organize related columns.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ColumnGroup
        {
            get { return BackingStore?.Get<string?>("columnGroup"); }
            set { BackingStore?.Set("columnGroup", value); }
        }
#nullable restore
#else
        public string ColumnGroup
        {
            get { return BackingStore?.Get<string>("columnGroup"); }
            set { BackingStore?.Set("columnGroup", value); }
        }
#endif
        /// <summary>This column stores content approval status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ContentApprovalStatusColumn? ContentApprovalStatus
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ContentApprovalStatusColumn?>("contentApprovalStatus"); }
            set { BackingStore?.Set("contentApprovalStatus", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ContentApprovalStatusColumn ContentApprovalStatus
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ContentApprovalStatusColumn>("contentApprovalStatus"); }
            set { BackingStore?.Set("contentApprovalStatus", value); }
        }
#endif
        /// <summary>This column stores currency values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.CurrencyColumn? Currency
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CurrencyColumn?>("currency"); }
            set { BackingStore?.Set("currency", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.CurrencyColumn Currency
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CurrencyColumn>("currency"); }
            set { BackingStore?.Set("currency", value); }
        }
#endif
        /// <summary>This column stores DateTime values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.DateTimeColumn? DateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DateTimeColumn?>("dateTime"); }
            set { BackingStore?.Set("dateTime", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.DateTimeColumn DateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DateTimeColumn>("dateTime"); }
            set { BackingStore?.Set("dateTime", value); }
        }
#endif
        /// <summary>The default value for this column.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.DefaultColumnValue? DefaultValue
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DefaultColumnValue?>("defaultValue"); }
            set { BackingStore?.Set("defaultValue", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.DefaultColumnValue DefaultValue
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DefaultColumnValue>("defaultValue"); }
            set { BackingStore?.Set("defaultValue", value); }
        }
#endif
        /// <summary>The user-facing description of the column.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The user-facing name of the column.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>If true, no two list items may have the same value for this column.</summary>
        public bool? EnforceUniqueValues
        {
            get { return BackingStore?.Get<bool?>("enforceUniqueValues"); }
            set { BackingStore?.Set("enforceUniqueValues", value); }
        }
        /// <summary>This column stores a geolocation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.GeolocationColumn? Geolocation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.GeolocationColumn?>("geolocation"); }
            set { BackingStore?.Set("geolocation", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.GeolocationColumn Geolocation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.GeolocationColumn>("geolocation"); }
            set { BackingStore?.Set("geolocation", value); }
        }
#endif
        /// <summary>Specifies whether the column is displayed in the user interface.</summary>
        public bool? Hidden
        {
            get { return BackingStore?.Get<bool?>("hidden"); }
            set { BackingStore?.Set("hidden", value); }
        }
        /// <summary>This column stores hyperlink or picture values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.HyperlinkOrPictureColumn? HyperlinkOrPicture
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.HyperlinkOrPictureColumn?>("hyperlinkOrPicture"); }
            set { BackingStore?.Set("hyperlinkOrPicture", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.HyperlinkOrPictureColumn HyperlinkOrPicture
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.HyperlinkOrPictureColumn>("hyperlinkOrPicture"); }
            set { BackingStore?.Set("hyperlinkOrPicture", value); }
        }
#endif
        /// <summary>Specifies whether the column values can be used for sorting and searching.</summary>
        public bool? Indexed
        {
            get { return BackingStore?.Get<bool?>("indexed"); }
            set { BackingStore?.Set("indexed", value); }
        }
        /// <summary>Indicates whether this column can be deleted.</summary>
        public bool? IsDeletable
        {
            get { return BackingStore?.Get<bool?>("isDeletable"); }
            set { BackingStore?.Set("isDeletable", value); }
        }
        /// <summary>Indicates whether values in the column can be reordered. Read-only.</summary>
        public bool? IsReorderable
        {
            get { return BackingStore?.Get<bool?>("isReorderable"); }
            set { BackingStore?.Set("isReorderable", value); }
        }
        /// <summary>Specifies whether the column can be changed.</summary>
        public bool? IsSealed
        {
            get { return BackingStore?.Get<bool?>("isSealed"); }
            set { BackingStore?.Set("isSealed", value); }
        }
        /// <summary>This column&apos;s data is looked up from another source in the site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.LookupColumn? Lookup
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.LookupColumn?>("lookup"); }
            set { BackingStore?.Set("lookup", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.LookupColumn Lookup
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.LookupColumn>("lookup"); }
            set { BackingStore?.Set("lookup", value); }
        }
#endif
        /// <summary>The API-facing name of the column as it appears in the fields on a listItem. For the user-facing name, see displayName.</summary>
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
        /// <summary>This column stores number values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.NumberColumn? Number
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.NumberColumn?>("number"); }
            set { BackingStore?.Set("number", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.NumberColumn Number
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.NumberColumn>("number"); }
            set { BackingStore?.Set("number", value); }
        }
#endif
        /// <summary>This column stores Person or Group values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.PersonOrGroupColumn? PersonOrGroup
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PersonOrGroupColumn?>("personOrGroup"); }
            set { BackingStore?.Set("personOrGroup", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.PersonOrGroupColumn PersonOrGroup
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PersonOrGroupColumn>("personOrGroup"); }
            set { BackingStore?.Set("personOrGroup", value); }
        }
#endif
        /// <summary>If &apos;true&apos;, changes to this column will be propagated to lists that implement the column.</summary>
        public bool? PropagateChanges
        {
            get { return BackingStore?.Get<bool?>("propagateChanges"); }
            set { BackingStore?.Set("propagateChanges", value); }
        }
        /// <summary>Specifies whether the column values can be modified.</summary>
        public bool? ReadOnly
        {
            get { return BackingStore?.Get<bool?>("readOnly"); }
            set { BackingStore?.Set("readOnly", value); }
        }
        /// <summary>Specifies whether the column value isn&apos;t optional.</summary>
        public bool? Required
        {
            get { return BackingStore?.Get<bool?>("required"); }
            set { BackingStore?.Set("required", value); }
        }
        /// <summary>The source column for the content type column.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ColumnDefinition? SourceColumn
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ColumnDefinition?>("sourceColumn"); }
            set { BackingStore?.Set("sourceColumn", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ColumnDefinition SourceColumn
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ColumnDefinition>("sourceColumn"); }
            set { BackingStore?.Set("sourceColumn", value); }
        }
#endif
        /// <summary>ContentType from which this column is inherited from. Present only in contentTypes columns response. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ContentTypeInfo? SourceContentType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ContentTypeInfo?>("sourceContentType"); }
            set { BackingStore?.Set("sourceContentType", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ContentTypeInfo SourceContentType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ContentTypeInfo>("sourceContentType"); }
            set { BackingStore?.Set("sourceContentType", value); }
        }
#endif
        /// <summary>This column stores taxonomy terms.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.TermColumn? Term
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TermColumn?>("term"); }
            set { BackingStore?.Set("term", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.TermColumn Term
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TermColumn>("term"); }
            set { BackingStore?.Set("term", value); }
        }
#endif
        /// <summary>This column stores text values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.TextColumn? Text
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TextColumn?>("text"); }
            set { BackingStore?.Set("text", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.TextColumn Text
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TextColumn>("text"); }
            set { BackingStore?.Set("text", value); }
        }
#endif
        /// <summary>This column stores thumbnail values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ThumbnailColumn? Thumbnail
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ThumbnailColumn?>("thumbnail"); }
            set { BackingStore?.Set("thumbnail", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ThumbnailColumn Thumbnail
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ThumbnailColumn>("thumbnail"); }
            set { BackingStore?.Set("thumbnail", value); }
        }
#endif
        /// <summary>For site columns, the type of column. Read-only.</summary>
        public global::Microsoft.Graph.Models.ColumnTypes? Type
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ColumnTypes?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>This column stores validation formula and message for the column.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ColumnValidation? Validation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ColumnValidation?>("validation"); }
            set { BackingStore?.Set("validation", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ColumnValidation Validation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ColumnValidation>("validation"); }
            set { BackingStore?.Set("validation", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ColumnDefinition"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.ColumnDefinition CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.ColumnDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "boolean", n => { Boolean = n.GetObjectValue<global::Microsoft.Graph.Models.BooleanColumn>(global::Microsoft.Graph.Models.BooleanColumn.CreateFromDiscriminatorValue); } },
                { "calculated", n => { Calculated = n.GetObjectValue<global::Microsoft.Graph.Models.CalculatedColumn>(global::Microsoft.Graph.Models.CalculatedColumn.CreateFromDiscriminatorValue); } },
                { "choice", n => { Choice = n.GetObjectValue<global::Microsoft.Graph.Models.ChoiceColumn>(global::Microsoft.Graph.Models.ChoiceColumn.CreateFromDiscriminatorValue); } },
                { "columnGroup", n => { ColumnGroup = n.GetStringValue(); } },
                { "contentApprovalStatus", n => { ContentApprovalStatus = n.GetObjectValue<global::Microsoft.Graph.Models.ContentApprovalStatusColumn>(global::Microsoft.Graph.Models.ContentApprovalStatusColumn.CreateFromDiscriminatorValue); } },
                { "currency", n => { Currency = n.GetObjectValue<global::Microsoft.Graph.Models.CurrencyColumn>(global::Microsoft.Graph.Models.CurrencyColumn.CreateFromDiscriminatorValue); } },
                { "dateTime", n => { DateTime = n.GetObjectValue<global::Microsoft.Graph.Models.DateTimeColumn>(global::Microsoft.Graph.Models.DateTimeColumn.CreateFromDiscriminatorValue); } },
                { "defaultValue", n => { DefaultValue = n.GetObjectValue<global::Microsoft.Graph.Models.DefaultColumnValue>(global::Microsoft.Graph.Models.DefaultColumnValue.CreateFromDiscriminatorValue); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "enforceUniqueValues", n => { EnforceUniqueValues = n.GetBoolValue(); } },
                { "geolocation", n => { Geolocation = n.GetObjectValue<global::Microsoft.Graph.Models.GeolocationColumn>(global::Microsoft.Graph.Models.GeolocationColumn.CreateFromDiscriminatorValue); } },
                { "hidden", n => { Hidden = n.GetBoolValue(); } },
                { "hyperlinkOrPicture", n => { HyperlinkOrPicture = n.GetObjectValue<global::Microsoft.Graph.Models.HyperlinkOrPictureColumn>(global::Microsoft.Graph.Models.HyperlinkOrPictureColumn.CreateFromDiscriminatorValue); } },
                { "indexed", n => { Indexed = n.GetBoolValue(); } },
                { "isDeletable", n => { IsDeletable = n.GetBoolValue(); } },
                { "isReorderable", n => { IsReorderable = n.GetBoolValue(); } },
                { "isSealed", n => { IsSealed = n.GetBoolValue(); } },
                { "lookup", n => { Lookup = n.GetObjectValue<global::Microsoft.Graph.Models.LookupColumn>(global::Microsoft.Graph.Models.LookupColumn.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "number", n => { Number = n.GetObjectValue<global::Microsoft.Graph.Models.NumberColumn>(global::Microsoft.Graph.Models.NumberColumn.CreateFromDiscriminatorValue); } },
                { "personOrGroup", n => { PersonOrGroup = n.GetObjectValue<global::Microsoft.Graph.Models.PersonOrGroupColumn>(global::Microsoft.Graph.Models.PersonOrGroupColumn.CreateFromDiscriminatorValue); } },
                { "propagateChanges", n => { PropagateChanges = n.GetBoolValue(); } },
                { "readOnly", n => { ReadOnly = n.GetBoolValue(); } },
                { "required", n => { Required = n.GetBoolValue(); } },
                { "sourceColumn", n => { SourceColumn = n.GetObjectValue<global::Microsoft.Graph.Models.ColumnDefinition>(global::Microsoft.Graph.Models.ColumnDefinition.CreateFromDiscriminatorValue); } },
                { "sourceContentType", n => { SourceContentType = n.GetObjectValue<global::Microsoft.Graph.Models.ContentTypeInfo>(global::Microsoft.Graph.Models.ContentTypeInfo.CreateFromDiscriminatorValue); } },
                { "term", n => { Term = n.GetObjectValue<global::Microsoft.Graph.Models.TermColumn>(global::Microsoft.Graph.Models.TermColumn.CreateFromDiscriminatorValue); } },
                { "text", n => { Text = n.GetObjectValue<global::Microsoft.Graph.Models.TextColumn>(global::Microsoft.Graph.Models.TextColumn.CreateFromDiscriminatorValue); } },
                { "thumbnail", n => { Thumbnail = n.GetObjectValue<global::Microsoft.Graph.Models.ThumbnailColumn>(global::Microsoft.Graph.Models.ThumbnailColumn.CreateFromDiscriminatorValue); } },
                { "type", n => { Type = n.GetEnumValue<global::Microsoft.Graph.Models.ColumnTypes>(); } },
                { "validation", n => { Validation = n.GetObjectValue<global::Microsoft.Graph.Models.ColumnValidation>(global::Microsoft.Graph.Models.ColumnValidation.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.BooleanColumn>("boolean", Boolean);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.CalculatedColumn>("calculated", Calculated);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ChoiceColumn>("choice", Choice);
            writer.WriteStringValue("columnGroup", ColumnGroup);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ContentApprovalStatusColumn>("contentApprovalStatus", ContentApprovalStatus);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.CurrencyColumn>("currency", Currency);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.DateTimeColumn>("dateTime", DateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.DefaultColumnValue>("defaultValue", DefaultValue);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("enforceUniqueValues", EnforceUniqueValues);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.GeolocationColumn>("geolocation", Geolocation);
            writer.WriteBoolValue("hidden", Hidden);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.HyperlinkOrPictureColumn>("hyperlinkOrPicture", HyperlinkOrPicture);
            writer.WriteBoolValue("indexed", Indexed);
            writer.WriteBoolValue("isDeletable", IsDeletable);
            writer.WriteBoolValue("isReorderable", IsReorderable);
            writer.WriteBoolValue("isSealed", IsSealed);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.LookupColumn>("lookup", Lookup);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.NumberColumn>("number", Number);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.PersonOrGroupColumn>("personOrGroup", PersonOrGroup);
            writer.WriteBoolValue("propagateChanges", PropagateChanges);
            writer.WriteBoolValue("readOnly", ReadOnly);
            writer.WriteBoolValue("required", Required);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ColumnDefinition>("sourceColumn", SourceColumn);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ContentTypeInfo>("sourceContentType", SourceContentType);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.TermColumn>("term", Term);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.TextColumn>("text", Text);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ThumbnailColumn>("thumbnail", Thumbnail);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.ColumnTypes>("type", Type);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ColumnValidation>("validation", Validation);
        }
    }
}
