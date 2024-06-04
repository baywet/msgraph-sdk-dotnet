// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class WorkbookRangeFormat : Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Collection of border objects that apply to the overall range selected Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.WorkbookRangeBorder>? Borders
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.WorkbookRangeBorder>?>("borders"); }
            set { BackingStore?.Set("borders", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.WorkbookRangeBorder> Borders
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.WorkbookRangeBorder>>("borders"); }
            set { BackingStore?.Set("borders", value); }
        }
#endif
        /// <summary>Gets or sets the width of all columns within the range. If the column widths aren&apos;t uniform, null will be returned.</summary>
        public double? ColumnWidth
        {
            get { return BackingStore?.Get<double?>("columnWidth"); }
            set { BackingStore?.Set("columnWidth", value); }
        }
        /// <summary>Returns the fill object defined on the overall range. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.WorkbookRangeFill? Fill
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.WorkbookRangeFill?>("fill"); }
            set { BackingStore?.Set("fill", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.WorkbookRangeFill Fill
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.WorkbookRangeFill>("fill"); }
            set { BackingStore?.Set("fill", value); }
        }
#endif
        /// <summary>Returns the font object defined on the overall range selected Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.WorkbookRangeFont? Font
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.WorkbookRangeFont?>("font"); }
            set { BackingStore?.Set("font", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.WorkbookRangeFont Font
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.WorkbookRangeFont>("font"); }
            set { BackingStore?.Set("font", value); }
        }
#endif
        /// <summary>Represents the horizontal alignment for the specified object. The possible values are: General, Left, Center, Right, Fill, Justify, CenterAcrossSelection, Distributed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HorizontalAlignment
        {
            get { return BackingStore?.Get<string?>("horizontalAlignment"); }
            set { BackingStore?.Set("horizontalAlignment", value); }
        }
#nullable restore
#else
        public string HorizontalAlignment
        {
            get { return BackingStore?.Get<string>("horizontalAlignment"); }
            set { BackingStore?.Set("horizontalAlignment", value); }
        }
#endif
        /// <summary>Returns the format protection object for a range. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.WorkbookFormatProtection? Protection
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.WorkbookFormatProtection?>("protection"); }
            set { BackingStore?.Set("protection", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.WorkbookFormatProtection Protection
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.WorkbookFormatProtection>("protection"); }
            set { BackingStore?.Set("protection", value); }
        }
#endif
        /// <summary>Gets or sets the height of all rows in the range. If the row heights aren&apos;t uniform null will be returned.</summary>
        public double? RowHeight
        {
            get { return BackingStore?.Get<double?>("rowHeight"); }
            set { BackingStore?.Set("rowHeight", value); }
        }
        /// <summary>Represents the vertical alignment for the specified object. The possible values are: Top, Center, Bottom, Justify, Distributed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VerticalAlignment
        {
            get { return BackingStore?.Get<string?>("verticalAlignment"); }
            set { BackingStore?.Set("verticalAlignment", value); }
        }
#nullable restore
#else
        public string VerticalAlignment
        {
            get { return BackingStore?.Get<string>("verticalAlignment"); }
            set { BackingStore?.Set("verticalAlignment", value); }
        }
#endif
        /// <summary>Indicates if Excel wraps the text in the object. A null value indicates that the entire range doesn&apos;t have uniform wrap setting</summary>
        public bool? WrapText
        {
            get { return BackingStore?.Get<bool?>("wrapText"); }
            set { BackingStore?.Set("wrapText", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.WorkbookRangeFormat"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.WorkbookRangeFormat CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.WorkbookRangeFormat();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "borders", n => { Borders = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.WorkbookRangeBorder>(Microsoft.Graph.Models.WorkbookRangeBorder.CreateFromDiscriminatorValue)?.ToList(); } },
                { "columnWidth", n => { ColumnWidth = n.GetDoubleValue(); } },
                { "fill", n => { Fill = n.GetObjectValue<Microsoft.Graph.Models.WorkbookRangeFill>(Microsoft.Graph.Models.WorkbookRangeFill.CreateFromDiscriminatorValue); } },
                { "font", n => { Font = n.GetObjectValue<Microsoft.Graph.Models.WorkbookRangeFont>(Microsoft.Graph.Models.WorkbookRangeFont.CreateFromDiscriminatorValue); } },
                { "horizontalAlignment", n => { HorizontalAlignment = n.GetStringValue(); } },
                { "protection", n => { Protection = n.GetObjectValue<Microsoft.Graph.Models.WorkbookFormatProtection>(Microsoft.Graph.Models.WorkbookFormatProtection.CreateFromDiscriminatorValue); } },
                { "rowHeight", n => { RowHeight = n.GetDoubleValue(); } },
                { "verticalAlignment", n => { VerticalAlignment = n.GetStringValue(); } },
                { "wrapText", n => { WrapText = n.GetBoolValue(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.WorkbookRangeBorder>("borders", Borders);
            writer.WriteDoubleValue("columnWidth", ColumnWidth);
            writer.WriteObjectValue<Microsoft.Graph.Models.WorkbookRangeFill>("fill", Fill);
            writer.WriteObjectValue<Microsoft.Graph.Models.WorkbookRangeFont>("font", Font);
            writer.WriteStringValue("horizontalAlignment", HorizontalAlignment);
            writer.WriteObjectValue<Microsoft.Graph.Models.WorkbookFormatProtection>("protection", Protection);
            writer.WriteDoubleValue("rowHeight", RowHeight);
            writer.WriteStringValue("verticalAlignment", VerticalAlignment);
            writer.WriteBoolValue("wrapText", WrapText);
        }
    }
}
