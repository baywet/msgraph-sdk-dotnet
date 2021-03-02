// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Microsoft Authenticator Authentication Method Target.
    /// </summary>
    public partial class MicrosoftAuthenticatorAuthenticationMethodTarget : AuthenticationMethodTarget
    {
    
		///<summary>
		/// The MicrosoftAuthenticatorAuthenticationMethodTarget constructor
		///</summary>
        public MicrosoftAuthenticatorAuthenticationMethodTarget()
        {
            this.ODataType = "microsoft.graph.microsoftAuthenticatorAuthenticationMethodTarget";
        }
	
        /// <summary>
        /// Gets or sets authentication mode.
        /// </summary>
        [JsonPropertyName("authenticationMode")]
        public MicrosoftAuthenticatorAuthenticationMode? AuthenticationMode { get; set; }
    
        /// <summary>
        /// Gets or sets feature settings.
        /// </summary>
        [JsonPropertyName("featureSettings")]
        public AuthenticatorAppFeatureSettings? FeatureSettings { get; set; }
    
    }
}
