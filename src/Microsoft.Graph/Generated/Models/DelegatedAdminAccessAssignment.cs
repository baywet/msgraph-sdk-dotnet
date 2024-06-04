// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class DelegatedAdminAccessAssignment : Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The accessContainer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.DelegatedAdminAccessContainer? AccessContainer
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DelegatedAdminAccessContainer?>("accessContainer"); }
            set { BackingStore?.Set("accessContainer", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.DelegatedAdminAccessContainer AccessContainer
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DelegatedAdminAccessContainer>("accessContainer"); }
            set { BackingStore?.Set("accessContainer", value); }
        }
#endif
        /// <summary>The accessDetails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.DelegatedAdminAccessDetails? AccessDetails
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DelegatedAdminAccessDetails?>("accessDetails"); }
            set { BackingStore?.Set("accessDetails", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.DelegatedAdminAccessDetails AccessDetails
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DelegatedAdminAccessDetails>("accessDetails"); }
            set { BackingStore?.Set("accessDetails", value); }
        }
#endif
        /// <summary>The date and time in ISO 8601 format and in UTC time when the access assignment was created. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The date and time in ISO 8601 and in UTC time when this access assignment was last modified. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The status of the access assignment. Read-only. The possible values are: pending, active, deleting, deleted, error, unknownFutureValue.</summary>
        public Microsoft.Graph.Models.DelegatedAdminAccessAssignmentStatus? Status
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DelegatedAdminAccessAssignmentStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.DelegatedAdminAccessAssignment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.DelegatedAdminAccessAssignment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.DelegatedAdminAccessAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accessContainer", n => { AccessContainer = n.GetObjectValue<Microsoft.Graph.Models.DelegatedAdminAccessContainer>(Microsoft.Graph.Models.DelegatedAdminAccessContainer.CreateFromDiscriminatorValue); } },
                { "accessDetails", n => { AccessDetails = n.GetObjectValue<Microsoft.Graph.Models.DelegatedAdminAccessDetails>(Microsoft.Graph.Models.DelegatedAdminAccessDetails.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "status", n => { Status = n.GetEnumValue<Microsoft.Graph.Models.DelegatedAdminAccessAssignmentStatus>(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Models.DelegatedAdminAccessContainer>("accessContainer", AccessContainer);
            writer.WriteObjectValue<Microsoft.Graph.Models.DelegatedAdminAccessDetails>("accessDetails", AccessDetails);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<Microsoft.Graph.Models.DelegatedAdminAccessAssignmentStatus>("status", Status);
        }
    }
}
