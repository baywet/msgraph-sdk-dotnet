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
    public partial class Onenote : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The collection of OneNote notebooks that are owned by the user or group. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Notebook>? Notebooks
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Notebook>?>("notebooks"); }
            set { BackingStore?.Set("notebooks", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Notebook> Notebooks
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Notebook>>("notebooks"); }
            set { BackingStore?.Set("notebooks", value); }
        }
#endif
        /// <summary>The status of OneNote operations. Getting an operations collection isn&apos;t supported, but you can get the status of long-running operations if the Operation-Location header is returned in the response. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.OnenoteOperation>? Operations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.OnenoteOperation>?>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.OnenoteOperation> Operations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.OnenoteOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#endif
        /// <summary>The pages in all OneNote notebooks that are owned by the user or group.  Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.OnenotePage>? Pages
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.OnenotePage>?>("pages"); }
            set { BackingStore?.Set("pages", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.OnenotePage> Pages
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.OnenotePage>>("pages"); }
            set { BackingStore?.Set("pages", value); }
        }
#endif
        /// <summary>The image and other file resources in OneNote pages. Getting a resources collection isn&apos;t supported, but you can get the binary content of a specific resource. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.OnenoteResource>? Resources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.OnenoteResource>?>("resources"); }
            set { BackingStore?.Set("resources", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.OnenoteResource> Resources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.OnenoteResource>>("resources"); }
            set { BackingStore?.Set("resources", value); }
        }
#endif
        /// <summary>The section groups in all OneNote notebooks that are owned by the user or group.  Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.SectionGroup>? SectionGroups
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SectionGroup>?>("sectionGroups"); }
            set { BackingStore?.Set("sectionGroups", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.SectionGroup> SectionGroups
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SectionGroup>>("sectionGroups"); }
            set { BackingStore?.Set("sectionGroups", value); }
        }
#endif
        /// <summary>The sections in all OneNote notebooks that are owned by the user or group.  Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.OnenoteSection>? Sections
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.OnenoteSection>?>("sections"); }
            set { BackingStore?.Set("sections", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.OnenoteSection> Sections
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.OnenoteSection>>("sections"); }
            set { BackingStore?.Set("sections", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Onenote"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Onenote CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Onenote();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "notebooks", n => { Notebooks = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Notebook>(global::Microsoft.Graph.Models.Notebook.CreateFromDiscriminatorValue)?.AsList(); } },
                { "operations", n => { Operations = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.OnenoteOperation>(global::Microsoft.Graph.Models.OnenoteOperation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "pages", n => { Pages = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.OnenotePage>(global::Microsoft.Graph.Models.OnenotePage.CreateFromDiscriminatorValue)?.AsList(); } },
                { "resources", n => { Resources = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.OnenoteResource>(global::Microsoft.Graph.Models.OnenoteResource.CreateFromDiscriminatorValue)?.AsList(); } },
                { "sectionGroups", n => { SectionGroups = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.SectionGroup>(global::Microsoft.Graph.Models.SectionGroup.CreateFromDiscriminatorValue)?.AsList(); } },
                { "sections", n => { Sections = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.OnenoteSection>(global::Microsoft.Graph.Models.OnenoteSection.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Notebook>("notebooks", Notebooks);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.OnenoteOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.OnenotePage>("pages", Pages);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.OnenoteResource>("resources", Resources);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.SectionGroup>("sectionGroups", SectionGroups);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.OnenoteSection>("sections", Sections);
        }
    }
}
