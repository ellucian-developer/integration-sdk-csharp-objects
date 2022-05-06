// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The higher-level marital category of the person.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PersonMaritalStatusCategory
    {
        /// <summary>
        /// Single
        /// </summary>
        [EnumMember(Value = "single")]
        Single,
        /// <summary>
        /// Married
        /// </summary>
        [EnumMember(Value = "married")]
        Married,
        /// <summary>
        /// Divorced
        /// </summary>
        [EnumMember(Value = "divorced")]
        Divorced,
        /// <summary>
        /// Widowed
        /// </summary>
        [EnumMember(Value = "widowed")]
        Widowed,
        /// <summary>
        /// Separated
        /// </summary>
        [EnumMember(Value = "separated")]
        Separated,
        /// <summary>
        /// Other
        /// </summary>
        [EnumMember(Value = "other")]
        Other
    }
}