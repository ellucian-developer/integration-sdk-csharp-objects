// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of section types for crosslist
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RepeatedSection
    {
        /// <summary>
        /// To handle nulls
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// Not Repeated
        /// </summary>
        [EnumMember(Value = "notRepeated")]
        NotRepeated,

        /// <summary>
        /// Repeated Include Credit
        /// </summary>
        [EnumMember(Value = "repeatedIncludeCredit")]
        RepeatedIncludeCredit,

        /// <summary>
        /// Repeated Include Quality Points
        /// </summary>
        [EnumMember(Value = "repeatedIncludeQualityPoints")]
        RepeatedIncludeQualityPoints,

        /// <summary>
        /// Repeated Include Both
        /// </summary>
        [EnumMember(Value = "repeatedIncludeBoth")]
        RepeatedIncludeBoth,

        /// <summary>
        /// Repeated Include Neither
        /// </summary>
        [EnumMember(Value = "repeatedIncludeNeither")]
        RepeatedIncludeNeither
    }
}