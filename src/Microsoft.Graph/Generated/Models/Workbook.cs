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
    public partial class Workbook : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The application property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.WorkbookApplication? Application
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WorkbookApplication?>("application"); }
            set { BackingStore?.Set("application", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.WorkbookApplication Application
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WorkbookApplication>("application"); }
            set { BackingStore?.Set("application", value); }
        }
#endif
        /// <summary>Represents a collection of comments in a workbook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.WorkbookComment>? Comments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WorkbookComment>?>("comments"); }
            set { BackingStore?.Set("comments", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.WorkbookComment> Comments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WorkbookComment>>("comments"); }
            set { BackingStore?.Set("comments", value); }
        }
#endif
        /// <summary>The functions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.WorkbookFunctions? Functions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WorkbookFunctions?>("functions"); }
            set { BackingStore?.Set("functions", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.WorkbookFunctions Functions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WorkbookFunctions>("functions"); }
            set { BackingStore?.Set("functions", value); }
        }
#endif
        /// <summary>Represents a collection of workbooks scoped named items (named ranges and constants). Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.WorkbookNamedItem>? Names
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WorkbookNamedItem>?>("names"); }
            set { BackingStore?.Set("names", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.WorkbookNamedItem> Names
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WorkbookNamedItem>>("names"); }
            set { BackingStore?.Set("names", value); }
        }
#endif
        /// <summary>The status of workbook operations. Getting an operation collection is not supported, but you can get the status of a long-running operation if the Location header is returned in the response. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.WorkbookOperation>? Operations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WorkbookOperation>?>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.WorkbookOperation> Operations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WorkbookOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#endif
        /// <summary>Represents a collection of tables associated with the workbook. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.WorkbookTable>? Tables
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WorkbookTable>?>("tables"); }
            set { BackingStore?.Set("tables", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.WorkbookTable> Tables
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WorkbookTable>>("tables"); }
            set { BackingStore?.Set("tables", value); }
        }
#endif
        /// <summary>Represents a collection of worksheets associated with the workbook. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.WorkbookWorksheet>? Worksheets
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WorkbookWorksheet>?>("worksheets"); }
            set { BackingStore?.Set("worksheets", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.WorkbookWorksheet> Worksheets
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WorkbookWorksheet>>("worksheets"); }
            set { BackingStore?.Set("worksheets", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Workbook"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Workbook CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Workbook();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "application", n => { Application = n.GetObjectValue<global::Microsoft.Graph.Models.WorkbookApplication>(global::Microsoft.Graph.Models.WorkbookApplication.CreateFromDiscriminatorValue); } },
                { "comments", n => { Comments = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.WorkbookComment>(global::Microsoft.Graph.Models.WorkbookComment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "functions", n => { Functions = n.GetObjectValue<global::Microsoft.Graph.Models.WorkbookFunctions>(global::Microsoft.Graph.Models.WorkbookFunctions.CreateFromDiscriminatorValue); } },
                { "names", n => { Names = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.WorkbookNamedItem>(global::Microsoft.Graph.Models.WorkbookNamedItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "operations", n => { Operations = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.WorkbookOperation>(global::Microsoft.Graph.Models.WorkbookOperation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "tables", n => { Tables = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.WorkbookTable>(global::Microsoft.Graph.Models.WorkbookTable.CreateFromDiscriminatorValue)?.AsList(); } },
                { "worksheets", n => { Worksheets = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.WorkbookWorksheet>(global::Microsoft.Graph.Models.WorkbookWorksheet.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.WorkbookApplication>("application", Application);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.WorkbookComment>("comments", Comments);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.WorkbookFunctions>("functions", Functions);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.WorkbookNamedItem>("names", Names);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.WorkbookOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.WorkbookTable>("tables", Tables);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.WorkbookWorksheet>("worksheets", Worksheets);
        }
    }
}
