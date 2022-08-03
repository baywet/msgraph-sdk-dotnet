// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.TermStore
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type LocalizedLabel.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<LocalizedLabel>))]
    public partial class LocalizedLabel
    {

        /// <summary>
        /// Gets or sets isDefault.
        /// Indicates whether the label is the default label.
        /// </summary>
        [JsonPropertyName("isDefault")]
        public bool? IsDefault { get; set; }
    
        /// <summary>
        /// Gets or sets languageTag.
        /// The language tag for the label.
        /// </summary>
        [JsonPropertyName("languageTag")]
        public string LanguageTag { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// The name of the label.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}