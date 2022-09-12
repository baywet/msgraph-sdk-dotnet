using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>A termsAndConditionsAcceptanceStatus entity represents the acceptance status of a given Terms and Conditions (T&amp;C) policy by a given user. Users must accept the most up-to-date version of the terms in order to retain access to the Company Portal.</summary>
    public class TermsAndConditionsAcceptanceStatus : Entity, IParsable {
        /// <summary>DateTime when the terms were last accepted by the user.</summary>
        public DateTimeOffset? AcceptedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("acceptedDateTime"); }
            set { BackingStore?.Set("acceptedDateTime", value); }
        }
        /// <summary>Most recent version number of the T&amp;C accepted by the user.</summary>
        public int? AcceptedVersion {
            get { return BackingStore?.Get<int?>("acceptedVersion"); }
            set { BackingStore?.Set("acceptedVersion", value); }
        }
        /// <summary>Navigation link to the terms and conditions that are assigned.</summary>
        public Microsoft.Graph.Models.TermsAndConditions TermsAndConditions {
            get { return BackingStore?.Get<Microsoft.Graph.Models.TermsAndConditions>("termsAndConditions"); }
            set { BackingStore?.Set("termsAndConditions", value); }
        }
        /// <summary>Display name of the user whose acceptance the entity represents.</summary>
        public string UserDisplayName {
            get { return BackingStore?.Get<string>("userDisplayName"); }
            set { BackingStore?.Set("userDisplayName", value); }
        }
        /// <summary>The userPrincipalName of the User that accepted the term.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
        /// <summary>
        /// Instantiates a new termsAndConditionsAcceptanceStatus and sets the default values.
        /// </summary>
        public TermsAndConditionsAcceptanceStatus() : base() {
            OdataType = "#microsoft.graph.termsAndConditionsAcceptanceStatus";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TermsAndConditionsAcceptanceStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TermsAndConditionsAcceptanceStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"acceptedDateTime", n => { AcceptedDateTime = n.GetDateTimeOffsetValue(); } },
                {"acceptedVersion", n => { AcceptedVersion = n.GetIntValue(); } },
                {"termsAndConditions", n => { TermsAndConditions = n.GetObjectValue<Microsoft.Graph.Models.TermsAndConditions>(Microsoft.Graph.Models.TermsAndConditions.CreateFromDiscriminatorValue); } },
                {"userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("acceptedDateTime", AcceptedDateTime);
            writer.WriteIntValue("acceptedVersion", AcceptedVersion);
            writer.WriteObjectValue<Microsoft.Graph.Models.TermsAndConditions>("termsAndConditions", TermsAndConditions);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}