// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface ISourceCollectionRequestBuilder.
    /// </summary>
    public partial interface ISourceCollectionRequestBuilder : Microsoft.Graph.IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new ISourceCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new ISourceCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options);
    
        /// <summary>
        /// Gets the request builder for AdditionalSources.
        /// </summary>
        /// <returns>The <see cref="ISourceCollectionAdditionalSourcesCollectionRequestBuilder"/>.</returns>
        ISourceCollectionAdditionalSourcesCollectionRequestBuilder AdditionalSources { get; }

        /// <summary>
        /// Gets the request builder for CustodianSources.
        /// </summary>
        /// <returns>The <see cref="ISourceCollectionCustodianSourcesCollectionWithReferencesRequestBuilder"/>.</returns>
        ISourceCollectionCustodianSourcesCollectionWithReferencesRequestBuilder CustodianSources { get; }

        /// <summary>
        /// Gets the request builder for LastEstimateStatisticsOperation.
        /// </summary>
        /// <returns>The <see cref="IEstimateStatisticsOperationWithReferenceRequestBuilder"/>.</returns>
        IEstimateStatisticsOperationWithReferenceRequestBuilder LastEstimateStatisticsOperation { get; }

        /// <summary>
        /// Gets the request builder for NoncustodialSources.
        /// </summary>
        /// <returns>The <see cref="ISourceCollectionNoncustodialSourcesCollectionWithReferencesRequestBuilder"/>.</returns>
        ISourceCollectionNoncustodialSourcesCollectionWithReferencesRequestBuilder NoncustodialSources { get; }
    
        /// <summary>
        /// Gets the request builder for SourceCollectionEstimateStatistics.
        /// </summary>
        /// <returns>The <see cref="ISourceCollectionEstimateStatisticsRequestBuilder"/>.</returns>
        ISourceCollectionEstimateStatisticsRequestBuilder EstimateStatistics();
    
    }
}
