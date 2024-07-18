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
    public partial class Schedule : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Indicates whether the schedule is enabled for the team. Required.</summary>
        public bool? Enabled
        {
            get { return BackingStore?.Get<bool?>("enabled"); }
            set { BackingStore?.Set("enabled", value); }
        }
        /// <summary>The offer requests for shifts in the schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.OfferShiftRequest>? OfferShiftRequests
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.OfferShiftRequest>?>("offerShiftRequests"); }
            set { BackingStore?.Set("offerShiftRequests", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.OfferShiftRequest> OfferShiftRequests
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.OfferShiftRequest>>("offerShiftRequests"); }
            set { BackingStore?.Set("offerShiftRequests", value); }
        }
#endif
        /// <summary>Indicates whether offer shift requests are enabled for the schedule.</summary>
        public bool? OfferShiftRequestsEnabled
        {
            get { return BackingStore?.Get<bool?>("offerShiftRequestsEnabled"); }
            set { BackingStore?.Set("offerShiftRequestsEnabled", value); }
        }
        /// <summary>The open shift requests in the schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.OpenShiftChangeRequest>? OpenShiftChangeRequests
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.OpenShiftChangeRequest>?>("openShiftChangeRequests"); }
            set { BackingStore?.Set("openShiftChangeRequests", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.OpenShiftChangeRequest> OpenShiftChangeRequests
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.OpenShiftChangeRequest>>("openShiftChangeRequests"); }
            set { BackingStore?.Set("openShiftChangeRequests", value); }
        }
#endif
        /// <summary>The set of open shifts in a scheduling group in the schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.OpenShift>? OpenShifts
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.OpenShift>?>("openShifts"); }
            set { BackingStore?.Set("openShifts", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.OpenShift> OpenShifts
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.OpenShift>>("openShifts"); }
            set { BackingStore?.Set("openShifts", value); }
        }
#endif
        /// <summary>Indicates whether open shifts are enabled for the schedule.</summary>
        public bool? OpenShiftsEnabled
        {
            get { return BackingStore?.Get<bool?>("openShiftsEnabled"); }
            set { BackingStore?.Set("openShiftsEnabled", value); }
        }
        /// <summary>The status of the schedule provisioning. The possible values are notStarted, running, completed, failed.</summary>
        public global::Microsoft.Graph.Models.OperationStatus? ProvisionStatus
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.OperationStatus?>("provisionStatus"); }
            set { BackingStore?.Set("provisionStatus", value); }
        }
        /// <summary>Additional information about why schedule provisioning failed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProvisionStatusCode
        {
            get { return BackingStore?.Get<string?>("provisionStatusCode"); }
            set { BackingStore?.Set("provisionStatusCode", value); }
        }
#nullable restore
#else
        public string ProvisionStatusCode
        {
            get { return BackingStore?.Get<string>("provisionStatusCode"); }
            set { BackingStore?.Set("provisionStatusCode", value); }
        }
#endif
        /// <summary>The logical grouping of users in the schedule (usually by role).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.SchedulingGroup>? SchedulingGroups
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SchedulingGroup>?>("schedulingGroups"); }
            set { BackingStore?.Set("schedulingGroups", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.SchedulingGroup> SchedulingGroups
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SchedulingGroup>>("schedulingGroups"); }
            set { BackingStore?.Set("schedulingGroups", value); }
        }
#endif
        /// <summary>The shifts in the schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Shift>? Shifts
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Shift>?>("shifts"); }
            set { BackingStore?.Set("shifts", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Shift> Shifts
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Shift>>("shifts"); }
            set { BackingStore?.Set("shifts", value); }
        }
#endif
        /// <summary>The swap requests for shifts in the schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.SwapShiftsChangeRequest>? SwapShiftsChangeRequests
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SwapShiftsChangeRequest>?>("swapShiftsChangeRequests"); }
            set { BackingStore?.Set("swapShiftsChangeRequests", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.SwapShiftsChangeRequest> SwapShiftsChangeRequests
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SwapShiftsChangeRequest>>("swapShiftsChangeRequests"); }
            set { BackingStore?.Set("swapShiftsChangeRequests", value); }
        }
#endif
        /// <summary>Indicates whether swap shifts requests are enabled for the schedule.</summary>
        public bool? SwapShiftsRequestsEnabled
        {
            get { return BackingStore?.Get<bool?>("swapShiftsRequestsEnabled"); }
            set { BackingStore?.Set("swapShiftsRequestsEnabled", value); }
        }
        /// <summary>Indicates whether time clock is enabled for the schedule.</summary>
        public bool? TimeClockEnabled
        {
            get { return BackingStore?.Get<bool?>("timeClockEnabled"); }
            set { BackingStore?.Set("timeClockEnabled", value); }
        }
        /// <summary>The set of reasons for a time off in the schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.TimeOffReason>? TimeOffReasons
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TimeOffReason>?>("timeOffReasons"); }
            set { BackingStore?.Set("timeOffReasons", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.TimeOffReason> TimeOffReasons
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TimeOffReason>>("timeOffReasons"); }
            set { BackingStore?.Set("timeOffReasons", value); }
        }
#endif
        /// <summary>The time off requests in the schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.TimeOffRequest>? TimeOffRequests
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TimeOffRequest>?>("timeOffRequests"); }
            set { BackingStore?.Set("timeOffRequests", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.TimeOffRequest> TimeOffRequests
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TimeOffRequest>>("timeOffRequests"); }
            set { BackingStore?.Set("timeOffRequests", value); }
        }
#endif
        /// <summary>Indicates whether time off requests are enabled for the schedule.</summary>
        public bool? TimeOffRequestsEnabled
        {
            get { return BackingStore?.Get<bool?>("timeOffRequestsEnabled"); }
            set { BackingStore?.Set("timeOffRequestsEnabled", value); }
        }
        /// <summary>The instances of times off in the schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.TimeOff>? TimesOff
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TimeOff>?>("timesOff"); }
            set { BackingStore?.Set("timesOff", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.TimeOff> TimesOff
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TimeOff>>("timesOff"); }
            set { BackingStore?.Set("timesOff", value); }
        }
#endif
        /// <summary>Indicates the time zone of the schedule team using tz database format. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimeZone
        {
            get { return BackingStore?.Get<string?>("timeZone"); }
            set { BackingStore?.Set("timeZone", value); }
        }
#nullable restore
#else
        public string TimeZone
        {
            get { return BackingStore?.Get<string>("timeZone"); }
            set { BackingStore?.Set("timeZone", value); }
        }
#endif
        /// <summary>The workforceIntegrationIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? WorkforceIntegrationIds
        {
            get { return BackingStore?.Get<List<string>?>("workforceIntegrationIds"); }
            set { BackingStore?.Set("workforceIntegrationIds", value); }
        }
#nullable restore
#else
        public List<string> WorkforceIntegrationIds
        {
            get { return BackingStore?.Get<List<string>>("workforceIntegrationIds"); }
            set { BackingStore?.Set("workforceIntegrationIds", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Schedule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Schedule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Schedule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "enabled", n => { Enabled = n.GetBoolValue(); } },
                { "offerShiftRequests", n => { OfferShiftRequests = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.OfferShiftRequest>(global::Microsoft.Graph.Models.OfferShiftRequest.CreateFromDiscriminatorValue)?.AsList(); } },
                { "offerShiftRequestsEnabled", n => { OfferShiftRequestsEnabled = n.GetBoolValue(); } },
                { "openShiftChangeRequests", n => { OpenShiftChangeRequests = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.OpenShiftChangeRequest>(global::Microsoft.Graph.Models.OpenShiftChangeRequest.CreateFromDiscriminatorValue)?.AsList(); } },
                { "openShifts", n => { OpenShifts = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.OpenShift>(global::Microsoft.Graph.Models.OpenShift.CreateFromDiscriminatorValue)?.AsList(); } },
                { "openShiftsEnabled", n => { OpenShiftsEnabled = n.GetBoolValue(); } },
                { "provisionStatus", n => { ProvisionStatus = n.GetEnumValue<global::Microsoft.Graph.Models.OperationStatus>(); } },
                { "provisionStatusCode", n => { ProvisionStatusCode = n.GetStringValue(); } },
                { "schedulingGroups", n => { SchedulingGroups = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.SchedulingGroup>(global::Microsoft.Graph.Models.SchedulingGroup.CreateFromDiscriminatorValue)?.AsList(); } },
                { "shifts", n => { Shifts = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Shift>(global::Microsoft.Graph.Models.Shift.CreateFromDiscriminatorValue)?.AsList(); } },
                { "swapShiftsChangeRequests", n => { SwapShiftsChangeRequests = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.SwapShiftsChangeRequest>(global::Microsoft.Graph.Models.SwapShiftsChangeRequest.CreateFromDiscriminatorValue)?.AsList(); } },
                { "swapShiftsRequestsEnabled", n => { SwapShiftsRequestsEnabled = n.GetBoolValue(); } },
                { "timeClockEnabled", n => { TimeClockEnabled = n.GetBoolValue(); } },
                { "timeOffReasons", n => { TimeOffReasons = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.TimeOffReason>(global::Microsoft.Graph.Models.TimeOffReason.CreateFromDiscriminatorValue)?.AsList(); } },
                { "timeOffRequests", n => { TimeOffRequests = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.TimeOffRequest>(global::Microsoft.Graph.Models.TimeOffRequest.CreateFromDiscriminatorValue)?.AsList(); } },
                { "timeOffRequestsEnabled", n => { TimeOffRequestsEnabled = n.GetBoolValue(); } },
                { "timeZone", n => { TimeZone = n.GetStringValue(); } },
                { "timesOff", n => { TimesOff = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.TimeOff>(global::Microsoft.Graph.Models.TimeOff.CreateFromDiscriminatorValue)?.AsList(); } },
                { "workforceIntegrationIds", n => { WorkforceIntegrationIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
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
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.OfferShiftRequest>("offerShiftRequests", OfferShiftRequests);
            writer.WriteBoolValue("offerShiftRequestsEnabled", OfferShiftRequestsEnabled);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.OpenShiftChangeRequest>("openShiftChangeRequests", OpenShiftChangeRequests);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.OpenShift>("openShifts", OpenShifts);
            writer.WriteBoolValue("openShiftsEnabled", OpenShiftsEnabled);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.SchedulingGroup>("schedulingGroups", SchedulingGroups);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Shift>("shifts", Shifts);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.SwapShiftsChangeRequest>("swapShiftsChangeRequests", SwapShiftsChangeRequests);
            writer.WriteBoolValue("swapShiftsRequestsEnabled", SwapShiftsRequestsEnabled);
            writer.WriteBoolValue("timeClockEnabled", TimeClockEnabled);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.TimeOffReason>("timeOffReasons", TimeOffReasons);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.TimeOffRequest>("timeOffRequests", TimeOffRequests);
            writer.WriteBoolValue("timeOffRequestsEnabled", TimeOffRequestsEnabled);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.TimeOff>("timesOff", TimesOff);
            writer.WriteStringValue("timeZone", TimeZone);
            writer.WriteCollectionOfPrimitiveValues<string>("workforceIntegrationIds", WorkforceIntegrationIds);
        }
    }
}
