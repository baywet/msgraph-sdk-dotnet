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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Conversation.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Conversation : Entity
    {
    
		///<summary>
		/// The Conversation constructor
		///</summary>
        public Conversation()
        {
            this.ODataType = "microsoft.graph.conversation";
        }
	
        /// <summary>
        /// Gets or sets has attachments.
        /// Indicates whether any of the posts within this Conversation has at least one attachment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hasAttachments", Required = Newtonsoft.Json.Required.Default)]
        public bool? HasAttachments { get; set; }
    
        /// <summary>
        /// Gets or sets last delivered date time.
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastDeliveredDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastDeliveredDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets preview.
        /// A short summary from the body of the latest post in this converstaion.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "preview", Required = Newtonsoft.Json.Required.Default)]
        public string Preview { get; set; }
    
        /// <summary>
        /// Gets or sets topic.
        /// The topic of the conversation. This property can be set when the conversation is created, but it cannot be updated.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "topic", Required = Newtonsoft.Json.Required.Default)]
        public string Topic { get; set; }
    
        /// <summary>
        /// Gets or sets unique senders.
        /// All the users that sent a message to this Conversation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "uniqueSenders", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> UniqueSenders { get; set; }
    
        /// <summary>
        /// Gets or sets threads.
        /// A collection of all the conversation threads in the conversation. A navigation property. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "threads", Required = Newtonsoft.Json.Required.Default)]
        public IConversationThreadsCollectionPage Threads { get; set; }
    
    }
}

