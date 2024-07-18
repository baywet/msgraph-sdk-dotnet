// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class HuntingQueryResults : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
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
        /// <summary>The results of the hunting query.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.HuntingRowResult>? Results
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.HuntingRowResult>?>("results"); }
            set { BackingStore?.Set("results", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.HuntingRowResult> Results
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.HuntingRowResult>>("results"); }
            set { BackingStore?.Set("results", value); }
        }
#endif
        /// <summary>The schema for the response.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.SinglePropertySchema>? Schema
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.SinglePropertySchema>?>("schema"); }
            set { BackingStore?.Set("schema", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.SinglePropertySchema> Schema
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.SinglePropertySchema>>("schema"); }
            set { BackingStore?.Set("schema", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.Security.HuntingQueryResults"/> and sets the default values.
        /// </summary>
        public HuntingQueryResults()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Security.HuntingQueryResults"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.Security.HuntingQueryResults CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Security.HuntingQueryResults();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "results", n => { Results = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.HuntingRowResult>(global::Microsoft.Graph.Models.Security.HuntingRowResult.CreateFromDiscriminatorValue)?.AsList(); } },
                { "schema", n => { Schema = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.SinglePropertySchema>(global::Microsoft.Graph.Models.Security.SinglePropertySchema.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.HuntingRowResult>("results", Results);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.SinglePropertySchema>("schema", Schema);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
