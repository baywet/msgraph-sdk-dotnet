// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class Fido2AuthenticationMethodConfiguration : Microsoft.Graph.Models.AuthenticationMethodConfiguration, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A collection of groups that are enabled to use the authentication method.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.AuthenticationMethodTarget>? IncludeTargets
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.AuthenticationMethodTarget>?>("includeTargets"); }
            set { BackingStore?.Set("includeTargets", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.AuthenticationMethodTarget> IncludeTargets
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.AuthenticationMethodTarget>>("includeTargets"); }
            set { BackingStore?.Set("includeTargets", value); }
        }
#endif
        /// <summary>Determines whether attestation must be enforced for FIDO2 security key registration.</summary>
        public bool? IsAttestationEnforced
        {
            get { return BackingStore?.Get<bool?>("isAttestationEnforced"); }
            set { BackingStore?.Set("isAttestationEnforced", value); }
        }
        /// <summary>Determines if users can register new FIDO2 security keys.</summary>
        public bool? IsSelfServiceRegistrationAllowed
        {
            get { return BackingStore?.Get<bool?>("isSelfServiceRegistrationAllowed"); }
            set { BackingStore?.Set("isSelfServiceRegistrationAllowed", value); }
        }
        /// <summary>Controls whether key restrictions are enforced on FIDO2 security keys, either allowing or disallowing certain key types as defined by Authenticator Attestation GUID (AAGUID), an identifier that indicates the type (e.g. make and model) of the authenticator.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Fido2KeyRestrictions? KeyRestrictions
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Fido2KeyRestrictions?>("keyRestrictions"); }
            set { BackingStore?.Set("keyRestrictions", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Fido2KeyRestrictions KeyRestrictions
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Fido2KeyRestrictions>("keyRestrictions"); }
            set { BackingStore?.Set("keyRestrictions", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Models.Fido2AuthenticationMethodConfiguration"/> and sets the default values.
        /// </summary>
        public Fido2AuthenticationMethodConfiguration() : base()
        {
            OdataType = "#microsoft.graph.fido2AuthenticationMethodConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.Fido2AuthenticationMethodConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.Fido2AuthenticationMethodConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.Fido2AuthenticationMethodConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "includeTargets", n => { IncludeTargets = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.AuthenticationMethodTarget>(Microsoft.Graph.Models.AuthenticationMethodTarget.CreateFromDiscriminatorValue)?.ToList(); } },
                { "isAttestationEnforced", n => { IsAttestationEnforced = n.GetBoolValue(); } },
                { "isSelfServiceRegistrationAllowed", n => { IsSelfServiceRegistrationAllowed = n.GetBoolValue(); } },
                { "keyRestrictions", n => { KeyRestrictions = n.GetObjectValue<Microsoft.Graph.Models.Fido2KeyRestrictions>(Microsoft.Graph.Models.Fido2KeyRestrictions.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.AuthenticationMethodTarget>("includeTargets", IncludeTargets);
            writer.WriteBoolValue("isAttestationEnforced", IsAttestationEnforced);
            writer.WriteBoolValue("isSelfServiceRegistrationAllowed", IsSelfServiceRegistrationAllowed);
            writer.WriteObjectValue<Microsoft.Graph.Models.Fido2KeyRestrictions>("keyRestrictions", KeyRestrictions);
        }
    }
}
