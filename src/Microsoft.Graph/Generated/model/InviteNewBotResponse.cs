// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type InviteNewBotResponse.
    /// </summary>
    public partial class InviteNewBotResponse : ParticipantJoiningResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InviteNewBotResponse"/> class.
        /// </summary>
        public InviteNewBotResponse()
        {
            this.ODataType = "microsoft.graph.inviteNewBotResponse";
        }

        /// <summary>
        /// Gets or sets inviteUri.
        /// URI to receive new incoming call notification.
        /// </summary>
        [JsonPropertyName("inviteUri")]
        public string InviteUri { get; set; }
    
    }
}