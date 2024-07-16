// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class UnifiedGroupSource : global::Microsoft.Graph.Models.Security.DataSource, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The group property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Group? Group
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Group?>("group"); }
            set { BackingStore?.Set("group", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Group Group
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Group>("group"); }
            set { BackingStore?.Set("group", value); }
        }
#endif
        /// <summary>Specifies which sources are included in this group. Possible values are: mailbox, site.</summary>
        public global::Microsoft.Graph.Models.Security.SourceType? IncludedSources
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.SourceType?>("includedSources"); }
            set { BackingStore?.Set("includedSources", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.Security.UnifiedGroupSource"/> and sets the default values.
        /// </summary>
        public UnifiedGroupSource() : base()
        {
            OdataType = "#microsoft.graph.security.unifiedGroupSource";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Security.UnifiedGroupSource"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Security.UnifiedGroupSource CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Security.UnifiedGroupSource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "group", n => { Group = n.GetObjectValue<global::Microsoft.Graph.Models.Group>(global::Microsoft.Graph.Models.Group.CreateFromDiscriminatorValue); } },
                { "includedSources", n => { IncludedSources = n.GetEnumValue<global::Microsoft.Graph.Models.Security.SourceType>(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Group>("group", Group);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Security.SourceType>("includedSources", IncludedSources);
        }
    }
}
