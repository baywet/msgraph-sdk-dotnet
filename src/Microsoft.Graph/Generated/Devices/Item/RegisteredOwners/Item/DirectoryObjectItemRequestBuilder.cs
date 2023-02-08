using Microsoft.Graph.Devices.Item.RegisteredOwners.Item.MicrosoftGraphAppRoleAssignment;
using Microsoft.Graph.Devices.Item.RegisteredOwners.Item.MicrosoftGraphEndpoint;
using Microsoft.Graph.Devices.Item.RegisteredOwners.Item.MicrosoftGraphServicePrincipal;
using Microsoft.Graph.Devices.Item.RegisteredOwners.Item.MicrosoftGraphUser;
using Microsoft.Graph.Devices.Item.RegisteredOwners.Item.Ref;
using Microsoft.Kiota.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace Microsoft.Graph.Devices.Item.RegisteredOwners.Item {
    /// <summary>
    /// Builds and executes requests for operations under \devices\{device-id}\registeredOwners\{directoryObject-id}
    /// </summary>
    public class DirectoryObjectItemRequestBuilder {
        /// <summary>Casts the previous resource to appRoleAssignment.</summary>
        public MicrosoftGraphAppRoleAssignmentRequestBuilder MicrosoftGraphAppRoleAssignment { get =>
            new MicrosoftGraphAppRoleAssignmentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to endpoint.</summary>
        public MicrosoftGraphEndpointRequestBuilder MicrosoftGraphEndpoint { get =>
            new MicrosoftGraphEndpointRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to servicePrincipal.</summary>
        public MicrosoftGraphServicePrincipalRequestBuilder MicrosoftGraphServicePrincipal { get =>
            new MicrosoftGraphServicePrincipalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to user.</summary>
        public MicrosoftGraphUserRequestBuilder MicrosoftGraphUser { get =>
            new MicrosoftGraphUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Provides operations to manage the collection of device entities.</summary>
        public RefRequestBuilder Ref { get =>
            new RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new DirectoryObjectItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectoryObjectItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/devices/{device%2Did}/registeredOwners/{directoryObject%2Did}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new DirectoryObjectItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectoryObjectItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/devices/{device%2Did}/registeredOwners/{directoryObject%2Did}";
            var urlTplParams = new Dictionary<string, object>();
            if (!string.IsNullOrWhiteSpace(rawUrl)) urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
    }
}