using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class WindowsUpdateForBusinessConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Automatic update mode. Possible values are: userDefined, notifyDownload, autoInstallAtMaintenanceTime, autoInstallAndRebootAtMaintenanceTime, autoInstallAndRebootAtScheduledTime, autoInstallAndRebootWithoutEndUserControl, windowsDefault.</summary>
        public Microsoft.Graph.Models.AutomaticUpdateMode? AutomaticUpdateMode {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AutomaticUpdateMode?>(nameof(AutomaticUpdateMode)); }
            set { BackingStore?.Set(nameof(AutomaticUpdateMode), value); }
        }
        /// <summary>Determines which branch devices will receive their updates from. Possible values are: userDefined, all, businessReadyOnly, windowsInsiderBuildFast, windowsInsiderBuildSlow, windowsInsiderBuildRelease.</summary>
        public WindowsUpdateType? BusinessReadyUpdatesOnly {
            get { return BackingStore?.Get<WindowsUpdateType?>(nameof(BusinessReadyUpdatesOnly)); }
            set { BackingStore?.Set(nameof(BusinessReadyUpdatesOnly), value); }
        }
        /// <summary>Delivery Optimization Mode. Possible values are: userDefined, httpOnly, httpWithPeeringNat, httpWithPeeringPrivateGroup, httpWithInternetPeering, simpleDownload, bypassMode.</summary>
        public WindowsDeliveryOptimizationMode? DeliveryOptimizationMode {
            get { return BackingStore?.Get<WindowsDeliveryOptimizationMode?>(nameof(DeliveryOptimizationMode)); }
            set { BackingStore?.Set(nameof(DeliveryOptimizationMode), value); }
        }
        /// <summary>Exclude Windows update Drivers</summary>
        public bool? DriversExcluded {
            get { return BackingStore?.Get<bool?>(nameof(DriversExcluded)); }
            set { BackingStore?.Set(nameof(DriversExcluded), value); }
        }
        /// <summary>Defer Feature Updates by these many days</summary>
        public int? FeatureUpdatesDeferralPeriodInDays {
            get { return BackingStore?.Get<int?>(nameof(FeatureUpdatesDeferralPeriodInDays)); }
            set { BackingStore?.Set(nameof(FeatureUpdatesDeferralPeriodInDays), value); }
        }
        /// <summary>Pause Feature Updates</summary>
        public bool? FeatureUpdatesPaused {
            get { return BackingStore?.Get<bool?>(nameof(FeatureUpdatesPaused)); }
            set { BackingStore?.Set(nameof(FeatureUpdatesPaused), value); }
        }
        /// <summary>Feature Updates Pause Expiry datetime</summary>
        public DateTimeOffset? FeatureUpdatesPauseExpiryDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(FeatureUpdatesPauseExpiryDateTime)); }
            set { BackingStore?.Set(nameof(FeatureUpdatesPauseExpiryDateTime), value); }
        }
        /// <summary>Installation schedule</summary>
        public WindowsUpdateInstallScheduleType InstallationSchedule {
            get { return BackingStore?.Get<WindowsUpdateInstallScheduleType>(nameof(InstallationSchedule)); }
            set { BackingStore?.Set(nameof(InstallationSchedule), value); }
        }
        /// <summary>Allow Microsoft Update Service</summary>
        public bool? MicrosoftUpdateServiceAllowed {
            get { return BackingStore?.Get<bool?>(nameof(MicrosoftUpdateServiceAllowed)); }
            set { BackingStore?.Set(nameof(MicrosoftUpdateServiceAllowed), value); }
        }
        /// <summary>The pre-release features. Possible values are: userDefined, settingsOnly, settingsAndExperimentations, notAllowed.</summary>
        public Microsoft.Graph.Models.PrereleaseFeatures? PrereleaseFeatures {
            get { return BackingStore?.Get<Microsoft.Graph.Models.PrereleaseFeatures?>(nameof(PrereleaseFeatures)); }
            set { BackingStore?.Set(nameof(PrereleaseFeatures), value); }
        }
        /// <summary>Defer Quality Updates by these many days</summary>
        public int? QualityUpdatesDeferralPeriodInDays {
            get { return BackingStore?.Get<int?>(nameof(QualityUpdatesDeferralPeriodInDays)); }
            set { BackingStore?.Set(nameof(QualityUpdatesDeferralPeriodInDays), value); }
        }
        /// <summary>Pause Quality Updates</summary>
        public bool? QualityUpdatesPaused {
            get { return BackingStore?.Get<bool?>(nameof(QualityUpdatesPaused)); }
            set { BackingStore?.Set(nameof(QualityUpdatesPaused), value); }
        }
        /// <summary>Quality Updates Pause Expiry datetime</summary>
        public DateTimeOffset? QualityUpdatesPauseExpiryDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(QualityUpdatesPauseExpiryDateTime)); }
            set { BackingStore?.Set(nameof(QualityUpdatesPauseExpiryDateTime), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsUpdateForBusinessConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsUpdateForBusinessConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"automaticUpdateMode", n => { AutomaticUpdateMode = n.GetEnumValue<AutomaticUpdateMode>(); } },
                {"businessReadyUpdatesOnly", n => { BusinessReadyUpdatesOnly = n.GetEnumValue<WindowsUpdateType>(); } },
                {"deliveryOptimizationMode", n => { DeliveryOptimizationMode = n.GetEnumValue<WindowsDeliveryOptimizationMode>(); } },
                {"driversExcluded", n => { DriversExcluded = n.GetBoolValue(); } },
                {"featureUpdatesDeferralPeriodInDays", n => { FeatureUpdatesDeferralPeriodInDays = n.GetIntValue(); } },
                {"featureUpdatesPaused", n => { FeatureUpdatesPaused = n.GetBoolValue(); } },
                {"featureUpdatesPauseExpiryDateTime", n => { FeatureUpdatesPauseExpiryDateTime = n.GetDateTimeOffsetValue(); } },
                {"installationSchedule", n => { InstallationSchedule = n.GetObjectValue<WindowsUpdateInstallScheduleType>(WindowsUpdateInstallScheduleType.CreateFromDiscriminatorValue); } },
                {"microsoftUpdateServiceAllowed", n => { MicrosoftUpdateServiceAllowed = n.GetBoolValue(); } },
                {"prereleaseFeatures", n => { PrereleaseFeatures = n.GetEnumValue<PrereleaseFeatures>(); } },
                {"qualityUpdatesDeferralPeriodInDays", n => { QualityUpdatesDeferralPeriodInDays = n.GetIntValue(); } },
                {"qualityUpdatesPaused", n => { QualityUpdatesPaused = n.GetBoolValue(); } },
                {"qualityUpdatesPauseExpiryDateTime", n => { QualityUpdatesPauseExpiryDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<AutomaticUpdateMode>("automaticUpdateMode", AutomaticUpdateMode);
            writer.WriteEnumValue<WindowsUpdateType>("businessReadyUpdatesOnly", BusinessReadyUpdatesOnly);
            writer.WriteEnumValue<WindowsDeliveryOptimizationMode>("deliveryOptimizationMode", DeliveryOptimizationMode);
            writer.WriteBoolValue("driversExcluded", DriversExcluded);
            writer.WriteIntValue("featureUpdatesDeferralPeriodInDays", FeatureUpdatesDeferralPeriodInDays);
            writer.WriteBoolValue("featureUpdatesPaused", FeatureUpdatesPaused);
            writer.WriteDateTimeOffsetValue("featureUpdatesPauseExpiryDateTime", FeatureUpdatesPauseExpiryDateTime);
            writer.WriteObjectValue<WindowsUpdateInstallScheduleType>("installationSchedule", InstallationSchedule);
            writer.WriteBoolValue("microsoftUpdateServiceAllowed", MicrosoftUpdateServiceAllowed);
            writer.WriteEnumValue<PrereleaseFeatures>("prereleaseFeatures", PrereleaseFeatures);
            writer.WriteIntValue("qualityUpdatesDeferralPeriodInDays", QualityUpdatesDeferralPeriodInDays);
            writer.WriteBoolValue("qualityUpdatesPaused", QualityUpdatesPaused);
            writer.WriteDateTimeOffsetValue("qualityUpdatesPauseExpiryDateTime", QualityUpdatesPauseExpiryDateTime);
        }
    }
}
