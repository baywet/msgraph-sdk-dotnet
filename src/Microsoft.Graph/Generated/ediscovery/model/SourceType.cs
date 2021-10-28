// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph.Ediscovery
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum SourceType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
	[System.Flags]
    public enum SourceType
    {
    
        /// <summary>
        /// Mailbox
        /// </summary>
        Mailbox = 1,
	
        /// <summary>
        /// Site
        /// </summary>
        Site = 2,
	
    }
}
