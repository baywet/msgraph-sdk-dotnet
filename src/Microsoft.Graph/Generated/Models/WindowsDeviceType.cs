// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>Contains properties for Windows device type. Multiple values can be selected. Default value is `none`.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    [Flags]
    public enum WindowsDeviceType
    {
        /// <summary>No device types supported. Default value.</summary>
        [EnumMember(Value = "none")]
        None = 1,
        /// <summary>Indicates support for Desktop Windows device type.</summary>
        [EnumMember(Value = "desktop")]
        Desktop = 2,
        /// <summary>Indicates support for Mobile Windows device type.</summary>
        [EnumMember(Value = "mobile")]
        Mobile = 4,
        /// <summary>Indicates support for Holographic Windows device type.</summary>
        [EnumMember(Value = "holographic")]
        Holographic = 8,
        /// <summary>Indicates support for Team Windows device type.</summary>
        [EnumMember(Value = "team")]
        Team = 16,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue = 32,
    }
}
