// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IAgreementFilePropertiesRequest.
    /// </summary>
    public partial interface IAgreementFilePropertiesRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AgreementFileProperties using POST.
        /// </summary>
        /// <param name="agreementFilePropertiesToCreate">The AgreementFileProperties to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AgreementFileProperties.</returns>
        System.Threading.Tasks.Task<AgreementFileProperties> CreateAsync(AgreementFileProperties agreementFilePropertiesToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified AgreementFileProperties using POST and returns a <see cref="GraphResponse{AgreementFileProperties}"/> object.
        /// </summary>
        /// <param name="agreementFilePropertiesToCreate">The AgreementFileProperties to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AgreementFileProperties}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AgreementFileProperties>> CreateResponseAsync(AgreementFileProperties agreementFilePropertiesToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AgreementFileProperties.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AgreementFileProperties and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AgreementFileProperties.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AgreementFileProperties.</returns>
        System.Threading.Tasks.Task<AgreementFileProperties> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AgreementFileProperties and returns a <see cref="GraphResponse{AgreementFileProperties}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AgreementFileProperties}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AgreementFileProperties>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AgreementFileProperties using PATCH.
        /// </summary>
        /// <param name="agreementFilePropertiesToUpdate">The AgreementFileProperties to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AgreementFileProperties.</returns>
        System.Threading.Tasks.Task<AgreementFileProperties> UpdateAsync(AgreementFileProperties agreementFilePropertiesToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AgreementFileProperties using PATCH and returns a <see cref="GraphResponse{AgreementFileProperties}"/> object.
        /// </summary>
        /// <param name="agreementFilePropertiesToUpdate">The AgreementFileProperties to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AgreementFileProperties}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AgreementFileProperties>> UpdateResponseAsync(AgreementFileProperties agreementFilePropertiesToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAgreementFilePropertiesRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAgreementFilePropertiesRequest Expand(Expression<Func<AgreementFileProperties, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAgreementFilePropertiesRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAgreementFilePropertiesRequest Select(Expression<Func<AgreementFileProperties, object>> selectExpression);

    }
}