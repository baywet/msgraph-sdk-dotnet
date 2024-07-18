// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class CalendarSharingMessageAction : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The action property</summary>
        public global::Microsoft.Graph.Models.CalendarSharingAction? Action
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CalendarSharingAction?>("action"); }
            set { BackingStore?.Set("action", value); }
        }
        /// <summary>The actionType property</summary>
        public global::Microsoft.Graph.Models.CalendarSharingActionType? ActionType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CalendarSharingActionType?>("actionType"); }
            set { BackingStore?.Set("actionType", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The importance property</summary>
        public global::Microsoft.Graph.Models.CalendarSharingActionImportance? Importance
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CalendarSharingActionImportance?>("importance"); }
            set { BackingStore?.Set("importance", value); }
        }
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
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.CalendarSharingMessageAction"/> and sets the default values.
        /// </summary>
        public CalendarSharingMessageAction()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.CalendarSharingMessageAction"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.CalendarSharingMessageAction CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.CalendarSharingMessageAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "action", n => { Action = n.GetEnumValue<global::Microsoft.Graph.Models.CalendarSharingAction>(); } },
                { "actionType", n => { ActionType = n.GetEnumValue<global::Microsoft.Graph.Models.CalendarSharingActionType>(); } },
                { "importance", n => { Importance = n.GetEnumValue<global::Microsoft.Graph.Models.CalendarSharingActionImportance>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Microsoft.Graph.Models.CalendarSharingAction>("action", Action);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.CalendarSharingActionType>("actionType", ActionType);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.CalendarSharingActionImportance>("importance", Importance);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
