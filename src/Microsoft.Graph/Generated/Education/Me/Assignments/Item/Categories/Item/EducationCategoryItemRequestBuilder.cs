// <auto-generated/>
using Microsoft.Graph.Education.Me.Assignments.Item.Categories.Item.Ref;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Microsoft.Graph.Education.Me.Assignments.Item.Categories.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \education\me\assignments\{educationAssignment-id}\categories\{educationCategory-id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class EducationCategoryItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the collection of educationRoot entities.</summary>
        public global::Microsoft.Graph.Education.Me.Assignments.Item.Categories.Item.Ref.RefRequestBuilder Ref
        {
            get => new global::Microsoft.Graph.Education.Me.Assignments.Item.Categories.Item.Ref.RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Education.Me.Assignments.Item.Categories.Item.EducationCategoryItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EducationCategoryItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/education/me/assignments/{educationAssignment%2Did}/categories/{educationCategory%2Did}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Education.Me.Assignments.Item.Categories.Item.EducationCategoryItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EducationCategoryItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/education/me/assignments/{educationAssignment%2Did}/categories/{educationCategory%2Did}", rawUrl)
        {
        }
    }
}
