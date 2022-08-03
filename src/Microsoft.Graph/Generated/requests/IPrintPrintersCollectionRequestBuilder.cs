// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IPrintPrintersCollectionRequestBuilder.
    /// </summary>
    public partial interface IPrintPrintersCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IPrintPrintersCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IPrintPrintersCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IPrinterRequestBuilder"/> for the specified Printer.
        /// </summary>
        /// <param name="id">The ID for the Printer.</param>
        /// <returns>The <see cref="IPrinterRequestBuilder"/>.</returns>
        IPrinterRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for PrinterCreate.
        /// </summary>
        /// <returns>The <see cref="IPrinterCreateRequestBuilder"/>.</returns>
        IPrinterCreateRequestBuilder Create(
            string displayName,
            string manufacturer,
            string model,
            PrintCertificateSigningRequestObject certificateSigningRequest,
            string physicalDeviceId = null,
            bool? hasPhysicalDevice = null,
            string connectorId = null);
    }
}