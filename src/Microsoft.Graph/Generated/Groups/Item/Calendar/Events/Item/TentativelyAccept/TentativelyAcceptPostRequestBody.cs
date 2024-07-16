// <auto-generated/>
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Groups.Item.Calendar.Events.Item.TentativelyAccept
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class TentativelyAcceptPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The Comment property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comment
        {
            get { return BackingStore?.Get<string?>("Comment"); }
            set { BackingStore?.Set("Comment", value); }
        }
#nullable restore
#else
        public string Comment
        {
            get { return BackingStore?.Get<string>("Comment"); }
            set { BackingStore?.Set("Comment", value); }
        }
#endif
        /// <summary>The ProposedNewTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.TimeSlot? ProposedNewTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TimeSlot?>("ProposedNewTime"); }
            set { BackingStore?.Set("ProposedNewTime", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.TimeSlot ProposedNewTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TimeSlot>("ProposedNewTime"); }
            set { BackingStore?.Set("ProposedNewTime", value); }
        }
#endif
        /// <summary>The SendResponse property</summary>
        public bool? SendResponse
        {
            get { return BackingStore?.Get<bool?>("SendResponse"); }
            set { BackingStore?.Set("SendResponse", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Groups.Item.Calendar.Events.Item.TentativelyAccept.TentativelyAcceptPostRequestBody"/> and sets the default values.
        /// </summary>
        public TentativelyAcceptPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Groups.Item.Calendar.Events.Item.TentativelyAccept.TentativelyAcceptPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Groups.Item.Calendar.Events.Item.TentativelyAccept.TentativelyAcceptPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Groups.Item.Calendar.Events.Item.TentativelyAccept.TentativelyAcceptPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "Comment", n => { Comment = n.GetStringValue(); } },
                { "ProposedNewTime", n => { ProposedNewTime = n.GetObjectValue<global::Microsoft.Graph.Models.TimeSlot>(global::Microsoft.Graph.Models.TimeSlot.CreateFromDiscriminatorValue); } },
                { "SendResponse", n => { SendResponse = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Comment", Comment);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.TimeSlot>("ProposedNewTime", ProposedNewTime);
            writer.WriteBoolValue("SendResponse", SendResponse);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
