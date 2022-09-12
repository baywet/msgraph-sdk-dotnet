using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class MailboxSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Folder ID of an archive folder for the user.</summary>
        public string ArchiveFolder {
            get { return BackingStore?.Get<string>("archiveFolder"); }
            set { BackingStore?.Set("archiveFolder", value); }
        }
        /// <summary>Configuration settings to automatically notify the sender of an incoming email with a message from the signed-in user.</summary>
        public Microsoft.Graph.Models.AutomaticRepliesSetting AutomaticRepliesSetting {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AutomaticRepliesSetting>("automaticRepliesSetting"); }
            set { BackingStore?.Set("automaticRepliesSetting", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The date format for the user&apos;s mailbox.</summary>
        public string DateFormat {
            get { return BackingStore?.Get<string>("dateFormat"); }
            set { BackingStore?.Set("dateFormat", value); }
        }
        /// <summary>If the user has a calendar delegate, this specifies whether the delegate, mailbox owner, or both receive meeting messages and meeting responses. Possible values are: sendToDelegateAndInformationToPrincipal, sendToDelegateAndPrincipal, sendToDelegateOnly.</summary>
        public Microsoft.Graph.Models.DelegateMeetingMessageDeliveryOptions? DelegateMeetingMessageDeliveryOptions {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DelegateMeetingMessageDeliveryOptions?>("delegateMeetingMessageDeliveryOptions"); }
            set { BackingStore?.Set("delegateMeetingMessageDeliveryOptions", value); }
        }
        /// <summary>The locale information for the user, including the preferred language and country/region.</summary>
        public LocaleInfo Language {
            get { return BackingStore?.Get<LocaleInfo>("language"); }
            set { BackingStore?.Set("language", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The time format for the user&apos;s mailbox.</summary>
        public string TimeFormat {
            get { return BackingStore?.Get<string>("timeFormat"); }
            set { BackingStore?.Set("timeFormat", value); }
        }
        /// <summary>The default time zone for the user&apos;s mailbox.</summary>
        public string TimeZone {
            get { return BackingStore?.Get<string>("timeZone"); }
            set { BackingStore?.Set("timeZone", value); }
        }
        /// <summary>The userPurpose property</summary>
        public Microsoft.Graph.Models.UserPurpose? UserPurpose {
            get { return BackingStore?.Get<Microsoft.Graph.Models.UserPurpose?>("userPurpose"); }
            set { BackingStore?.Set("userPurpose", value); }
        }
        /// <summary>The days of the week and hours in a specific time zone that the user works.</summary>
        public Microsoft.Graph.Models.WorkingHours WorkingHours {
            get { return BackingStore?.Get<Microsoft.Graph.Models.WorkingHours>("workingHours"); }
            set { BackingStore?.Set("workingHours", value); }
        }
        /// <summary>
        /// Instantiates a new mailboxSettings and sets the default values.
        /// </summary>
        public MailboxSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.mailboxSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MailboxSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MailboxSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"archiveFolder", n => { ArchiveFolder = n.GetStringValue(); } },
                {"automaticRepliesSetting", n => { AutomaticRepliesSetting = n.GetObjectValue<Microsoft.Graph.Models.AutomaticRepliesSetting>(Microsoft.Graph.Models.AutomaticRepliesSetting.CreateFromDiscriminatorValue); } },
                {"dateFormat", n => { DateFormat = n.GetStringValue(); } },
                {"delegateMeetingMessageDeliveryOptions", n => { DelegateMeetingMessageDeliveryOptions = n.GetEnumValue<DelegateMeetingMessageDeliveryOptions>(); } },
                {"language", n => { Language = n.GetObjectValue<LocaleInfo>(LocaleInfo.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"timeFormat", n => { TimeFormat = n.GetStringValue(); } },
                {"timeZone", n => { TimeZone = n.GetStringValue(); } },
                {"userPurpose", n => { UserPurpose = n.GetEnumValue<UserPurpose>(); } },
                {"workingHours", n => { WorkingHours = n.GetObjectValue<Microsoft.Graph.Models.WorkingHours>(Microsoft.Graph.Models.WorkingHours.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("archiveFolder", ArchiveFolder);
            writer.WriteObjectValue<Microsoft.Graph.Models.AutomaticRepliesSetting>("automaticRepliesSetting", AutomaticRepliesSetting);
            writer.WriteStringValue("dateFormat", DateFormat);
            writer.WriteEnumValue<DelegateMeetingMessageDeliveryOptions>("delegateMeetingMessageDeliveryOptions", DelegateMeetingMessageDeliveryOptions);
            writer.WriteObjectValue<LocaleInfo>("language", Language);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("timeFormat", TimeFormat);
            writer.WriteStringValue("timeZone", TimeZone);
            writer.WriteEnumValue<UserPurpose>("userPurpose", UserPurpose);
            writer.WriteObjectValue<Microsoft.Graph.Models.WorkingHours>("workingHours", WorkingHours);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}