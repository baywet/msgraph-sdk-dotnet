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
    /// The interface IUnifiedRoleEligibilityScheduleRequestRequest.
    /// </summary>
    public partial interface IUnifiedRoleEligibilityScheduleRequestRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UnifiedRoleEligibilityScheduleRequestObject using POST.
        /// </summary>
        /// <param name="unifiedRoleEligibilityScheduleRequestObjectToCreate">The UnifiedRoleEligibilityScheduleRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnifiedRoleEligibilityScheduleRequestObject.</returns>
        System.Threading.Tasks.Task<UnifiedRoleEligibilityScheduleRequestObject> CreateAsync(UnifiedRoleEligibilityScheduleRequestObject unifiedRoleEligibilityScheduleRequestObjectToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified UnifiedRoleEligibilityScheduleRequestObject using POST and returns a <see cref="GraphResponse{UnifiedRoleEligibilityScheduleRequestObject}"/> object.
        /// </summary>
        /// <param name="unifiedRoleEligibilityScheduleRequestObjectToCreate">The UnifiedRoleEligibilityScheduleRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleEligibilityScheduleRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleEligibilityScheduleRequestObject>> CreateResponseAsync(UnifiedRoleEligibilityScheduleRequestObject unifiedRoleEligibilityScheduleRequestObjectToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified UnifiedRoleEligibilityScheduleRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified UnifiedRoleEligibilityScheduleRequestObject and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified UnifiedRoleEligibilityScheduleRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UnifiedRoleEligibilityScheduleRequestObject.</returns>
        System.Threading.Tasks.Task<UnifiedRoleEligibilityScheduleRequestObject> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified UnifiedRoleEligibilityScheduleRequestObject and returns a <see cref="GraphResponse{UnifiedRoleEligibilityScheduleRequestObject}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleEligibilityScheduleRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleEligibilityScheduleRequestObject>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UnifiedRoleEligibilityScheduleRequestObject using PATCH.
        /// </summary>
        /// <param name="unifiedRoleEligibilityScheduleRequestObjectToUpdate">The UnifiedRoleEligibilityScheduleRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UnifiedRoleEligibilityScheduleRequestObject.</returns>
        System.Threading.Tasks.Task<UnifiedRoleEligibilityScheduleRequestObject> UpdateAsync(UnifiedRoleEligibilityScheduleRequestObject unifiedRoleEligibilityScheduleRequestObjectToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UnifiedRoleEligibilityScheduleRequestObject using PATCH and returns a <see cref="GraphResponse{UnifiedRoleEligibilityScheduleRequestObject}"/> object.
        /// </summary>
        /// <param name="unifiedRoleEligibilityScheduleRequestObjectToUpdate">The UnifiedRoleEligibilityScheduleRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleEligibilityScheduleRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleEligibilityScheduleRequestObject>> UpdateResponseAsync(UnifiedRoleEligibilityScheduleRequestObject unifiedRoleEligibilityScheduleRequestObjectToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UnifiedRoleEligibilityScheduleRequestObject using PUT.
        /// </summary>
        /// <param name="unifiedRoleEligibilityScheduleRequestObjectToUpdate">The UnifiedRoleEligibilityScheduleRequestObject object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<UnifiedRoleEligibilityScheduleRequestObject> PutAsync(UnifiedRoleEligibilityScheduleRequestObject unifiedRoleEligibilityScheduleRequestObjectToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UnifiedRoleEligibilityScheduleRequestObject using PUT and returns a <see cref="GraphResponse{UnifiedRoleEligibilityScheduleRequestObject}"/> object.
        /// </summary>
        /// <param name="unifiedRoleEligibilityScheduleRequestObjectToUpdate">The UnifiedRoleEligibilityScheduleRequestObject object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{UnifiedRoleEligibilityScheduleRequestObject}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleEligibilityScheduleRequestObject>> PutResponseAsync(UnifiedRoleEligibilityScheduleRequestObject unifiedRoleEligibilityScheduleRequestObjectToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleEligibilityScheduleRequestRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleEligibilityScheduleRequestRequest Expand(Expression<Func<UnifiedRoleEligibilityScheduleRequestObject, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleEligibilityScheduleRequestRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleEligibilityScheduleRequestRequest Select(Expression<Func<UnifiedRoleEligibilityScheduleRequestObject, object>> selectExpression);

    }
}