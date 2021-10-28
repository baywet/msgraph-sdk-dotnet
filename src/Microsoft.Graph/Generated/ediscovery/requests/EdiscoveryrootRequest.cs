// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type EdiscoveryrootRequest.
    /// </summary>
    public partial class EdiscoveryrootRequest : Microsoft.Graph.BaseRequest, IEdiscoveryrootRequest
    {
        /// <summary>
        /// Constructs a new EdiscoveryrootRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public EdiscoveryrootRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Ediscoveryroot using POST.
        /// </summary>
        /// <param name="ediscoveryrootToCreate">The Ediscoveryroot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Ediscoveryroot.</returns>
        public async System.Threading.Tasks.Task<Ediscoveryroot> CreateAsync(Ediscoveryroot ediscoveryrootToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<Ediscoveryroot>(ediscoveryrootToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Ediscoveryroot using POST and returns a <see cref="GraphResponse{Ediscoveryroot}"/> object.
        /// </summary>
        /// <param name="ediscoveryrootToCreate">The Ediscoveryroot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Ediscoveryroot}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Ediscoveryroot>> CreateResponseAsync(Ediscoveryroot ediscoveryrootToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<Ediscoveryroot>(ediscoveryrootToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified Ediscoveryroot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<Ediscoveryroot>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Ediscoveryroot and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified Ediscoveryroot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Ediscoveryroot.</returns>
        public async System.Threading.Tasks.Task<Ediscoveryroot> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<Ediscoveryroot>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Ediscoveryroot and returns a <see cref="GraphResponse{Ediscoveryroot}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Ediscoveryroot}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Ediscoveryroot>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<Ediscoveryroot>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Ediscoveryroot using PATCH.
        /// </summary>
        /// <param name="ediscoveryrootToUpdate">The Ediscoveryroot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Ediscoveryroot.</returns>
        public async System.Threading.Tasks.Task<Ediscoveryroot> UpdateAsync(Ediscoveryroot ediscoveryrootToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<Ediscoveryroot>(ediscoveryrootToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Ediscoveryroot using PATCH and returns a <see cref="GraphResponse{Ediscoveryroot}"/> object.
        /// </summary>
        /// <param name="ediscoveryrootToUpdate">The Ediscoveryroot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Ediscoveryroot}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Ediscoveryroot>> UpdateResponseAsync(Ediscoveryroot ediscoveryrootToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<Ediscoveryroot>(ediscoveryrootToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Ediscoveryroot using PUT.
        /// </summary>
        /// <param name="ediscoveryrootToUpdate">The Ediscoveryroot object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<Ediscoveryroot> PutAsync(Ediscoveryroot ediscoveryrootToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<Ediscoveryroot>(ediscoveryrootToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Ediscoveryroot using PUT and returns a <see cref="GraphResponse{Ediscoveryroot}"/> object.
        /// </summary>
        /// <param name="ediscoveryrootToUpdate">The Ediscoveryroot object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{Ediscoveryroot}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Ediscoveryroot>> PutResponseAsync(Ediscoveryroot ediscoveryrootToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<Ediscoveryroot>(ediscoveryrootToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoveryrootRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoveryrootRequest Expand(Expression<Func<Ediscoveryroot, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoveryrootRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoveryrootRequest Select(Expression<Func<Ediscoveryroot, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="ediscoveryrootToInitialize">The <see cref="Ediscoveryroot"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Ediscoveryroot ediscoveryrootToInitialize)
        {

            if (ediscoveryrootToInitialize != null)
            {
                if (ediscoveryrootToInitialize.Cases != null && ediscoveryrootToInitialize.Cases.CurrentPage != null)
                {
                    ediscoveryrootToInitialize.Cases.InitializeNextPageRequest(this.Client, ediscoveryrootToInitialize.CasesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    ediscoveryrootToInitialize.Cases.AdditionalData = ediscoveryrootToInitialize.AdditionalData;
                }

            }


        }
    }
}
