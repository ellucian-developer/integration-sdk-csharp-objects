// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// An indicator of the students involvement in the section.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReportingStatusType
    {
        /// <summary>
        /// Attended
        /// </summary>
        [EnumMember(Value = "attended")]
        Attended,
        /// <summary>
        /// NeverAttended
        /// </summary>
        [EnumMember(Value = "neverAttended")]
        NeverAttended
    }
}
