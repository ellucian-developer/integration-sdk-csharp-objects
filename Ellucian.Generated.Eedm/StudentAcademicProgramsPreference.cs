// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Indicates the primary academic program of the student.  Only one academic program should be set to preferred for a student.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StudentAcademicProgramsPreference
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// primary
        /// </summary>
        [EnumMember(Value = "primary")]
        Primary,
    }
}