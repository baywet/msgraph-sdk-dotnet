// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Application.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Application : DirectoryObject
    {
    
		///<summary>
		/// The Application constructor
		///</summary>
        public Application()
        {
            this.ODataType = "microsoft.graph.application";
        }
	
        /// <summary>
        /// Gets or sets add ins.
        /// Defines custom behavior that a consuming service can use to call an app in specific contexts. For example, applications that can render file streams may set the addIns property for its 'FileHandler' functionality. This will let services like Office 365 call the application in the context of a document the user is working on.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "addIns", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AddIn> AddIns { get; set; }
    
        /// <summary>
        /// Gets or sets api.
        /// Specifies settings for an application that implements a web API.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "api", Required = Newtonsoft.Json.Required.Default)]
        public ApiApplication Api { get; set; }
    
        /// <summary>
        /// Gets or sets app id.
        /// The unique identifier for the application that is assigned to an application by Azure AD. Not nullable. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appId", Required = Newtonsoft.Json.Required.Default)]
        public string AppId { get; set; }
    
        /// <summary>
        /// Gets or sets application template id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applicationTemplateId", Required = Newtonsoft.Json.Required.Default)]
        public string ApplicationTemplateId { get; set; }
    
        /// <summary>
        /// Gets or sets app roles.
        /// The collection of application roles that an application may declare. These roles can be assigned to users, groups, or service principals. Not nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appRoles", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AppRole> AppRoles { get; set; }
    
        /// <summary>
        /// Gets or sets is fallback public client.
        /// Specifies the fallback application type as public client, such as an installed application running on a mobile device. The default value is false which means the fallback application type is confidential client such as web app. There are certain scenarios where Azure AD cannot determine the client application type (e.g. ROPC flow where it is configured without specifying a redirect URI). In those cases Azure AD will interpret the application type based on the value of this property.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isFallbackPublicClient", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsFallbackPublicClient { get; set; }
    
        /// <summary>
        /// Gets or sets identifier uris.
        /// The URIs that identify the application within its Azure AD tenant, or within a verified custom domain if the application is multi-tenant. For more information see Application Objects and Service Principal Objects. The any operator is required for filter expressions on multi-valued properties. Not nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identifierUris", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> IdentifierUris { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The date and time the application was registered. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets public client.
        /// Specifies settings for installed clients such as desktop or mobile devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "publicClient", Required = Newtonsoft.Json.Required.Default)]
        public PublicClientApplication PublicClient { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name for the application.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets group membership claims.
        /// Configures the groups claim issued in a user or OAuth 2.0 access token that the application expects. To set this attribute, use one of the following valid string values:NoneSecurityGroup: For security groups and Azure AD rolesAll: This will get all of the security groups, distribution groups, and Azure AD directory roles that the signed-in user is a member of
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "groupMembershipClaims", Required = Newtonsoft.Json.Required.Default)]
        public string GroupMembershipClaims { get; set; }
    
        /// <summary>
        /// Gets or sets info.
        /// Basic profile information of the application such as  app's marketing, support, terms of service and privacy statement URLs. The terms of service and privacy statement are surfaced to users through the user consent experience. For more info, see How to: Add Terms of service and privacy statement for registered Azure AD apps.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "info", Required = Newtonsoft.Json.Required.Default)]
        public InformationalUrl Info { get; set; }
    
        /// <summary>
        /// Gets or sets is device only auth supported.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isDeviceOnlyAuthSupported", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsDeviceOnlyAuthSupported { get; set; }
    
        /// <summary>
        /// Gets or sets key credentials.
        /// The collection of key credentials associated with the application Not nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "keyCredentials", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<KeyCredential> KeyCredentials { get; set; }
    
        /// <summary>
        /// Gets or sets logo.
        /// The main logo for the application. Not nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "logo", Required = Newtonsoft.Json.Required.Default)]
        public Stream Logo { get; set; }
    
        /// <summary>
        /// Gets or sets oauth2require post response.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "oauth2RequirePostResponse", Required = Newtonsoft.Json.Required.Default)]
        public bool? Oauth2RequirePostResponse { get; set; }
    
        /// <summary>
        /// Gets or sets optional claims.
        /// Application developers can configure optional claims in their Azure AD apps to specify which claims they want in tokens sent to their application by the Microsoft security token service. See provide optional claims to your Azure AD app for more information.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "optionalClaims", Required = Newtonsoft.Json.Required.Default)]
        public OptionalClaims OptionalClaims { get; set; }
    
        /// <summary>
        /// Gets or sets parental control settings.
        /// Specifies parental control settings for an application.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parentalControlSettings", Required = Newtonsoft.Json.Required.Default)]
        public ParentalControlSettings ParentalControlSettings { get; set; }
    
        /// <summary>
        /// Gets or sets password credentials.
        /// The collection of password credentials associated with the application. Not nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordCredentials", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<PasswordCredential> PasswordCredentials { get; set; }
    
        /// <summary>
        /// Gets or sets publisher domain.
        /// The verified publisher domain for the application. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "publisherDomain", Required = Newtonsoft.Json.Required.Default)]
        public string PublisherDomain { get; set; }
    
        /// <summary>
        /// Gets or sets required resource access.
        /// Specifies resources that this application requires access to and the set of OAuth permission scopes and application roles that it needs under each of those resources. This pre-configuration of required resource access drives the consent experience. Not nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requiredResourceAccess", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<RequiredResourceAccess> RequiredResourceAccess { get; set; }
    
        /// <summary>
        /// Gets or sets sign in audience.
        /// Specifies what Microsoft accounts are supported for the current application. Supported values are:AzureADMyOrg: Users with a Microsoft work or school account in my organization’s Azure AD tenant (i.e. single tenant)AzureADMultipleOrgs: Users with a Microsoft work or school account in any organization’s Azure AD tenant (i.e. multi-tenant) AzureADandPersonalMicrosoftAccount: Users with a personal Microsoft account, or a work or school account in any organization’s Azure AD tenant
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "signInAudience", Required = Newtonsoft.Json.Required.Default)]
        public string SignInAudience { get; set; }
    
        /// <summary>
        /// Gets or sets tags.
        /// Custom strings that can be used to categorize and identify the application. Not nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tags", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Tags { get; set; }
    
        /// <summary>
        /// Gets or sets token encryption key id.
        /// Specifies the keyId of a public key from the keyCredentials collection. When configured, Azure AD encrypts all the tokens it emits by using the key this property points to. The application code that receives the encrypted token must use the matching private key to decrypt the token before it can be used for the signed-in user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tokenEncryptionKeyId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? TokenEncryptionKeyId { get; set; }
    
        /// <summary>
        /// Gets or sets web.
        /// Specifies settings for a web application.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "web", Required = Newtonsoft.Json.Required.Default)]
        public WebApplication Web { get; set; }
    
        /// <summary>
        /// Gets or sets extension properties.
        /// Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "extensionProperties", Required = Newtonsoft.Json.Required.Default)]
        public IApplicationExtensionPropertiesCollectionPage ExtensionProperties { get; set; }
    
        /// <summary>
        /// Gets or sets created on behalf of.
        /// Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdOnBehalfOf", Required = Newtonsoft.Json.Required.Default)]
        public DirectoryObject CreatedOnBehalfOf { get; set; }
    
        /// <summary>
        /// Gets or sets owners.
        /// Directory objects that are owners of the application. The owners are a set of non-admin users who are allowed to modify this object. Requires version 2013-11-08 or newer. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "owners", Required = Newtonsoft.Json.Required.Default)]
        public IApplicationOwnersCollectionWithReferencesPage Owners { get; set; }
    
    }
}

