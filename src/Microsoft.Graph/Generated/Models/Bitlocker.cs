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
    public partial class Bitlocker : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The recovery keys associated with the bitlocker entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.BitlockerRecoveryKey>? RecoveryKeys
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.BitlockerRecoveryKey>?>("recoveryKeys"); }
            set { BackingStore?.Set("recoveryKeys", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.BitlockerRecoveryKey> RecoveryKeys
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.BitlockerRecoveryKey>>("recoveryKeys"); }
            set { BackingStore?.Set("recoveryKeys", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Bitlocker"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Bitlocker CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Bitlocker();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "recoveryKeys", n => { RecoveryKeys = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.BitlockerRecoveryKey>(global::Microsoft.Graph.Models.BitlockerRecoveryKey.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.BitlockerRecoveryKey>("recoveryKeys", RecoveryKeys);
        }
    }
}
