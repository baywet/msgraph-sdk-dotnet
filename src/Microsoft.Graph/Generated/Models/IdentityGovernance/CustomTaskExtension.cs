// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.IdentityGovernance
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class CustomTaskExtension : global::Microsoft.Graph.Models.CustomCalloutExtension, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The callback configuration for a custom task extension.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.CustomExtensionCallbackConfiguration? CallbackConfiguration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CustomExtensionCallbackConfiguration?>("callbackConfiguration"); }
            set { BackingStore?.Set("callbackConfiguration", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.CustomExtensionCallbackConfiguration CallbackConfiguration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CustomExtensionCallbackConfiguration>("callbackConfiguration"); }
            set { BackingStore?.Set("callbackConfiguration", value); }
        }
#endif
        /// <summary>The unique identifier of the Microsoft Entra user that created the custom task extension.Supports $filter(eq, ne) and $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.User? CreatedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.User?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.User CreatedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.User>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>When the custom task extension was created.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The unique identifier of the Microsoft Entra user that modified the custom task extension last.Supports $filter(eq, ne) and $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.User? LastModifiedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.User?>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.User LastModifiedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.User>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#endif
        /// <summary>When the custom extension was last modified.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.IdentityGovernance.CustomTaskExtension"/> and sets the default values.
        /// </summary>
        public CustomTaskExtension() : base()
        {
            OdataType = "#microsoft.graph.identityGovernance.customTaskExtension";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.IdentityGovernance.CustomTaskExtension"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.IdentityGovernance.CustomTaskExtension CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.IdentityGovernance.CustomTaskExtension();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "callbackConfiguration", n => { CallbackConfiguration = n.GetObjectValue<global::Microsoft.Graph.Models.CustomExtensionCallbackConfiguration>(global::Microsoft.Graph.Models.CustomExtensionCallbackConfiguration.CreateFromDiscriminatorValue); } },
                { "createdBy", n => { CreatedBy = n.GetObjectValue<global::Microsoft.Graph.Models.User>(global::Microsoft.Graph.Models.User.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<global::Microsoft.Graph.Models.User>(global::Microsoft.Graph.Models.User.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.CustomExtensionCallbackConfiguration>("callbackConfiguration", CallbackConfiguration);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.User>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.User>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
        }
    }
}
