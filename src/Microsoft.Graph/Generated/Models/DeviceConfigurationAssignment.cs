using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>The device configuration assignment entity assigns an AAD group to a specific device configuration.</summary>
    public class DeviceConfigurationAssignment : Entity, IParsable {
        /// <summary>The assignment target for the device configuration.</summary>
        public DeviceAndAppManagementAssignmentTarget Target {
            get { return BackingStore?.Get<DeviceAndAppManagementAssignmentTarget>("target"); }
            set { BackingStore?.Set("target", value); }
        }
        /// <summary>
        /// Instantiates a new deviceConfigurationAssignment and sets the default values.
        /// </summary>
        public DeviceConfigurationAssignment() : base() {
            OdataType = "#microsoft.graph.deviceConfigurationAssignment";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceConfigurationAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceConfigurationAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"target", n => { Target = n.GetObjectValue<DeviceAndAppManagementAssignmentTarget>(DeviceAndAppManagementAssignmentTarget.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DeviceAndAppManagementAssignmentTarget>("target", Target);
        }
    }
}
