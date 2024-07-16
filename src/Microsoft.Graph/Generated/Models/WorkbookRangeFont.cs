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
    public partial class WorkbookRangeFont : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents the bold status of font.</summary>
        public bool? Bold
        {
            get { return BackingStore?.Get<bool?>("bold"); }
            set { BackingStore?.Set("bold", value); }
        }
        /// <summary>HTML color code representation of the text color. for example #FF0000 represents Red.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Color
        {
            get { return BackingStore?.Get<string?>("color"); }
            set { BackingStore?.Set("color", value); }
        }
#nullable restore
#else
        public string Color
        {
            get { return BackingStore?.Get<string>("color"); }
            set { BackingStore?.Set("color", value); }
        }
#endif
        /// <summary>Represents the italic status of the font.</summary>
        public bool? Italic
        {
            get { return BackingStore?.Get<bool?>("italic"); }
            set { BackingStore?.Set("italic", value); }
        }
        /// <summary>Font name (for example &apos;Calibri&apos;)</summary>
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
        /// <summary>Font size.</summary>
        public double? Size
        {
            get { return BackingStore?.Get<double?>("size"); }
            set { BackingStore?.Set("size", value); }
        }
        /// <summary>Type of underline applied to the font. The possible values are: None, Single, Double, SingleAccountant, DoubleAccountant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Underline
        {
            get { return BackingStore?.Get<string?>("underline"); }
            set { BackingStore?.Set("underline", value); }
        }
#nullable restore
#else
        public string Underline
        {
            get { return BackingStore?.Get<string>("underline"); }
            set { BackingStore?.Set("underline", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.WorkbookRangeFont"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.WorkbookRangeFont CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.WorkbookRangeFont();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "bold", n => { Bold = n.GetBoolValue(); } },
                { "color", n => { Color = n.GetStringValue(); } },
                { "italic", n => { Italic = n.GetBoolValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "size", n => { Size = n.GetDoubleValue(); } },
                { "underline", n => { Underline = n.GetStringValue(); } },
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
            writer.WriteBoolValue("bold", Bold);
            writer.WriteStringValue("color", Color);
            writer.WriteBoolValue("italic", Italic);
            writer.WriteStringValue("name", Name);
            writer.WriteDoubleValue("size", Size);
            writer.WriteStringValue("underline", Underline);
        }
    }
}
