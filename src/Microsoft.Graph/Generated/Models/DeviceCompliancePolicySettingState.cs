// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>
    /// Device Compilance Policy Setting State for a given device.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class DeviceCompliancePolicySettingState : IAdditionalDataHolder, IBackedModel, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Current value of setting on device</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrentValue
        {
            get { return BackingStore?.Get<string?>("currentValue"); }
            set { BackingStore?.Set("currentValue", value); }
        }
#nullable restore
#else
        public string CurrentValue
        {
            get { return BackingStore?.Get<string>("currentValue"); }
            set { BackingStore?.Set("currentValue", value); }
        }
#endif
        /// <summary>Error code for the setting</summary>
        public long? ErrorCode
        {
            get { return BackingStore?.Get<long?>("errorCode"); }
            set { BackingStore?.Set("errorCode", value); }
        }
        /// <summary>Error description</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ErrorDescription
        {
            get { return BackingStore?.Get<string?>("errorDescription"); }
            set { BackingStore?.Set("errorDescription", value); }
        }
#nullable restore
#else
        public string ErrorDescription
        {
            get { return BackingStore?.Get<string>("errorDescription"); }
            set { BackingStore?.Set("errorDescription", value); }
        }
#endif
        /// <summary>Name of setting instance that is being reported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InstanceDisplayName
        {
            get { return BackingStore?.Get<string?>("instanceDisplayName"); }
            set { BackingStore?.Set("instanceDisplayName", value); }
        }
#nullable restore
#else
        public string InstanceDisplayName
        {
            get { return BackingStore?.Get<string>("instanceDisplayName"); }
            set { BackingStore?.Set("instanceDisplayName", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The setting that is being reported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Setting
        {
            get { return BackingStore?.Get<string?>("setting"); }
            set { BackingStore?.Set("setting", value); }
        }
#nullable restore
#else
        public string Setting
        {
            get { return BackingStore?.Get<string>("setting"); }
            set { BackingStore?.Set("setting", value); }
        }
#endif
        /// <summary>Localized/user friendly setting name that is being reported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SettingName
        {
            get { return BackingStore?.Get<string?>("settingName"); }
            set { BackingStore?.Set("settingName", value); }
        }
#nullable restore
#else
        public string SettingName
        {
            get { return BackingStore?.Get<string>("settingName"); }
            set { BackingStore?.Set("settingName", value); }
        }
#endif
        /// <summary>Contributing policies</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.SettingSource>? Sources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SettingSource>?>("sources"); }
            set { BackingStore?.Set("sources", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.SettingSource> Sources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SettingSource>>("sources"); }
            set { BackingStore?.Set("sources", value); }
        }
#endif
        /// <summary>The state property</summary>
        public global::Microsoft.Graph.Models.ComplianceStatus? State
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ComplianceStatus?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>UserEmail</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserEmail
        {
            get { return BackingStore?.Get<string?>("userEmail"); }
            set { BackingStore?.Set("userEmail", value); }
        }
#nullable restore
#else
        public string UserEmail
        {
            get { return BackingStore?.Get<string>("userEmail"); }
            set { BackingStore?.Set("userEmail", value); }
        }
#endif
        /// <summary>UserId</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId
        {
            get { return BackingStore?.Get<string?>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#nullable restore
#else
        public string UserId
        {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#endif
        /// <summary>UserName</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserName
        {
            get { return BackingStore?.Get<string?>("userName"); }
            set { BackingStore?.Set("userName", value); }
        }
#nullable restore
#else
        public string UserName
        {
            get { return BackingStore?.Get<string>("userName"); }
            set { BackingStore?.Set("userName", value); }
        }
#endif
        /// <summary>UserPrincipalName.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName
        {
            get { return BackingStore?.Get<string?>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#nullable restore
#else
        public string UserPrincipalName
        {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.DeviceCompliancePolicySettingState"/> and sets the default values.
        /// </summary>
        public DeviceCompliancePolicySettingState()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.DeviceCompliancePolicySettingState"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.DeviceCompliancePolicySettingState CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.DeviceCompliancePolicySettingState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "currentValue", n => { CurrentValue = n.GetStringValue(); } },
                { "errorCode", n => { ErrorCode = n.GetLongValue(); } },
                { "errorDescription", n => { ErrorDescription = n.GetStringValue(); } },
                { "instanceDisplayName", n => { InstanceDisplayName = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "setting", n => { Setting = n.GetStringValue(); } },
                { "settingName", n => { SettingName = n.GetStringValue(); } },
                { "sources", n => { Sources = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.SettingSource>(global::Microsoft.Graph.Models.SettingSource.CreateFromDiscriminatorValue)?.AsList(); } },
                { "state", n => { State = n.GetEnumValue<global::Microsoft.Graph.Models.ComplianceStatus>(); } },
                { "userEmail", n => { UserEmail = n.GetStringValue(); } },
                { "userId", n => { UserId = n.GetStringValue(); } },
                { "userName", n => { UserName = n.GetStringValue(); } },
                { "userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("currentValue", CurrentValue);
            writer.WriteLongValue("errorCode", ErrorCode);
            writer.WriteStringValue("errorDescription", ErrorDescription);
            writer.WriteStringValue("instanceDisplayName", InstanceDisplayName);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("setting", Setting);
            writer.WriteStringValue("settingName", SettingName);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.SettingSource>("sources", Sources);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.ComplianceStatus>("state", State);
            writer.WriteStringValue("userEmail", UserEmail);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userName", UserName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
