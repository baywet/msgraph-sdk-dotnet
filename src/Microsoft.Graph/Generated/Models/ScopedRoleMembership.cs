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
    public partial class ScopedRoleMembership : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Unique identifier for the administrative unit that the directory role is scoped to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdministrativeUnitId
        {
            get { return BackingStore?.Get<string?>("administrativeUnitId"); }
            set { BackingStore?.Set("administrativeUnitId", value); }
        }
#nullable restore
#else
        public string AdministrativeUnitId
        {
            get { return BackingStore?.Get<string>("administrativeUnitId"); }
            set { BackingStore?.Set("administrativeUnitId", value); }
        }
#endif
        /// <summary>Unique identifier for the directory role that the member is in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleId
        {
            get { return BackingStore?.Get<string?>("roleId"); }
            set { BackingStore?.Set("roleId", value); }
        }
#nullable restore
#else
        public string RoleId
        {
            get { return BackingStore?.Get<string>("roleId"); }
            set { BackingStore?.Set("roleId", value); }
        }
#endif
        /// <summary>The roleMemberInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Identity? RoleMemberInfo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Identity?>("roleMemberInfo"); }
            set { BackingStore?.Set("roleMemberInfo", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Identity RoleMemberInfo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Identity>("roleMemberInfo"); }
            set { BackingStore?.Set("roleMemberInfo", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ScopedRoleMembership"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.ScopedRoleMembership CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.ScopedRoleMembership();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "administrativeUnitId", n => { AdministrativeUnitId = n.GetStringValue(); } },
                { "roleId", n => { RoleId = n.GetStringValue(); } },
                { "roleMemberInfo", n => { RoleMemberInfo = n.GetObjectValue<global::Microsoft.Graph.Models.Identity>(global::Microsoft.Graph.Models.Identity.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("administrativeUnitId", AdministrativeUnitId);
            writer.WriteStringValue("roleId", RoleId);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Identity>("roleMemberInfo", RoleMemberInfo);
        }
    }
}
