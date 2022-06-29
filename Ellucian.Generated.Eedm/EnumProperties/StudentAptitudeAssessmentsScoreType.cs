// Copyright 2017 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible types of an Student Aptitude Assessments Score
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StudentAptitudeAssessmentsScoreType
    {
        /// <summary>
        /// Active
        /// </summary>
        [EnumMember(Value = "literal")]
        Literal,

        /// <summary>
        /// Inactive
        /// </summary>
        [EnumMember(Value = "numeric")]
        Numeric

    }
}