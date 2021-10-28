// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface INoncustodialDataSourceRequest.
    /// </summary>
    public partial interface INoncustodialDataSourceRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified NoncustodialDataSource using POST.
        /// </summary>
        /// <param name="noncustodialDataSourceToCreate">The NoncustodialDataSource to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created NoncustodialDataSource.</returns>
        System.Threading.Tasks.Task<NoncustodialDataSource> CreateAsync(NoncustodialDataSource noncustodialDataSourceToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified NoncustodialDataSource using POST and returns a <see cref="GraphResponse{NoncustodialDataSource}"/> object.
        /// </summary>
        /// <param name="noncustodialDataSourceToCreate">The NoncustodialDataSource to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{NoncustodialDataSource}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<NoncustodialDataSource>> CreateResponseAsync(NoncustodialDataSource noncustodialDataSourceToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified NoncustodialDataSource.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified NoncustodialDataSource and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified NoncustodialDataSource.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The NoncustodialDataSource.</returns>
        System.Threading.Tasks.Task<NoncustodialDataSource> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified NoncustodialDataSource and returns a <see cref="GraphResponse{NoncustodialDataSource}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{NoncustodialDataSource}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<NoncustodialDataSource>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified NoncustodialDataSource using PATCH.
        /// </summary>
        /// <param name="noncustodialDataSourceToUpdate">The NoncustodialDataSource to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated NoncustodialDataSource.</returns>
        System.Threading.Tasks.Task<NoncustodialDataSource> UpdateAsync(NoncustodialDataSource noncustodialDataSourceToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified NoncustodialDataSource using PATCH and returns a <see cref="GraphResponse{NoncustodialDataSource}"/> object.
        /// </summary>
        /// <param name="noncustodialDataSourceToUpdate">The NoncustodialDataSource to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{NoncustodialDataSource}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<NoncustodialDataSource>> UpdateResponseAsync(NoncustodialDataSource noncustodialDataSourceToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified NoncustodialDataSource using PUT.
        /// </summary>
        /// <param name="noncustodialDataSourceToUpdate">The NoncustodialDataSource object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<NoncustodialDataSource> PutAsync(NoncustodialDataSource noncustodialDataSourceToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified NoncustodialDataSource using PUT and returns a <see cref="GraphResponse{NoncustodialDataSource}"/> object.
        /// </summary>
        /// <param name="noncustodialDataSourceToUpdate">The NoncustodialDataSource object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{NoncustodialDataSource}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<NoncustodialDataSource>> PutResponseAsync(NoncustodialDataSource noncustodialDataSourceToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        INoncustodialDataSourceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        INoncustodialDataSourceRequest Expand(Expression<Func<NoncustodialDataSource, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        INoncustodialDataSourceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        INoncustodialDataSourceRequest Select(Expression<Func<NoncustodialDataSource, object>> selectExpression);

    }
}
