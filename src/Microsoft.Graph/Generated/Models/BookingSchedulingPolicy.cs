// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>
    /// This type represents the set of policies that dictate how bookings can be created in a Booking Calendar.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class BookingSchedulingPolicy : IAdditionalDataHolder, IBackedModel, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>True if to allow customers to choose a specific person for the booking.</summary>
        public bool? AllowStaffSelection
        {
            get { return BackingStore?.Get<bool?>("allowStaffSelection"); }
            set { BackingStore?.Set("allowStaffSelection", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Maximum number of days in advance that a booking can be made. It follows the ISO 8601 format.</summary>
        public TimeSpan? MaximumAdvance
        {
            get { return BackingStore?.Get<TimeSpan?>("maximumAdvance"); }
            set { BackingStore?.Set("maximumAdvance", value); }
        }
        /// <summary>The minimum amount of time before which bookings and cancellations must be made. It follows the ISO 8601 format.</summary>
        public TimeSpan? MinimumLeadTime
        {
            get { return BackingStore?.Get<TimeSpan?>("minimumLeadTime"); }
            set { BackingStore?.Set("minimumLeadTime", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>True to notify the business via email when a booking is created or changed. Use the email address specified in the email property of the bookingBusiness entity for the business.</summary>
        public bool? SendConfirmationsToOwner
        {
            get { return BackingStore?.Get<bool?>("sendConfirmationsToOwner"); }
            set { BackingStore?.Set("sendConfirmationsToOwner", value); }
        }
        /// <summary>Duration of each time slot, denoted in ISO 8601 format.</summary>
        public TimeSpan? TimeSlotInterval
        {
            get { return BackingStore?.Get<TimeSpan?>("timeSlotInterval"); }
            set { BackingStore?.Set("timeSlotInterval", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.BookingSchedulingPolicy"/> and sets the default values.
        /// </summary>
        public BookingSchedulingPolicy()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.BookingSchedulingPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.BookingSchedulingPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.BookingSchedulingPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allowStaffSelection", n => { AllowStaffSelection = n.GetBoolValue(); } },
                { "maximumAdvance", n => { MaximumAdvance = n.GetTimeSpanValue(); } },
                { "minimumLeadTime", n => { MinimumLeadTime = n.GetTimeSpanValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "sendConfirmationsToOwner", n => { SendConfirmationsToOwner = n.GetBoolValue(); } },
                { "timeSlotInterval", n => { TimeSlotInterval = n.GetTimeSpanValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowStaffSelection", AllowStaffSelection);
            writer.WriteTimeSpanValue("maximumAdvance", MaximumAdvance);
            writer.WriteTimeSpanValue("minimumLeadTime", MinimumLeadTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("sendConfirmationsToOwner", SendConfirmationsToOwner);
            writer.WriteTimeSpanValue("timeSlotInterval", TimeSlotInterval);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
