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
    public partial class EducationRubric : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The user who created this resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.IdentitySet? CreatedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentitySet?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.IdentitySet CreatedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentitySet>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The description of this rubric.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.EducationItemBody? Description
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EducationItemBody?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.EducationItemBody Description
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EducationItemBody>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The name of this rubric.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The grading type of this rubric -- null for a no-points rubric, or educationAssignmentPointsGradeType for a points rubric.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.EducationAssignmentGradeType? Grading
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EducationAssignmentGradeType?>("grading"); }
            set { BackingStore?.Set("grading", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.EducationAssignmentGradeType Grading
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EducationAssignmentGradeType>("grading"); }
            set { BackingStore?.Set("grading", value); }
        }
#endif
        /// <summary>The last user to modify the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.IdentitySet? LastModifiedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentitySet?>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.IdentitySet LastModifiedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentitySet>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#endif
        /// <summary>Moment in time when the resource was last modified.  The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The collection of levels making up this rubric.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.RubricLevel>? Levels
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.RubricLevel>?>("levels"); }
            set { BackingStore?.Set("levels", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.RubricLevel> Levels
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.RubricLevel>>("levels"); }
            set { BackingStore?.Set("levels", value); }
        }
#endif
        /// <summary>The collection of qualities making up this rubric.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.RubricQuality>? Qualities
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.RubricQuality>?>("qualities"); }
            set { BackingStore?.Set("qualities", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.RubricQuality> Qualities
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.RubricQuality>>("qualities"); }
            set { BackingStore?.Set("qualities", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.EducationRubric"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.EducationRubric CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.EducationRubric();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "createdBy", n => { CreatedBy = n.GetObjectValue<global::Microsoft.Graph.Models.IdentitySet>(global::Microsoft.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetObjectValue<global::Microsoft.Graph.Models.EducationItemBody>(global::Microsoft.Graph.Models.EducationItemBody.CreateFromDiscriminatorValue); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "grading", n => { Grading = n.GetObjectValue<global::Microsoft.Graph.Models.EducationAssignmentGradeType>(global::Microsoft.Graph.Models.EducationAssignmentGradeType.CreateFromDiscriminatorValue); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<global::Microsoft.Graph.Models.IdentitySet>(global::Microsoft.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "levels", n => { Levels = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.RubricLevel>(global::Microsoft.Graph.Models.RubricLevel.CreateFromDiscriminatorValue)?.AsList(); } },
                { "qualities", n => { Qualities = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.RubricQuality>(global::Microsoft.Graph.Models.RubricQuality.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.EducationItemBody>("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.EducationAssignmentGradeType>("grading", Grading);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.RubricLevel>("levels", Levels);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.RubricQuality>("qualities", Qualities);
        }
    }
}
