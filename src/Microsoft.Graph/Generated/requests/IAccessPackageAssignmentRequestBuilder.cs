// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IAccessPackageAssignmentRequestBuilder.
    /// </summary>
    public partial interface IAccessPackageAssignmentRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IAccessPackageAssignmentRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IAccessPackageAssignmentRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for AccessPackage.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageWithReferenceRequestBuilder"/>.</returns>
        IAccessPackageWithReferenceRequestBuilder AccessPackage { get; }

        /// <summary>
        /// Gets the request builder for AssignmentPolicy.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageAssignmentPolicyWithReferenceRequestBuilder"/>.</returns>
        IAccessPackageAssignmentPolicyWithReferenceRequestBuilder AssignmentPolicy { get; }

        /// <summary>
        /// Gets the request builder for Target.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageSubjectWithReferenceRequestBuilder"/>.</returns>
        IAccessPackageSubjectWithReferenceRequestBuilder Target { get; }
    
        /// <summary>
        /// Gets the request builder for AccessPackageAssignmentReprocess.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageAssignmentReprocessRequestBuilder"/>.</returns>
        IAccessPackageAssignmentReprocessRequestBuilder Reprocess();
    
    }
}