// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The indicator of how the grade should be used in the GPA calculation.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StudentTranscriptGradesRepeatedSection
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// notRepeated
        /// </summary>
        [EnumMember(Value = "notRepeated")]
        NotRepeated,

        /// <summary>
        /// repeatedIncludeCredit
        /// </summary>
        [EnumMember(Value = "repeatedIncludeCredit")]
        RepeatedIncludeCredit,

        /// <summary>
        /// repeatedIncludeQualityPoints
        /// </summary>
        [EnumMember(Value = "repeatedIncludeQualityPoints")]
        RepeatedIncludeQualityPoints,

        /// <summary>
        /// repeatedIncludeBoth
        /// </summary>
        [EnumMember(Value = "repeatedIncludeBoth")]
        RepeatedIncludeBoth,

        /// <summary>
        /// repeatedIncludeNeither
        /// </summary>
        [EnumMember(Value = "repeatedIncludeNeither")]
        RepeatedIncludeNeither,
    }
}