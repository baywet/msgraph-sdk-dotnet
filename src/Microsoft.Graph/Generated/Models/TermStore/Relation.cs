// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.TermStore
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class Relation : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The from [term] of the relation. The term from which the relationship is defined. A null value would indicate the relation is directly with the [set].</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.TermStore.Term? FromTerm
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TermStore.Term?>("fromTerm"); }
            set { BackingStore?.Set("fromTerm", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.TermStore.Term FromTerm
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TermStore.Term>("fromTerm"); }
            set { BackingStore?.Set("fromTerm", value); }
        }
#endif
        /// <summary>The type of relation. Possible values are: pin, reuse.</summary>
        public global::Microsoft.Graph.Models.TermStore.RelationType? Relationship
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TermStore.RelationType?>("relationship"); }
            set { BackingStore?.Set("relationship", value); }
        }
        /// <summary>The [set] in which the relation is relevant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.TermStore.Set? Set
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TermStore.Set?>("set"); }
            set { BackingStore?.Set("set", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.TermStore.Set Set
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TermStore.Set>("set"); }
            set { BackingStore?.Set("set", value); }
        }
#endif
        /// <summary>The to [term] of the relation. The term to which the relationship is defined.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.TermStore.Term? ToTerm
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TermStore.Term?>("toTerm"); }
            set { BackingStore?.Set("toTerm", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.TermStore.Term ToTerm
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TermStore.Term>("toTerm"); }
            set { BackingStore?.Set("toTerm", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.TermStore.Relation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.TermStore.Relation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.TermStore.Relation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "fromTerm", n => { FromTerm = n.GetObjectValue<global::Microsoft.Graph.Models.TermStore.Term>(global::Microsoft.Graph.Models.TermStore.Term.CreateFromDiscriminatorValue); } },
                { "relationship", n => { Relationship = n.GetEnumValue<global::Microsoft.Graph.Models.TermStore.RelationType>(); } },
                { "set", n => { Set = n.GetObjectValue<global::Microsoft.Graph.Models.TermStore.Set>(global::Microsoft.Graph.Models.TermStore.Set.CreateFromDiscriminatorValue); } },
                { "toTerm", n => { ToTerm = n.GetObjectValue<global::Microsoft.Graph.Models.TermStore.Term>(global::Microsoft.Graph.Models.TermStore.Term.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.TermStore.Term>("fromTerm", FromTerm);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.TermStore.RelationType>("relationship", Relationship);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.TermStore.Set>("set", Set);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.TermStore.Term>("toTerm", ToTerm);
        }
    }
}
