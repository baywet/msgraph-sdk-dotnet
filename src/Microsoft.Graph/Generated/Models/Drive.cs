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
    public partial class Drive : global::Microsoft.Graph.Models.BaseItem, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Collection of bundles (albums and multi-select-shared sets of items). Only in personal OneDrive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.DriveItem>? Bundles
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DriveItem>?>("bundles"); }
            set { BackingStore?.Set("bundles", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.DriveItem> Bundles
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DriveItem>>("bundles"); }
            set { BackingStore?.Set("bundles", value); }
        }
#endif
        /// <summary>Describes the type of drive represented by this resource. OneDrive personal drives will return personal. OneDrive for Business will return business. SharePoint document libraries will return documentLibrary. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DriveType
        {
            get { return BackingStore?.Get<string?>("driveType"); }
            set { BackingStore?.Set("driveType", value); }
        }
#nullable restore
#else
        public string DriveType
        {
            get { return BackingStore?.Get<string>("driveType"); }
            set { BackingStore?.Set("driveType", value); }
        }
#endif
        /// <summary>The list of items the user is following. Only in OneDrive for Business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.DriveItem>? Following
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DriveItem>?>("following"); }
            set { BackingStore?.Set("following", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.DriveItem> Following
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DriveItem>>("following"); }
            set { BackingStore?.Set("following", value); }
        }
#endif
        /// <summary>All items contained in the drive. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.DriveItem>? Items
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DriveItem>?>("items"); }
            set { BackingStore?.Set("items", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.DriveItem> Items
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DriveItem>>("items"); }
            set { BackingStore?.Set("items", value); }
        }
#endif
        /// <summary>For drives in SharePoint, the underlying document library list. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.List? List
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.List?>("list"); }
            set { BackingStore?.Set("list", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.List List
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.List>("list"); }
            set { BackingStore?.Set("list", value); }
        }
#endif
        /// <summary>Optional. The user account that owns the drive. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.IdentitySet? Owner
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentitySet?>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.IdentitySet Owner
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentitySet>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
#endif
        /// <summary>Optional. Information about the drive&apos;s storage space quota. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Quota? Quota
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Quota?>("quota"); }
            set { BackingStore?.Set("quota", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Quota Quota
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Quota>("quota"); }
            set { BackingStore?.Set("quota", value); }
        }
#endif
        /// <summary>The root folder of the drive. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.DriveItem? Root
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DriveItem?>("root"); }
            set { BackingStore?.Set("root", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.DriveItem Root
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DriveItem>("root"); }
            set { BackingStore?.Set("root", value); }
        }
#endif
        /// <summary>The sharePointIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.SharepointIds? SharePointIds
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SharepointIds?>("sharePointIds"); }
            set { BackingStore?.Set("sharePointIds", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.SharepointIds SharePointIds
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SharepointIds>("sharePointIds"); }
            set { BackingStore?.Set("sharePointIds", value); }
        }
#endif
        /// <summary>Collection of common folders available in OneDrive. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.DriveItem>? Special
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DriveItem>?>("special"); }
            set { BackingStore?.Set("special", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.DriveItem> Special
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DriveItem>>("special"); }
            set { BackingStore?.Set("special", value); }
        }
#endif
        /// <summary>If present, indicates that this is a system-managed drive. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.SystemFacet? System
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SystemFacet?>("system"); }
            set { BackingStore?.Set("system", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.SystemFacet System
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SystemFacet>("system"); }
            set { BackingStore?.Set("system", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.Drive"/> and sets the default values.
        /// </summary>
        public Drive() : base()
        {
            OdataType = "#microsoft.graph.drive";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Drive"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Drive CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Drive();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "bundles", n => { Bundles = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.DriveItem>(global::Microsoft.Graph.Models.DriveItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "driveType", n => { DriveType = n.GetStringValue(); } },
                { "following", n => { Following = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.DriveItem>(global::Microsoft.Graph.Models.DriveItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "items", n => { Items = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.DriveItem>(global::Microsoft.Graph.Models.DriveItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "list", n => { List = n.GetObjectValue<global::Microsoft.Graph.Models.List>(global::Microsoft.Graph.Models.List.CreateFromDiscriminatorValue); } },
                { "owner", n => { Owner = n.GetObjectValue<global::Microsoft.Graph.Models.IdentitySet>(global::Microsoft.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "quota", n => { Quota = n.GetObjectValue<global::Microsoft.Graph.Models.Quota>(global::Microsoft.Graph.Models.Quota.CreateFromDiscriminatorValue); } },
                { "root", n => { Root = n.GetObjectValue<global::Microsoft.Graph.Models.DriveItem>(global::Microsoft.Graph.Models.DriveItem.CreateFromDiscriminatorValue); } },
                { "sharePointIds", n => { SharePointIds = n.GetObjectValue<global::Microsoft.Graph.Models.SharepointIds>(global::Microsoft.Graph.Models.SharepointIds.CreateFromDiscriminatorValue); } },
                { "special", n => { Special = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.DriveItem>(global::Microsoft.Graph.Models.DriveItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "system", n => { System = n.GetObjectValue<global::Microsoft.Graph.Models.SystemFacet>(global::Microsoft.Graph.Models.SystemFacet.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.DriveItem>("bundles", Bundles);
            writer.WriteStringValue("driveType", DriveType);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.DriveItem>("following", Following);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.DriveItem>("items", Items);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.List>("list", List);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.IdentitySet>("owner", Owner);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Quota>("quota", Quota);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.DriveItem>("root", Root);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.SharepointIds>("sharePointIds", SharePointIds);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.DriveItem>("special", Special);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.SystemFacet>("system", System);
        }
    }
}
