using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
    public class AuditLogRoot : Entity, IParsable {
        /// <summary>The directoryAudits property</summary>
        public List<DirectoryAudit> DirectoryAudits {
            get { return BackingStore?.Get<List<DirectoryAudit>>(nameof(DirectoryAudits)); }
            set { BackingStore?.Set(nameof(DirectoryAudits), value); }
        }
        /// <summary>The provisioning property</summary>
        public List<ProvisioningObjectSummary> Provisioning {
            get { return BackingStore?.Get<List<ProvisioningObjectSummary>>(nameof(Provisioning)); }
            set { BackingStore?.Set(nameof(Provisioning), value); }
        }
        /// <summary>The restrictedSignIns property</summary>
        public List<RestrictedSignIn> RestrictedSignIns {
            get { return BackingStore?.Get<List<RestrictedSignIn>>(nameof(RestrictedSignIns)); }
            set { BackingStore?.Set(nameof(RestrictedSignIns), value); }
        }
        /// <summary>The signIns property</summary>
        public List<SignIn> SignIns {
            get { return BackingStore?.Get<List<SignIn>>(nameof(SignIns)); }
            set { BackingStore?.Set(nameof(SignIns), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AuditLogRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuditLogRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"directoryAudits", n => { DirectoryAudits = n.GetCollectionOfObjectValues<DirectoryAudit>(DirectoryAudit.CreateFromDiscriminatorValue).ToList(); } },
                {"provisioning", n => { Provisioning = n.GetCollectionOfObjectValues<ProvisioningObjectSummary>(ProvisioningObjectSummary.CreateFromDiscriminatorValue).ToList(); } },
                {"restrictedSignIns", n => { RestrictedSignIns = n.GetCollectionOfObjectValues<RestrictedSignIn>(RestrictedSignIn.CreateFromDiscriminatorValue).ToList(); } },
                {"signIns", n => { SignIns = n.GetCollectionOfObjectValues<SignIn>(SignIn.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DirectoryAudit>("directoryAudits", DirectoryAudits);
            writer.WriteCollectionOfObjectValues<ProvisioningObjectSummary>("provisioning", Provisioning);
            writer.WriteCollectionOfObjectValues<RestrictedSignIn>("restrictedSignIns", RestrictedSignIns);
            writer.WriteCollectionOfObjectValues<SignIn>("signIns", SignIns);
        }
    }
}
