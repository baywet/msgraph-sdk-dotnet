// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class LabelsRoot : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Specifies the underlying authority that describes the type of content to be retained and its retention schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.AuthorityTemplate>? Authorities
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.AuthorityTemplate>?>("authorities"); }
            set { BackingStore?.Set("authorities", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.AuthorityTemplate> Authorities
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.AuthorityTemplate>>("authorities"); }
            set { BackingStore?.Set("authorities", value); }
        }
#endif
        /// <summary>Specifies a group of similar types of content in a particular department.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.CategoryTemplate>? Categories
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.CategoryTemplate>?>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.CategoryTemplate> Categories
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.CategoryTemplate>>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#endif
        /// <summary>The specific rule or regulation created by a jurisdiction used to determine whether certain labels and content should be retained or deleted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.CitationTemplate>? Citations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.CitationTemplate>?>("citations"); }
            set { BackingStore?.Set("citations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.CitationTemplate> Citations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.CitationTemplate>>("citations"); }
            set { BackingStore?.Set("citations", value); }
        }
#endif
        /// <summary>Specifies the department or business unit of an organization to which a label belongs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.DepartmentTemplate>? Departments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.DepartmentTemplate>?>("departments"); }
            set { BackingStore?.Set("departments", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.DepartmentTemplate> Departments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.DepartmentTemplate>>("departments"); }
            set { BackingStore?.Set("departments", value); }
        }
#endif
        /// <summary>Specifies a unique alpha-numeric identifier for an organization’s retention schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.FilePlanReferenceTemplate>? FilePlanReferences
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.FilePlanReferenceTemplate>?>("filePlanReferences"); }
            set { BackingStore?.Set("filePlanReferences", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.FilePlanReferenceTemplate> FilePlanReferences
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.FilePlanReferenceTemplate>>("filePlanReferences"); }
            set { BackingStore?.Set("filePlanReferences", value); }
        }
#endif
        /// <summary>Represents how customers can manage their data, whether and for how long to retain or delete it.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.RetentionLabel>? RetentionLabels
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.RetentionLabel>?>("retentionLabels"); }
            set { BackingStore?.Set("retentionLabels", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.RetentionLabel> RetentionLabels
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.RetentionLabel>>("retentionLabels"); }
            set { BackingStore?.Set("retentionLabels", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Security.LabelsRoot"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Security.LabelsRoot CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Security.LabelsRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "authorities", n => { Authorities = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.AuthorityTemplate>(global::Microsoft.Graph.Models.Security.AuthorityTemplate.CreateFromDiscriminatorValue)?.AsList(); } },
                { "categories", n => { Categories = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.CategoryTemplate>(global::Microsoft.Graph.Models.Security.CategoryTemplate.CreateFromDiscriminatorValue)?.AsList(); } },
                { "citations", n => { Citations = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.CitationTemplate>(global::Microsoft.Graph.Models.Security.CitationTemplate.CreateFromDiscriminatorValue)?.AsList(); } },
                { "departments", n => { Departments = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.DepartmentTemplate>(global::Microsoft.Graph.Models.Security.DepartmentTemplate.CreateFromDiscriminatorValue)?.AsList(); } },
                { "filePlanReferences", n => { FilePlanReferences = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.FilePlanReferenceTemplate>(global::Microsoft.Graph.Models.Security.FilePlanReferenceTemplate.CreateFromDiscriminatorValue)?.AsList(); } },
                { "retentionLabels", n => { RetentionLabels = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.RetentionLabel>(global::Microsoft.Graph.Models.Security.RetentionLabel.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.AuthorityTemplate>("authorities", Authorities);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.CategoryTemplate>("categories", Categories);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.CitationTemplate>("citations", Citations);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.DepartmentTemplate>("departments", Departments);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.FilePlanReferenceTemplate>("filePlanReferences", FilePlanReferences);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.RetentionLabel>("retentionLabels", RetentionLabels);
        }
    }
}
