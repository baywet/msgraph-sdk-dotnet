using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>Device Compilance Policy and Configuration for a Setting State summary</summary>
    public class SettingStateDeviceSummary : Entity, IParsable {
        /// <summary>Device Compliant count for the setting</summary>
        public int? CompliantDeviceCount {
            get { return BackingStore?.Get<int?>("compliantDeviceCount"); }
            set { BackingStore?.Set("compliantDeviceCount", value); }
        }
        /// <summary>Device conflict error count for the setting</summary>
        public int? ConflictDeviceCount {
            get { return BackingStore?.Get<int?>("conflictDeviceCount"); }
            set { BackingStore?.Set("conflictDeviceCount", value); }
        }
        /// <summary>Device error count for the setting</summary>
        public int? ErrorDeviceCount {
            get { return BackingStore?.Get<int?>("errorDeviceCount"); }
            set { BackingStore?.Set("errorDeviceCount", value); }
        }
        /// <summary>Name of the InstancePath for the setting</summary>
        public string InstancePath {
            get { return BackingStore?.Get<string>("instancePath"); }
            set { BackingStore?.Set("instancePath", value); }
        }
        /// <summary>Device NonCompliant count for the setting</summary>
        public int? NonCompliantDeviceCount {
            get { return BackingStore?.Get<int?>("nonCompliantDeviceCount"); }
            set { BackingStore?.Set("nonCompliantDeviceCount", value); }
        }
        /// <summary>Device Not Applicable count for the setting</summary>
        public int? NotApplicableDeviceCount {
            get { return BackingStore?.Get<int?>("notApplicableDeviceCount"); }
            set { BackingStore?.Set("notApplicableDeviceCount", value); }
        }
        /// <summary>Device Compliant count for the setting</summary>
        public int? RemediatedDeviceCount {
            get { return BackingStore?.Get<int?>("remediatedDeviceCount"); }
            set { BackingStore?.Set("remediatedDeviceCount", value); }
        }
        /// <summary>Name of the setting</summary>
        public string SettingName {
            get { return BackingStore?.Get<string>("settingName"); }
            set { BackingStore?.Set("settingName", value); }
        }
        /// <summary>Device Unkown count for the setting</summary>
        public int? UnknownDeviceCount {
            get { return BackingStore?.Get<int?>("unknownDeviceCount"); }
            set { BackingStore?.Set("unknownDeviceCount", value); }
        }
        /// <summary>
        /// Instantiates a new settingStateDeviceSummary and sets the default values.
        /// </summary>
        public SettingStateDeviceSummary() : base() {
            OdataType = "#microsoft.graph.settingStateDeviceSummary";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SettingStateDeviceSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SettingStateDeviceSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"compliantDeviceCount", n => { CompliantDeviceCount = n.GetIntValue(); } },
                {"conflictDeviceCount", n => { ConflictDeviceCount = n.GetIntValue(); } },
                {"errorDeviceCount", n => { ErrorDeviceCount = n.GetIntValue(); } },
                {"instancePath", n => { InstancePath = n.GetStringValue(); } },
                {"nonCompliantDeviceCount", n => { NonCompliantDeviceCount = n.GetIntValue(); } },
                {"notApplicableDeviceCount", n => { NotApplicableDeviceCount = n.GetIntValue(); } },
                {"remediatedDeviceCount", n => { RemediatedDeviceCount = n.GetIntValue(); } },
                {"settingName", n => { SettingName = n.GetStringValue(); } },
                {"unknownDeviceCount", n => { UnknownDeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("compliantDeviceCount", CompliantDeviceCount);
            writer.WriteIntValue("conflictDeviceCount", ConflictDeviceCount);
            writer.WriteIntValue("errorDeviceCount", ErrorDeviceCount);
            writer.WriteStringValue("instancePath", InstancePath);
            writer.WriteIntValue("nonCompliantDeviceCount", NonCompliantDeviceCount);
            writer.WriteIntValue("notApplicableDeviceCount", NotApplicableDeviceCount);
            writer.WriteIntValue("remediatedDeviceCount", RemediatedDeviceCount);
            writer.WriteStringValue("settingName", SettingName);
            writer.WriteIntValue("unknownDeviceCount", UnknownDeviceCount);
        }
    }
}
