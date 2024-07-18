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
    public partial class WorkbookChart : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents chart axes. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.WorkbookChartAxes? Axes
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WorkbookChartAxes?>("axes"); }
            set { BackingStore?.Set("axes", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.WorkbookChartAxes Axes
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WorkbookChartAxes>("axes"); }
            set { BackingStore?.Set("axes", value); }
        }
#endif
        /// <summary>Represents the data labels on the chart. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.WorkbookChartDataLabels? DataLabels
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WorkbookChartDataLabels?>("dataLabels"); }
            set { BackingStore?.Set("dataLabels", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.WorkbookChartDataLabels DataLabels
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WorkbookChartDataLabels>("dataLabels"); }
            set { BackingStore?.Set("dataLabels", value); }
        }
#endif
        /// <summary>Encapsulates the format properties for the chart area. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.WorkbookChartAreaFormat? Format
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WorkbookChartAreaFormat?>("format"); }
            set { BackingStore?.Set("format", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.WorkbookChartAreaFormat Format
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WorkbookChartAreaFormat>("format"); }
            set { BackingStore?.Set("format", value); }
        }
#endif
        /// <summary>Represents the height, in points, of the chart object.</summary>
        public double? Height
        {
            get { return BackingStore?.Get<double?>("height"); }
            set { BackingStore?.Set("height", value); }
        }
        /// <summary>The distance, in points, from the left side of the chart to the worksheet origin.</summary>
        public double? Left
        {
            get { return BackingStore?.Get<double?>("left"); }
            set { BackingStore?.Set("left", value); }
        }
        /// <summary>Represents the legend for the chart. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.WorkbookChartLegend? Legend
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WorkbookChartLegend?>("legend"); }
            set { BackingStore?.Set("legend", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.WorkbookChartLegend Legend
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WorkbookChartLegend>("legend"); }
            set { BackingStore?.Set("legend", value); }
        }
#endif
        /// <summary>Represents the name of a chart object.</summary>
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
        /// <summary>Represents either a single series or collection of series in the chart. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.WorkbookChartSeries>? Series
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WorkbookChartSeries>?>("series"); }
            set { BackingStore?.Set("series", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.WorkbookChartSeries> Series
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WorkbookChartSeries>>("series"); }
            set { BackingStore?.Set("series", value); }
        }
#endif
        /// <summary>Represents the title of the specified chart, including the text, visibility, position and formatting of the title. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.WorkbookChartTitle? Title
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WorkbookChartTitle?>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.WorkbookChartTitle Title
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WorkbookChartTitle>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#endif
        /// <summary>Represents the distance, in points, from the top edge of the object to the top of row 1 (on a worksheet) or the top of the chart area (on a chart).</summary>
        public double? Top
        {
            get { return BackingStore?.Get<double?>("top"); }
            set { BackingStore?.Set("top", value); }
        }
        /// <summary>Represents the width, in points, of the chart object.</summary>
        public double? Width
        {
            get { return BackingStore?.Get<double?>("width"); }
            set { BackingStore?.Set("width", value); }
        }
        /// <summary>The worksheet containing the current chart. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.WorkbookWorksheet? Worksheet
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WorkbookWorksheet?>("worksheet"); }
            set { BackingStore?.Set("worksheet", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.WorkbookWorksheet Worksheet
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WorkbookWorksheet>("worksheet"); }
            set { BackingStore?.Set("worksheet", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.WorkbookChart"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.WorkbookChart CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.WorkbookChart();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "axes", n => { Axes = n.GetObjectValue<global::Microsoft.Graph.Models.WorkbookChartAxes>(global::Microsoft.Graph.Models.WorkbookChartAxes.CreateFromDiscriminatorValue); } },
                { "dataLabels", n => { DataLabels = n.GetObjectValue<global::Microsoft.Graph.Models.WorkbookChartDataLabels>(global::Microsoft.Graph.Models.WorkbookChartDataLabels.CreateFromDiscriminatorValue); } },
                { "format", n => { Format = n.GetObjectValue<global::Microsoft.Graph.Models.WorkbookChartAreaFormat>(global::Microsoft.Graph.Models.WorkbookChartAreaFormat.CreateFromDiscriminatorValue); } },
                { "height", n => { Height = n.GetDoubleValue(); } },
                { "left", n => { Left = n.GetDoubleValue(); } },
                { "legend", n => { Legend = n.GetObjectValue<global::Microsoft.Graph.Models.WorkbookChartLegend>(global::Microsoft.Graph.Models.WorkbookChartLegend.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "series", n => { Series = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.WorkbookChartSeries>(global::Microsoft.Graph.Models.WorkbookChartSeries.CreateFromDiscriminatorValue)?.AsList(); } },
                { "title", n => { Title = n.GetObjectValue<global::Microsoft.Graph.Models.WorkbookChartTitle>(global::Microsoft.Graph.Models.WorkbookChartTitle.CreateFromDiscriminatorValue); } },
                { "top", n => { Top = n.GetDoubleValue(); } },
                { "width", n => { Width = n.GetDoubleValue(); } },
                { "worksheet", n => { Worksheet = n.GetObjectValue<global::Microsoft.Graph.Models.WorkbookWorksheet>(global::Microsoft.Graph.Models.WorkbookWorksheet.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.WorkbookChartAxes>("axes", Axes);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.WorkbookChartDataLabels>("dataLabels", DataLabels);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.WorkbookChartAreaFormat>("format", Format);
            writer.WriteDoubleValue("height", Height);
            writer.WriteDoubleValue("left", Left);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.WorkbookChartLegend>("legend", Legend);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.WorkbookChartSeries>("series", Series);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.WorkbookChartTitle>("title", Title);
            writer.WriteDoubleValue("top", Top);
            writer.WriteDoubleValue("width", Width);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.WorkbookWorksheet>("worksheet", Worksheet);
        }
    }
}
