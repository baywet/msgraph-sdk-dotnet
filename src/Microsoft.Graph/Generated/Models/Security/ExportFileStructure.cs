using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models.Security {
    public enum ExportFileStructure {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "directory")]
        Directory,
        [EnumMember(Value = "pst")]
        Pst,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}