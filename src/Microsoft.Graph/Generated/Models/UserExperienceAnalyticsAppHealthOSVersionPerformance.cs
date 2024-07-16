// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>
    /// The user experience analytics device OS version performance entity contains OS version performance details.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    public partial class UserExperienceAnalyticsAppHealthOSVersionPerformance : global::Microsoft.Graph.Models.Entity, IParsable
    {
        /// <summary>The number of active devices for the OS version. Valid values 0 to 2147483647. Supports: $filter, $select, $OrderBy. Read-only. Valid values -2147483648 to 2147483647</summary>
        public int? ActiveDeviceCount
        {
            get { return BackingStore?.Get<int?>("activeDeviceCount"); }
            set { BackingStore?.Set("activeDeviceCount", value); }
        }
        /// <summary>The mean time to failure for the application in minutes. Valid values 0 to 2147483647. Supports: $filter, $select, $OrderBy. Read-only. Valid values -2147483648 to 2147483647</summary>
        public int? MeanTimeToFailureInMinutes
        {
            get { return BackingStore?.Get<int?>("meanTimeToFailureInMinutes"); }
            set { BackingStore?.Set("meanTimeToFailureInMinutes", value); }
        }
        /// <summary>The OS build number installed on the device. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsBuildNumber
        {
            get { return BackingStore?.Get<string?>("osBuildNumber"); }
            set { BackingStore?.Set("osBuildNumber", value); }
        }
#nullable restore
#else
        public string OsBuildNumber
        {
            get { return BackingStore?.Get<string>("osBuildNumber"); }
            set { BackingStore?.Set("osBuildNumber", value); }
        }
#endif
        /// <summary>The OS version installed on the device. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsVersion
        {
            get { return BackingStore?.Get<string?>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
#nullable restore
#else
        public string OsVersion
        {
            get { return BackingStore?.Get<string>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
#endif
        /// <summary>The application health score of the OS version. Valid values 0 to 100. Supports: $filter, $select, $OrderBy. Read-only. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? OsVersionAppHealthScore
        {
            get { return BackingStore?.Get<double?>("osVersionAppHealthScore"); }
            set { BackingStore?.Set("osVersionAppHealthScore", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthOSVersionPerformance"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthOSVersionPerformance CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthOSVersionPerformance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activeDeviceCount", n => { ActiveDeviceCount = n.GetIntValue(); } },
                { "meanTimeToFailureInMinutes", n => { MeanTimeToFailureInMinutes = n.GetIntValue(); } },
                { "osBuildNumber", n => { OsBuildNumber = n.GetStringValue(); } },
                { "osVersion", n => { OsVersion = n.GetStringValue(); } },
                { "osVersionAppHealthScore", n => { OsVersionAppHealthScore = n.GetDoubleValue(); } },
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
            writer.WriteIntValue("activeDeviceCount", ActiveDeviceCount);
            writer.WriteIntValue("meanTimeToFailureInMinutes", MeanTimeToFailureInMinutes);
            writer.WriteStringValue("osBuildNumber", OsBuildNumber);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteDoubleValue("osVersionAppHealthScore", OsVersionAppHealthScore);
        }
    }
}
