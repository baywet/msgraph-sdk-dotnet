// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookChartSeriesFormatRequestBuilder.
    /// </summary>
    public partial class WorkbookChartSeriesFormatRequestBuilder : EntityRequestBuilder, IWorkbookChartSeriesFormatRequestBuilder
    {

        /// <summary>
        /// Constructs a new WorkbookChartSeriesFormatRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WorkbookChartSeriesFormatRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IWorkbookChartSeriesFormatRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IWorkbookChartSeriesFormatRequest Request(IEnumerable<Option> options)
        {
            return new WorkbookChartSeriesFormatRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Fill.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartFillRequestBuilder"/>.</returns>
        public IWorkbookChartFillRequestBuilder Fill
        {
            get
            {
                return new WorkbookChartFillRequestBuilder(this.AppendSegmentToRequestUrl("fill"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Line.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartLineFormatRequestBuilder"/>.</returns>
        public IWorkbookChartLineFormatRequestBuilder Line
        {
            get
            {
                return new WorkbookChartLineFormatRequestBuilder(this.AppendSegmentToRequestUrl("line"), this.Client);
            }
        }
    
    }
}