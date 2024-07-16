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
    public partial class LearningCourseActivity : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Date and time when the assignment was completed. Optional.</summary>
        public DateTimeOffset? CompletedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("completedDateTime"); }
            set { BackingStore?.Set("completedDateTime", value); }
        }
        /// <summary>The percentage completion value of the course activity. Optional.</summary>
        public int? CompletionPercentage
        {
            get { return BackingStore?.Get<int?>("completionPercentage"); }
            set { BackingStore?.Set("completionPercentage", value); }
        }
        /// <summary>The externalcourseActivityId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalcourseActivityId
        {
            get { return BackingStore?.Get<string?>("externalcourseActivityId"); }
            set { BackingStore?.Set("externalcourseActivityId", value); }
        }
#nullable restore
#else
        public string ExternalcourseActivityId
        {
            get { return BackingStore?.Get<string>("externalcourseActivityId"); }
            set { BackingStore?.Set("externalcourseActivityId", value); }
        }
#endif
        /// <summary>The user ID of the learner to whom the activity is assigned. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LearnerUserId
        {
            get { return BackingStore?.Get<string?>("learnerUserId"); }
            set { BackingStore?.Set("learnerUserId", value); }
        }
#nullable restore
#else
        public string LearnerUserId
        {
            get { return BackingStore?.Get<string>("learnerUserId"); }
            set { BackingStore?.Set("learnerUserId", value); }
        }
#endif
        /// <summary>The ID of the learning content created in Viva Learning. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LearningContentId
        {
            get { return BackingStore?.Get<string?>("learningContentId"); }
            set { BackingStore?.Set("learningContentId", value); }
        }
#nullable restore
#else
        public string LearningContentId
        {
            get { return BackingStore?.Get<string>("learningContentId"); }
            set { BackingStore?.Set("learningContentId", value); }
        }
#endif
        /// <summary>The registration ID of the provider. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LearningProviderId
        {
            get { return BackingStore?.Get<string?>("learningProviderId"); }
            set { BackingStore?.Set("learningProviderId", value); }
        }
#nullable restore
#else
        public string LearningProviderId
        {
            get { return BackingStore?.Get<string>("learningProviderId"); }
            set { BackingStore?.Set("learningProviderId", value); }
        }
#endif
        /// <summary>The status of the course activity. Possible values are: notStarted, inProgress, completed. Required.</summary>
        public global::Microsoft.Graph.Models.CourseStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CourseStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.LearningCourseActivity"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.LearningCourseActivity CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.learningAssignment" => new global::Microsoft.Graph.Models.LearningAssignment(),
                "#microsoft.graph.learningSelfInitiatedCourse" => new global::Microsoft.Graph.Models.LearningSelfInitiatedCourse(),
                _ => new global::Microsoft.Graph.Models.LearningCourseActivity(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "completedDateTime", n => { CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                { "completionPercentage", n => { CompletionPercentage = n.GetIntValue(); } },
                { "externalcourseActivityId", n => { ExternalcourseActivityId = n.GetStringValue(); } },
                { "learnerUserId", n => { LearnerUserId = n.GetStringValue(); } },
                { "learningContentId", n => { LearningContentId = n.GetStringValue(); } },
                { "learningProviderId", n => { LearningProviderId = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Microsoft.Graph.Models.CourseStatus>(); } },
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
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteIntValue("completionPercentage", CompletionPercentage);
            writer.WriteStringValue("externalcourseActivityId", ExternalcourseActivityId);
            writer.WriteStringValue("learnerUserId", LearnerUserId);
            writer.WriteStringValue("learningContentId", LearningContentId);
            writer.WriteStringValue("learningProviderId", LearningProviderId);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.CourseStatus>("status", Status);
        }
    }
}
