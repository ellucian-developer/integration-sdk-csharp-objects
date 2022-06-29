// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of the locality requiring additional reporting properties.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CourseReportingType
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// Nebraska state reporting
        /// </summary>
        [EnumMember(Value = "nebraska")]
        Nebraska
    }
}