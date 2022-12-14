// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph.SecurityNamespace
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum DeviceHealthStatus.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DeviceHealthStatus
    {
    
        /// <summary>
        /// Active
        /// </summary>
        Active = 0,
	
        /// <summary>
        /// Inactive
        /// </summary>
        Inactive = 1,
	
        /// <summary>
        /// Impaired Communication
        /// </summary>
        ImpairedCommunication = 2,
	
        /// <summary>
        /// No Sensor Data
        /// </summary>
        NoSensorData = 3,
	
        /// <summary>
        /// No Sensor Data Impaired Communication
        /// </summary>
        NoSensorDataImpairedCommunication = 4,
	
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 5,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 31,
	
    }
}
