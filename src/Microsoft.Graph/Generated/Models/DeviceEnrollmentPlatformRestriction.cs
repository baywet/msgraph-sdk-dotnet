using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>Platform specific enrollment restrictions</summary>
    public class DeviceEnrollmentPlatformRestriction : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Max OS version supported</summary>
        public string OsMaximumVersion {
            get { return BackingStore?.Get<string>("osMaximumVersion"); }
            set { BackingStore?.Set("osMaximumVersion", value); }
        }
        /// <summary>Min OS version supported</summary>
        public string OsMinimumVersion {
            get { return BackingStore?.Get<string>("osMinimumVersion"); }
            set { BackingStore?.Set("osMinimumVersion", value); }
        }
        /// <summary>Block personally owned devices from enrolling</summary>
        public bool? PersonalDeviceEnrollmentBlocked {
            get { return BackingStore?.Get<bool?>("personalDeviceEnrollmentBlocked"); }
            set { BackingStore?.Set("personalDeviceEnrollmentBlocked", value); }
        }
        /// <summary>Block the platform from enrolling</summary>
        public bool? PlatformBlocked {
            get { return BackingStore?.Get<bool?>("platformBlocked"); }
            set { BackingStore?.Set("platformBlocked", value); }
        }
        /// <summary>
        /// Instantiates a new deviceEnrollmentPlatformRestriction and sets the default values.
        /// </summary>
        public DeviceEnrollmentPlatformRestriction() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.deviceEnrollmentPlatformRestriction";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeviceEnrollmentPlatformRestriction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceEnrollmentPlatformRestriction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"osMaximumVersion", n => { OsMaximumVersion = n.GetStringValue(); } },
                {"osMinimumVersion", n => { OsMinimumVersion = n.GetStringValue(); } },
                {"personalDeviceEnrollmentBlocked", n => { PersonalDeviceEnrollmentBlocked = n.GetBoolValue(); } },
                {"platformBlocked", n => { PlatformBlocked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("osMaximumVersion", OsMaximumVersion);
            writer.WriteStringValue("osMinimumVersion", OsMinimumVersion);
            writer.WriteBoolValue("personalDeviceEnrollmentBlocked", PersonalDeviceEnrollmentBlocked);
            writer.WriteBoolValue("platformBlocked", PlatformBlocked);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
