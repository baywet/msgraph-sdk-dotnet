using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.IdentityGovernance.EntitlementManagement.Catalogs.Item.AccessPackages.Item.GetApplicablePolicyRequirements {
    /// <summary>Provides operations to call the getApplicablePolicyRequirements method.</summary>
    public class GetApplicablePolicyRequirementsResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The value property</summary>
        public List<AccessPackageAssignmentRequestRequirements> Value { get; set; }
        /// <summary>
        /// Instantiates a new getApplicablePolicyRequirementsResponse and sets the default values.
        /// </summary>
        public GetApplicablePolicyRequirementsResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static GetApplicablePolicyRequirementsResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetApplicablePolicyRequirementsResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"value", n => { Value = n.GetCollectionOfObjectValues<AccessPackageAssignmentRequestRequirements>(AccessPackageAssignmentRequestRequirements.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<AccessPackageAssignmentRequestRequirements>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}