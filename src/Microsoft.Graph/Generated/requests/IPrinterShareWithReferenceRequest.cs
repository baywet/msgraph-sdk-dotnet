// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IPrinterShareWithReferenceRequest.
    /// </summary>
    public partial interface IPrinterShareWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified PrinterShare.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PrinterShare.</returns>
        System.Threading.Tasks.Task<PrinterShare> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified PrinterShare and returns a <see cref="GraphResponse{PrinterShare}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PrinterShare}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrinterShare>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Creates the specified PrinterShare using POST.
        /// </summary>
        /// <param name="printerShareToCreate">The PrinterShare to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PrinterShare.</returns>
        System.Threading.Tasks.Task<PrinterShare> CreateAsync(PrinterShare printerShareToCreate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Creates the specified PrinterShare using POST and returns a <see cref="GraphResponse{PrinterShare}"/> object.
        /// </summary>
        /// <param name="printerShareToCreate">The PrinterShare to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PrinterShare}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrinterShare>> CreateResponseAsync(PrinterShare printerShareToCreate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Updates the specified PrinterShare using PATCH.
        /// </summary>
        /// <param name="printerShareToUpdate">The PrinterShare to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PrinterShare.</returns>
        System.Threading.Tasks.Task<PrinterShare> UpdateAsync(PrinterShare printerShareToUpdate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Updates the specified PrinterShare using PATCH and returns a <see cref="GraphResponse{PrinterShare}"/> object.
        /// </summary>
        /// <param name="printerShareToUpdate">The PrinterShare to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PrinterShare}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrinterShare>> UpdateResponseAsync(PrinterShare printerShareToUpdate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Deletes the specified PrinterShare.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Deletes the specified PrinterShare and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrinterShareWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrinterShareWithReferenceRequest Expand(Expression<Func<PrinterShare, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPrinterShareWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPrinterShareWithReferenceRequest Select(Expression<Func<PrinterShare, object>> selectExpression);

    }
}