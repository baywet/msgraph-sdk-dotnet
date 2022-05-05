// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ReportRootGetUserArchivedPrintJobsRequestBuilder.
    /// </summary>
    public partial class ReportRootGetUserArchivedPrintJobsRequestBuilder : BaseFunctionMethodRequestBuilder<IReportRootGetUserArchivedPrintJobsRequest>, IReportRootGetUserArchivedPrintJobsRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="ReportRootGetUserArchivedPrintJobsRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="userId">A userId parameter for the OData method call.</param>
        /// <param name="startDateTime">A startDateTime parameter for the OData method call.</param>
        /// <param name="endDateTime">A endDateTime parameter for the OData method call.</param>
        public ReportRootGetUserArchivedPrintJobsRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string userId,
            DateTimeOffset? startDateTime,
            DateTimeOffset? endDateTime)
            : base(requestUrl, client)
        {
            this.SetParameter("userId", userId, false);
            this.SetParameter("startDateTime", startDateTime, true);
            this.SetParameter("endDateTime", endDateTime, true);
            this.SetFunctionParameters();
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IReportRootGetUserArchivedPrintJobsRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new ReportRootGetUserArchivedPrintJobsRequest(functionUrl, this.Client, options);

            return request;
        }
    }
}