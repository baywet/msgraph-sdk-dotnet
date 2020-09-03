// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IWorkbookTableColumnsCollectionRequestBuilder.
    /// </summary>
    public partial interface IWorkbookTableColumnsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IWorkbookTableColumnsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IWorkbookTableColumnsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IWorkbookTableColumnRequestBuilder"/> for the specified WorkbookTableColumn.
        /// </summary>
        /// <param name="id">The ID for the WorkbookTableColumn.</param>
        /// <returns>The <see cref="IWorkbookTableColumnRequestBuilder"/>.</returns>
        IWorkbookTableColumnRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for WorkbookTableColumnAdd.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableColumnAddRequestBuilder"/>.</returns>
        IWorkbookTableColumnAddRequestBuilder Add(
            Int32? index = null,
            Newtonsoft.Json.Linq.JToken values = null,
            string name = null);

        /// <summary>
        /// Gets the request builder for WorkbookTableColumnCount.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableColumnCountRequestBuilder"/>.</returns>
        IWorkbookTableColumnCountRequestBuilder Count();

        /// <summary>
        /// Gets the request builder for WorkbookTableColumnItemAt.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableColumnItemAtRequestBuilder"/>.</returns>
        IWorkbookTableColumnItemAtRequestBuilder ItemAt(
            Int32 index);
    }
}
