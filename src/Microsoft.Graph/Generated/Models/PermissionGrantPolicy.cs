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
    public partial class PermissionGrantPolicy : global::Microsoft.Graph.Models.PolicyBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Condition sets that are excluded in this permission grant policy. Automatically expanded on GET.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.PermissionGrantConditionSet>? Excludes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.PermissionGrantConditionSet>?>("excludes"); }
            set { BackingStore?.Set("excludes", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.PermissionGrantConditionSet> Excludes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.PermissionGrantConditionSet>>("excludes"); }
            set { BackingStore?.Set("excludes", value); }
        }
#endif
        /// <summary>Condition sets that are included in this permission grant policy. Automatically expanded on GET.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.PermissionGrantConditionSet>? Includes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.PermissionGrantConditionSet>?>("includes"); }
            set { BackingStore?.Set("includes", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.PermissionGrantConditionSet> Includes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.PermissionGrantConditionSet>>("includes"); }
            set { BackingStore?.Set("includes", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.PermissionGrantPolicy"/> and sets the default values.
        /// </summary>
        public PermissionGrantPolicy() : base()
        {
            OdataType = "#microsoft.graph.permissionGrantPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.PermissionGrantPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.PermissionGrantPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.PermissionGrantPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "excludes", n => { Excludes = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.PermissionGrantConditionSet>(global::Microsoft.Graph.Models.PermissionGrantConditionSet.CreateFromDiscriminatorValue)?.AsList(); } },
                { "includes", n => { Includes = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.PermissionGrantConditionSet>(global::Microsoft.Graph.Models.PermissionGrantConditionSet.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.PermissionGrantConditionSet>("excludes", Excludes);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.PermissionGrantConditionSet>("includes", Includes);
        }
    }
}
