// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible types of employment (Eg. Full-time or Part-time).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AdmissionApplicationsAcademicLoadType
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// Full Time
        /// </summary>
        [EnumMember(Value = "fullTime")]
        FullTime,

        /// <summary>
        /// Part Time
        /// </summary>
        [EnumMember(Value = "partTime")]
        PartTime
    }
}