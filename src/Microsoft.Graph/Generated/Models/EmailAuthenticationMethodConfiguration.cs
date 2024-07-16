// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class EmailAuthenticationMethodConfiguration : global::Microsoft.Graph.Models.AuthenticationMethodConfiguration, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Determines whether email OTP is usable by external users for authentication. Possible values are: default, enabled, disabled, unknownFutureValue. Tenants in the default state who didn&apos;t use public preview have email OTP enabled beginning in October 2021.</summary>
        public global::Microsoft.Graph.Models.ExternalEmailOtpState? AllowExternalIdToUseEmailOtp
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ExternalEmailOtpState?>("allowExternalIdToUseEmailOtp"); }
            set { BackingStore?.Set("allowExternalIdToUseEmailOtp", value); }
        }
        /// <summary>A collection of groups that are enabled to use the authentication method.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AuthenticationMethodTarget>? IncludeTargets
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AuthenticationMethodTarget>?>("includeTargets"); }
            set { BackingStore?.Set("includeTargets", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AuthenticationMethodTarget> IncludeTargets
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AuthenticationMethodTarget>>("includeTargets"); }
            set { BackingStore?.Set("includeTargets", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.EmailAuthenticationMethodConfiguration"/> and sets the default values.
        /// </summary>
        public EmailAuthenticationMethodConfiguration() : base()
        {
            OdataType = "#microsoft.graph.emailAuthenticationMethodConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.EmailAuthenticationMethodConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.EmailAuthenticationMethodConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.EmailAuthenticationMethodConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowExternalIdToUseEmailOtp", n => { AllowExternalIdToUseEmailOtp = n.GetEnumValue<global::Microsoft.Graph.Models.ExternalEmailOtpState>(); } },
                { "includeTargets", n => { IncludeTargets = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AuthenticationMethodTarget>(global::Microsoft.Graph.Models.AuthenticationMethodTarget.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.ExternalEmailOtpState>("allowExternalIdToUseEmailOtp", AllowExternalIdToUseEmailOtp);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AuthenticationMethodTarget>("includeTargets", IncludeTargets);
        }
    }
}
