// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The higher-level category of marital status.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MaritalStatusType2
    {
        /// <summary>
        /// Hispanic/Latino
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