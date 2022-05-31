using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Groups.Item.Onenote.Notebooks.Item.CopyNotebook {
    /// <summary>Provides operations to call the copyNotebook method.</summary>
    public class CopyNotebookPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The groupId property</summary>
        public string GroupId {
            get { return BackingStore?.Get<string>(nameof(GroupId)); }
            set { BackingStore?.Set(nameof(GroupId), value); }
        }
        /// <summary>The notebookFolder property</summary>
        public string NotebookFolder {
            get { return BackingStore?.Get<string>(nameof(NotebookFolder)); }
            set { BackingStore?.Set(nameof(NotebookFolder), value); }
        }
        /// <summary>The renameAs property</summary>
        public string RenameAs {
            get { return BackingStore?.Get<string>(nameof(RenameAs)); }
            set { BackingStore?.Set(nameof(RenameAs), value); }
        }
        /// <summary>The siteCollectionId property</summary>
        public string SiteCollectionId {
            get { return BackingStore?.Get<string>(nameof(SiteCollectionId)); }
            set { BackingStore?.Set(nameof(SiteCollectionId), value); }
        }
        /// <summary>The siteId property</summary>
        public string SiteId {
            get { return BackingStore?.Get<string>(nameof(SiteId)); }
            set { BackingStore?.Set(nameof(SiteId), value); }
        }
        /// <summary>
        /// Instantiates a new copyNotebookPostRequestBody and sets the default values.
        /// </summary>
        public CopyNotebookPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CopyNotebookPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CopyNotebookPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"groupId", n => { GroupId = n.GetStringValue(); } },
                {"notebookFolder", n => { NotebookFolder = n.GetStringValue(); } },
                {"renameAs", n => { RenameAs = n.GetStringValue(); } },
                {"siteCollectionId", n => { SiteCollectionId = n.GetStringValue(); } },
                {"siteId", n => { SiteId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("groupId", GroupId);
            writer.WriteStringValue("notebookFolder", NotebookFolder);
            writer.WriteStringValue("renameAs", RenameAs);
            writer.WriteStringValue("siteCollectionId", SiteCollectionId);
            writer.WriteStringValue("siteId", SiteId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}