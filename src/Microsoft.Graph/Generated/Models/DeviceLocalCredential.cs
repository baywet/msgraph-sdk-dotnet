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
    public partial class DeviceLocalCredential : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The name of the local admin account for which LAPS is enabled.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountName
        {
            get { return BackingStore?.Get<string?>("accountName"); }
            set { BackingStore?.Set("accountName", value); }
        }
#nullable restore
#else
        public string AccountName
        {
            get { return BackingStore?.Get<string>("accountName"); }
            set { BackingStore?.Set("accountName", value); }
        }
#endif
        /// <summary>The SID of the local admin account for which LAPS is enabled.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountSid
        {
            get { return BackingStore?.Get<string?>("accountSid"); }
            set { BackingStore?.Set("accountSid", value); }
        }
#nullable restore
#else
        public string AccountSid
        {
            get { return BackingStore?.Get<string>("accountSid"); }
            set { BackingStore?.Set("accountSid", value); }
        }
#endif
        /// <summary>When the local administrator account credential for the device object was backed up to Azure Active Directory.</summary>
        public DateTimeOffset? BackupDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("backupDateTime"); }
            set { BackingStore?.Set("backupDateTime", value); }
        }
        /// <summary>The password for the local administrator account that is backed up to Azure Active Directory and returned as a Base64 encoded value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PasswordBase64
        {
            get { return BackingStore?.Get<string?>("passwordBase64"); }
            set { BackingStore?.Set("passwordBase64", value); }
        }
#nullable restore
#else
        public string PasswordBase64
        {
            get { return BackingStore?.Get<string>("passwordBase64"); }
            set { BackingStore?.Set("passwordBase64", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.DeviceLocalCredential"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.DeviceLocalCredential CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.DeviceLocalCredential();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accountName", n => { AccountName = n.GetStringValue(); } },
                { "accountSid", n => { AccountSid = n.GetStringValue(); } },
                { "backupDateTime", n => { BackupDateTime = n.GetDateTimeOffsetValue(); } },
                { "passwordBase64", n => { PasswordBase64 = n.GetStringValue(); } },
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
            writer.WriteStringValue("accountName", AccountName);
            writer.WriteStringValue("accountSid", AccountSid);
            writer.WriteDateTimeOffsetValue("backupDateTime", BackupDateTime);
            writer.WriteStringValue("passwordBase64", PasswordBase64);
        }
    }
}
