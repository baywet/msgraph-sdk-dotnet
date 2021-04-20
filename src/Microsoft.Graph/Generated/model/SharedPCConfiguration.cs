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
    /// The type Shared PCConfiguration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SharedPCConfiguration : DeviceConfiguration
    {
    
		///<summary>
		/// The SharedPCConfiguration constructor
		///</summary>
        public SharedPCConfiguration()
        {
            this.ODataType = "microsoft.graph.sharedPCConfiguration";
        }
	
        /// <summary>
        /// Gets or sets account manager policy.
        /// Specifies how accounts are managed on a shared PC. Only applies when disableAccountManager is false.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accountManagerPolicy", Required = Newtonsoft.Json.Required.Default)]
        public SharedPCAccountManagerPolicy AccountManagerPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets allowed accounts.
        /// Indicates which type of accounts are allowed to use on a shared PC. Possible values are: notConfigured, guest, domain.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowedAccounts", Required = Newtonsoft.Json.Required.Default)]
        public SharedPCAllowedAccountType? AllowedAccounts { get; set; }
    
        /// <summary>
        /// Gets or sets allow local storage.
        /// Specifies whether local storage is allowed on a shared PC.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowLocalStorage", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowLocalStorage { get; set; }
    
        /// <summary>
        /// Gets or sets disable account manager.
        /// Disables the account manager for shared PC mode.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "disableAccountManager", Required = Newtonsoft.Json.Required.Default)]
        public bool? DisableAccountManager { get; set; }
    
        /// <summary>
        /// Gets or sets disable edu policies.
        /// Specifies whether the default shared PC education environment policies should be disabled. For Windows 10 RS2 and later, this policy will be applied without setting Enabled to true.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "disableEduPolicies", Required = Newtonsoft.Json.Required.Default)]
        public bool? DisableEduPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets disable power policies.
        /// Specifies whether the default shared PC power policies should be disabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "disablePowerPolicies", Required = Newtonsoft.Json.Required.Default)]
        public bool? DisablePowerPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets disable sign in on resume.
        /// Disables the requirement to sign in whenever the device wakes up from sleep mode.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "disableSignInOnResume", Required = Newtonsoft.Json.Required.Default)]
        public bool? DisableSignInOnResume { get; set; }
    
        /// <summary>
        /// Gets or sets enabled.
        /// Enables shared PC mode and applies the shared pc policies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? Enabled { get; set; }
    
        /// <summary>
        /// Gets or sets idle time before sleep in seconds.
        /// Specifies the time in seconds that a device must sit idle before the PC goes to sleep. Setting this value to 0 prevents the sleep timeout from occurring.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "idleTimeBeforeSleepInSeconds", Required = Newtonsoft.Json.Required.Default)]
        public Int32? IdleTimeBeforeSleepInSeconds { get; set; }
    
        /// <summary>
        /// Gets or sets kiosk app display name.
        /// Specifies the display text for the account shown on the sign-in screen which launches the app specified by SetKioskAppUserModelId. Only applies when KioskAppUserModelId is set.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "kioskAppDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string KioskAppDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets kiosk app user model id.
        /// Specifies the application user model ID of the app to use with assigned access.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "kioskAppUserModelId", Required = Newtonsoft.Json.Required.Default)]
        public string KioskAppUserModelId { get; set; }
    
        /// <summary>
        /// Gets or sets maintenance start time.
        /// Specifies the daily start time of maintenance hour.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maintenanceStartTime", Required = Newtonsoft.Json.Required.Default)]
        public TimeOfDay MaintenanceStartTime { get; set; }
    
    }
}

