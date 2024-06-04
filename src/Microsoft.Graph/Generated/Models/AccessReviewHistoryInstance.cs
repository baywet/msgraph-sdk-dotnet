// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class AccessReviewHistoryInstance : Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Uri that can be used to retrieve review history data. This URI will be active for 24 hours after being generated. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DownloadUri
        {
            get { return BackingStore?.Get<string?>("downloadUri"); }
            set { BackingStore?.Set("downloadUri", value); }
        }
#nullable restore
#else
        public string DownloadUri
        {
            get { return BackingStore?.Get<string>("downloadUri"); }
            set { BackingStore?.Set("downloadUri", value); }
        }
#endif
        /// <summary>Timestamp when this instance and associated data expires and the history is deleted. Required.</summary>
        public DateTimeOffset? ExpirationDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>Timestamp when all of the available data for this instance was collected and is set after this instance&apos;s status is set to done. Required.</summary>
        public DateTimeOffset? FulfilledDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("fulfilledDateTime"); }
            set { BackingStore?.Set("fulfilledDateTime", value); }
        }
        /// <summary>Timestamp reviews ending on or before this date will be included in the fetched history data.</summary>
        public DateTimeOffset? ReviewHistoryPeriodEndDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("reviewHistoryPeriodEndDateTime"); }
            set { BackingStore?.Set("reviewHistoryPeriodEndDateTime", value); }
        }
        /// <summary>Timestamp reviews starting on or after this date will be included in the fetched history data.</summary>
        public DateTimeOffset? ReviewHistoryPeriodStartDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("reviewHistoryPeriodStartDateTime"); }
            set { BackingStore?.Set("reviewHistoryPeriodStartDateTime", value); }
        }
        /// <summary>Timestamp when the instance&apos;s history data is scheduled to be generated.</summary>
        public DateTimeOffset? RunDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("runDateTime"); }
            set { BackingStore?.Set("runDateTime", value); }
        }
        /// <summary>Represents the status of the review history data collection. The possible values are: done, inProgress, error, requested, unknownFutureValue. Once the status has been marked as done, a link can be generated to retrieve the instance&apos;s data by calling generateDownloadUri method.</summary>
        public Microsoft.Graph.Models.AccessReviewHistoryStatus? Status
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AccessReviewHistoryStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.AccessReviewHistoryInstance"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.AccessReviewHistoryInstance CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.AccessReviewHistoryInstance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "downloadUri", n => { DownloadUri = n.GetStringValue(); } },
                { "expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                { "fulfilledDateTime", n => { FulfilledDateTime = n.GetDateTimeOffsetValue(); } },
                { "reviewHistoryPeriodEndDateTime", n => { ReviewHistoryPeriodEndDateTime = n.GetDateTimeOffsetValue(); } },
                { "reviewHistoryPeriodStartDateTime", n => { ReviewHistoryPeriodStartDateTime = n.GetDateTimeOffsetValue(); } },
                { "runDateTime", n => { RunDateTime = n.GetDateTimeOffsetValue(); } },
                { "status", n => { Status = n.GetEnumValue<Microsoft.Graph.Models.AccessReviewHistoryStatus>(); } },
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
            writer.WriteStringValue("downloadUri", DownloadUri);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteDateTimeOffsetValue("fulfilledDateTime", FulfilledDateTime);
            writer.WriteDateTimeOffsetValue("reviewHistoryPeriodEndDateTime", ReviewHistoryPeriodEndDateTime);
            writer.WriteDateTimeOffsetValue("reviewHistoryPeriodStartDateTime", ReviewHistoryPeriodStartDateTime);
            writer.WriteDateTimeOffsetValue("runDateTime", RunDateTime);
            writer.WriteEnumValue<Microsoft.Graph.Models.AccessReviewHistoryStatus>("status", Status);
        }
    }
}
