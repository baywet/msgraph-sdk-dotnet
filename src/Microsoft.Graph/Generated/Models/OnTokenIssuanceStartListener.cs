// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class OnTokenIssuanceStartListener : Microsoft.Graph.Models.AuthenticationEventListener, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The handler to invoke when conditions are met for this onTokenIssuanceStartListener.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.OnTokenIssuanceStartHandler? Handler
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.OnTokenIssuanceStartHandler?>("handler"); }
            set { BackingStore?.Set("handler", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.OnTokenIssuanceStartHandler Handler
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.OnTokenIssuanceStartHandler>("handler"); }
            set { BackingStore?.Set("handler", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Models.OnTokenIssuanceStartListener"/> and sets the default values.
        /// </summary>
        public OnTokenIssuanceStartListener() : base()
        {
            OdataType = "#microsoft.graph.onTokenIssuanceStartListener";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.OnTokenIssuanceStartListener"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.OnTokenIssuanceStartListener CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.OnTokenIssuanceStartListener();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "handler", n => { Handler = n.GetObjectValue<Microsoft.Graph.Models.OnTokenIssuanceStartHandler>(Microsoft.Graph.Models.OnTokenIssuanceStartHandler.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Models.OnTokenIssuanceStartHandler>("handler", Handler);
        }
    }
}