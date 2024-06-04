// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class EducationRubricOutcome : Microsoft.Graph.Models.EducationOutcome, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A copy of the rubricQualityFeedback property that is made when the grade is released to the student.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.RubricQualityFeedbackModel>? PublishedRubricQualityFeedback
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.RubricQualityFeedbackModel>?>("publishedRubricQualityFeedback"); }
            set { BackingStore?.Set("publishedRubricQualityFeedback", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.RubricQualityFeedbackModel> PublishedRubricQualityFeedback
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.RubricQualityFeedbackModel>>("publishedRubricQualityFeedback"); }
            set { BackingStore?.Set("publishedRubricQualityFeedback", value); }
        }
#endif
        /// <summary>A copy of the rubricQualitySelectedLevels property that is made when the grade is released to the student.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.RubricQualitySelectedColumnModel>? PublishedRubricQualitySelectedLevels
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.RubricQualitySelectedColumnModel>?>("publishedRubricQualitySelectedLevels"); }
            set { BackingStore?.Set("publishedRubricQualitySelectedLevels", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.RubricQualitySelectedColumnModel> PublishedRubricQualitySelectedLevels
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.RubricQualitySelectedColumnModel>>("publishedRubricQualitySelectedLevels"); }
            set { BackingStore?.Set("publishedRubricQualitySelectedLevels", value); }
        }
#endif
        /// <summary>A collection of specific feedback for each quality of this rubric.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.RubricQualityFeedbackModel>? RubricQualityFeedback
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.RubricQualityFeedbackModel>?>("rubricQualityFeedback"); }
            set { BackingStore?.Set("rubricQualityFeedback", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.RubricQualityFeedbackModel> RubricQualityFeedback
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.RubricQualityFeedbackModel>>("rubricQualityFeedback"); }
            set { BackingStore?.Set("rubricQualityFeedback", value); }
        }
#endif
        /// <summary>The level that the teacher has selected for each quality while grading this assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.RubricQualitySelectedColumnModel>? RubricQualitySelectedLevels
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.RubricQualitySelectedColumnModel>?>("rubricQualitySelectedLevels"); }
            set { BackingStore?.Set("rubricQualitySelectedLevels", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.RubricQualitySelectedColumnModel> RubricQualitySelectedLevels
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.RubricQualitySelectedColumnModel>>("rubricQualitySelectedLevels"); }
            set { BackingStore?.Set("rubricQualitySelectedLevels", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Models.EducationRubricOutcome"/> and sets the default values.
        /// </summary>
        public EducationRubricOutcome() : base()
        {
            OdataType = "#microsoft.graph.educationRubricOutcome";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.EducationRubricOutcome"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.EducationRubricOutcome CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.EducationRubricOutcome();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "publishedRubricQualityFeedback", n => { PublishedRubricQualityFeedback = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.RubricQualityFeedbackModel>(Microsoft.Graph.Models.RubricQualityFeedbackModel.CreateFromDiscriminatorValue)?.ToList(); } },
                { "publishedRubricQualitySelectedLevels", n => { PublishedRubricQualitySelectedLevels = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.RubricQualitySelectedColumnModel>(Microsoft.Graph.Models.RubricQualitySelectedColumnModel.CreateFromDiscriminatorValue)?.ToList(); } },
                { "rubricQualityFeedback", n => { RubricQualityFeedback = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.RubricQualityFeedbackModel>(Microsoft.Graph.Models.RubricQualityFeedbackModel.CreateFromDiscriminatorValue)?.ToList(); } },
                { "rubricQualitySelectedLevels", n => { RubricQualitySelectedLevels = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.RubricQualitySelectedColumnModel>(Microsoft.Graph.Models.RubricQualitySelectedColumnModel.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.RubricQualityFeedbackModel>("publishedRubricQualityFeedback", PublishedRubricQualityFeedback);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.RubricQualitySelectedColumnModel>("publishedRubricQualitySelectedLevels", PublishedRubricQualitySelectedLevels);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.RubricQualityFeedbackModel>("rubricQualityFeedback", RubricQualityFeedback);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.RubricQualitySelectedColumnModel>("rubricQualitySelectedLevels", RubricQualitySelectedLevels);
        }
    }
}
