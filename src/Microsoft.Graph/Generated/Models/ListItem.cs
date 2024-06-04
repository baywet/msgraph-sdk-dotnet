// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class ListItem : Microsoft.Graph.Models.BaseItem, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Analytics about the view activities that took place on this item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ItemAnalytics? Analytics
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ItemAnalytics?>("analytics"); }
            set { BackingStore?.Set("analytics", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ItemAnalytics Analytics
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ItemAnalytics>("analytics"); }
            set { BackingStore?.Set("analytics", value); }
        }
#endif
        /// <summary>The content type of this list item</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ContentTypeInfo? ContentType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ContentTypeInfo?>("contentType"); }
            set { BackingStore?.Set("contentType", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ContentTypeInfo ContentType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ContentTypeInfo>("contentType"); }
            set { BackingStore?.Set("contentType", value); }
        }
#endif
        /// <summary>Version information for a document set version created by a user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.DocumentSetVersion>? DocumentSetVersions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.DocumentSetVersion>?>("documentSetVersions"); }
            set { BackingStore?.Set("documentSetVersions", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.DocumentSetVersion> DocumentSetVersions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.DocumentSetVersion>>("documentSetVersions"); }
            set { BackingStore?.Set("documentSetVersions", value); }
        }
#endif
        /// <summary>For document libraries, the driveItem relationship exposes the listItem as a driveItem</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.DriveItem? DriveItem
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DriveItem?>("driveItem"); }
            set { BackingStore?.Set("driveItem", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.DriveItem DriveItem
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DriveItem>("driveItem"); }
            set { BackingStore?.Set("driveItem", value); }
        }
#endif
        /// <summary>The values of the columns set on this list item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.FieldValueSet? Fields
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.FieldValueSet?>("fields"); }
            set { BackingStore?.Set("fields", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.FieldValueSet Fields
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.FieldValueSet>("fields"); }
            set { BackingStore?.Set("fields", value); }
        }
#endif
        /// <summary>Returns identifiers useful for SharePoint REST compatibility. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.SharepointIds? SharepointIds
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.SharepointIds?>("sharepointIds"); }
            set { BackingStore?.Set("sharepointIds", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.SharepointIds SharepointIds
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.SharepointIds>("sharepointIds"); }
            set { BackingStore?.Set("sharepointIds", value); }
        }
#endif
        /// <summary>The list of previous versions of the list item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.ListItemVersion>? Versions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.ListItemVersion>?>("versions"); }
            set { BackingStore?.Set("versions", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.ListItemVersion> Versions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.ListItemVersion>>("versions"); }
            set { BackingStore?.Set("versions", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Models.ListItem"/> and sets the default values.
        /// </summary>
        public ListItem() : base()
        {
            OdataType = "#microsoft.graph.listItem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.ListItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.ListItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.ListItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "analytics", n => { Analytics = n.GetObjectValue<Microsoft.Graph.Models.ItemAnalytics>(Microsoft.Graph.Models.ItemAnalytics.CreateFromDiscriminatorValue); } },
                { "contentType", n => { ContentType = n.GetObjectValue<Microsoft.Graph.Models.ContentTypeInfo>(Microsoft.Graph.Models.ContentTypeInfo.CreateFromDiscriminatorValue); } },
                { "documentSetVersions", n => { DocumentSetVersions = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.DocumentSetVersion>(Microsoft.Graph.Models.DocumentSetVersion.CreateFromDiscriminatorValue)?.ToList(); } },
                { "driveItem", n => { DriveItem = n.GetObjectValue<Microsoft.Graph.Models.DriveItem>(Microsoft.Graph.Models.DriveItem.CreateFromDiscriminatorValue); } },
                { "fields", n => { Fields = n.GetObjectValue<Microsoft.Graph.Models.FieldValueSet>(Microsoft.Graph.Models.FieldValueSet.CreateFromDiscriminatorValue); } },
                { "sharepointIds", n => { SharepointIds = n.GetObjectValue<Microsoft.Graph.Models.SharepointIds>(Microsoft.Graph.Models.SharepointIds.CreateFromDiscriminatorValue); } },
                { "versions", n => { Versions = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.ListItemVersion>(Microsoft.Graph.Models.ListItemVersion.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Models.ItemAnalytics>("analytics", Analytics);
            writer.WriteObjectValue<Microsoft.Graph.Models.ContentTypeInfo>("contentType", ContentType);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.DocumentSetVersion>("documentSetVersions", DocumentSetVersions);
            writer.WriteObjectValue<Microsoft.Graph.Models.DriveItem>("driveItem", DriveItem);
            writer.WriteObjectValue<Microsoft.Graph.Models.FieldValueSet>("fields", Fields);
            writer.WriteObjectValue<Microsoft.Graph.Models.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.ListItemVersion>("versions", Versions);
        }
    }
}
