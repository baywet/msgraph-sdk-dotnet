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
    public partial class KubernetesNamespaceEvidence : global::Microsoft.Graph.Models.Security.AlertEvidence, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The namespace cluster.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.KubernetesClusterEvidence? Cluster
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.KubernetesClusterEvidence?>("cluster"); }
            set { BackingStore?.Set("cluster", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.KubernetesClusterEvidence Cluster
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.KubernetesClusterEvidence>("cluster"); }
            set { BackingStore?.Set("cluster", value); }
        }
#endif
        /// <summary>The labels for the Kubernetes pod.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.Dictionary? Labels
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.Dictionary?>("labels"); }
            set { BackingStore?.Set("labels", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.Dictionary Labels
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.Dictionary>("labels"); }
            set { BackingStore?.Set("labels", value); }
        }
#endif
        /// <summary>The namespace name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name
        {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name
        {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.Security.KubernetesNamespaceEvidence"/> and sets the default values.
        /// </summary>
        public KubernetesNamespaceEvidence() : base()
        {
            OdataType = "#microsoft.graph.security.kubernetesNamespaceEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Security.KubernetesNamespaceEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Security.KubernetesNamespaceEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Security.KubernetesNamespaceEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "cluster", n => { Cluster = n.GetObjectValue<global::Microsoft.Graph.Models.Security.KubernetesClusterEvidence>(global::Microsoft.Graph.Models.Security.KubernetesClusterEvidence.CreateFromDiscriminatorValue); } },
                { "labels", n => { Labels = n.GetObjectValue<global::Microsoft.Graph.Models.Security.Dictionary>(global::Microsoft.Graph.Models.Security.Dictionary.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.KubernetesClusterEvidence>("cluster", Cluster);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.Dictionary>("labels", Labels);
            writer.WriteStringValue("name", Name);
        }
    }
}
