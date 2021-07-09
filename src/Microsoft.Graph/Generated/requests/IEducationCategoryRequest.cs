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
    /// The interface IEducationCategoryRequest.
    /// </summary>
    public partial interface IEducationCategoryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EducationCategory using POST.
        /// </summary>
        /// <param name="educationCategoryToCreate">The EducationCategory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EducationCategory.</returns>
        System.Threading.Tasks.Task<EducationCategory> CreateAsync(EducationCategory educationCategoryToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified EducationCategory using POST and returns a <see cref="GraphResponse{EducationCategory}"/> object.
        /// </summary>
        /// <param name="educationCategoryToCreate">The EducationCategory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationCategory}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationCategory>> CreateResponseAsync(EducationCategory educationCategoryToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified EducationCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified EducationCategory and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified EducationCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EducationCategory.</returns>
        System.Threading.Tasks.Task<EducationCategory> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified EducationCategory and returns a <see cref="GraphResponse{EducationCategory}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationCategory}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationCategory>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified EducationCategory using PATCH.
        /// </summary>
        /// <param name="educationCategoryToUpdate">The EducationCategory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EducationCategory.</returns>
        System.Threading.Tasks.Task<EducationCategory> UpdateAsync(EducationCategory educationCategoryToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified EducationCategory using PATCH and returns a <see cref="GraphResponse{EducationCategory}"/> object.
        /// </summary>
        /// <param name="educationCategoryToUpdate">The EducationCategory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EducationCategory}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationCategory>> UpdateResponseAsync(EducationCategory educationCategoryToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified EducationCategory using PUT.
        /// </summary>
        /// <param name="educationCategoryToUpdate">The EducationCategory object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<EducationCategory> PutAsync(EducationCategory educationCategoryToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified EducationCategory using PUT and returns a <see cref="GraphResponse{EducationCategory}"/> object.
        /// </summary>
        /// <param name="educationCategoryToUpdate">The EducationCategory object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{EducationCategory}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationCategory>> PutResponseAsync(EducationCategory educationCategoryToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationCategoryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationCategoryRequest Expand(Expression<Func<EducationCategory, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationCategoryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationCategoryRequest Select(Expression<Func<EducationCategory, object>> selectExpression);

    }
}