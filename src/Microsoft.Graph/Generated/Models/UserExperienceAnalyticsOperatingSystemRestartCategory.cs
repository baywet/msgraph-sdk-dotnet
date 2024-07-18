// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>Operating System restart category.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public enum UserExperienceAnalyticsOperatingSystemRestartCategory
    {
        /// <summary>Default. Set to unknown if device operating system restart category has not yet been calculated.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Indicates that the device operating system restart is along with an update.</summary>
        [EnumMember(Value = "restartWithUpdate")]
        RestartWithUpdate,
        /// <summary>Indicates that the device operating system restart is without update.</summary>
        [EnumMember(Value = "restartWithoutUpdate")]
        RestartWithoutUpdate,
        /// <summary>Indicates that the device operating system restart is due to a specific stop error.</summary>
        [EnumMember(Value = "blueScreen")]
        BlueScreen,
        /// <summary>Indicates that the device operating system restart is due to shutdown with update.</summary>
        [EnumMember(Value = "shutdownWithUpdate")]
        ShutdownWithUpdate,
        /// <summary>Indicates that the device operating system restart is due to shutdown without update.</summary>
        [EnumMember(Value = "shutdownWithoutUpdate")]
        ShutdownWithoutUpdate,
        /// <summary>Indicates that the device operating system restart is due to update long power-button press.</summary>
        [EnumMember(Value = "longPowerButtonPress")]
        LongPowerButtonPress,
        /// <summary>Indicates that the device operating system restart is due to boot error.</summary>
        [EnumMember(Value = "bootError")]
        BootError,
        /// <summary>Indicates that the device operating system restarted after an update.</summary>
        [EnumMember(Value = "update")]
        Update,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
