// <auto-generated/>
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.Axes;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.DataLabels;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.Format;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.Image;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.ImageWithWidth;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.ImageWithWidthWithHeight;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.ImageWithWidthWithHeightWithFittingMode;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.Legend;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.Series;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.SetData;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.SetPosition;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.Title;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.Worksheet;
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex
{
    /// <summary>
    /// Provides operations to call the itemAt method.
    /// </summary>
    public class ItemAtWithIndexRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the axes property of the microsoft.graph.workbookChart entity.</summary>
        public Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.Axes.AxesRequestBuilder Axes
        {
            get => new Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.Axes.AxesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the dataLabels property of the microsoft.graph.workbookChart entity.</summary>
        public Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.DataLabels.DataLabelsRequestBuilder DataLabels
        {
            get => new Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.DataLabels.DataLabelsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the format property of the microsoft.graph.workbookChart entity.</summary>
        public Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.Format.FormatRequestBuilder Format
        {
            get => new Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.Format.FormatRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the image method.</summary>
        public Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.Image.ImageRequestBuilder Image
        {
            get => new Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.Image.ImageRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the legend property of the microsoft.graph.workbookChart entity.</summary>
        public Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.Legend.LegendRequestBuilder Legend
        {
            get => new Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.Legend.LegendRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the series property of the microsoft.graph.workbookChart entity.</summary>
        public Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.Series.SeriesRequestBuilder Series
        {
            get => new Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.Series.SeriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the setData method.</summary>
        public Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.SetData.SetDataRequestBuilder SetData
        {
            get => new Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.SetData.SetDataRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the setPosition method.</summary>
        public Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.SetPosition.SetPositionRequestBuilder SetPosition
        {
            get => new Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.SetPosition.SetPositionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the title property of the microsoft.graph.workbookChart entity.</summary>
        public Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.Title.TitleRequestBuilder Title
        {
            get => new Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.Title.TitleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the worksheet property of the microsoft.graph.workbookChart entity.</summary>
        public Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.Worksheet.WorksheetRequestBuilder Worksheet
        {
            get => new Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.Worksheet.WorksheetRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.ItemAtWithIndexRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="index">Usage: index={index}</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ItemAtWithIndexRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, int? index = default) : base(requestAdapter, "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/charts/itemAt(index={index})", pathParameters)
        {
            if (index != null) PathParameters.Add("index", index);
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.ItemAtWithIndexRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ItemAtWithIndexRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/charts/itemAt(index={index})", rawUrl)
        {
        }
        /// <summary>
        /// Gets a chart based on its position in the collection.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/chartcollection-itemat?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.WorkbookChart"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Models.WorkbookChart?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Models.WorkbookChart> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Models.WorkbookChart>(requestInfo, Microsoft.Graph.Models.WorkbookChart.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides operations to call the image method.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.ImageWithWidth.ImageWithWidthRequestBuilder"/></returns>
        /// <param name="width">Usage: width={width}</param>
        public Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.ImageWithWidth.ImageWithWidthRequestBuilder ImageWithWidth(int? width)
        {
            _ = width ?? throw new ArgumentNullException(nameof(width));
            return new Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.ImageWithWidth.ImageWithWidthRequestBuilder(PathParameters, RequestAdapter, width);
        }
        /// <summary>
        /// Provides operations to call the image method.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.ImageWithWidthWithHeight.ImageWithWidthWithHeightRequestBuilder"/></returns>
        /// <param name="height">Usage: height={height}</param>
        /// <param name="width">Usage: width={width}</param>
        public Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.ImageWithWidthWithHeight.ImageWithWidthWithHeightRequestBuilder ImageWithWidthWithHeight(int? height, int? width)
        {
            _ = height ?? throw new ArgumentNullException(nameof(height));
            _ = width ?? throw new ArgumentNullException(nameof(width));
            return new Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.ImageWithWidthWithHeight.ImageWithWidthWithHeightRequestBuilder(PathParameters, RequestAdapter, height, width);
        }
        /// <summary>
        /// Provides operations to call the image method.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.ImageWithWidthWithHeightWithFittingMode.ImageWithWidthWithHeightWithFittingModeRequestBuilder"/></returns>
        /// <param name="fittingMode">Usage: fittingMode=&apos;{fittingMode}&apos;</param>
        /// <param name="height">Usage: height={height}</param>
        /// <param name="width">Usage: width={width}</param>
        public Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.ImageWithWidthWithHeightWithFittingMode.ImageWithWidthWithHeightWithFittingModeRequestBuilder ImageWithWidthWithHeightWithFittingMode(string fittingMode, int? height, int? width)
        {
            if(string.IsNullOrEmpty(fittingMode)) throw new ArgumentNullException(nameof(fittingMode));
            _ = height ?? throw new ArgumentNullException(nameof(height));
            _ = width ?? throw new ArgumentNullException(nameof(width));
            return new Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.ImageWithWidthWithHeightWithFittingMode.ImageWithWidthWithHeightWithFittingModeRequestBuilder(PathParameters, RequestAdapter, fittingMode, height, width);
        }
        /// <summary>
        /// Gets a chart based on its position in the collection.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.ItemAtWithIndexRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.ItemAtWithIndexRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemAtWithIndex.ItemAtWithIndexRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ItemAtWithIndexRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
