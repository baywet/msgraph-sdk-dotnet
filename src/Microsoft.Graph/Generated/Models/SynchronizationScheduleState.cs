using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum SynchronizationScheduleState {
        [EnumMember(Value = "Active")]
        Active,
        [EnumMember(Value = "Disabled")]
        Disabled,
        [EnumMember(Value = "Paused")]
        Paused,
    }
}