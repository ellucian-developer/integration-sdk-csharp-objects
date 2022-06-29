// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible gender types
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GenderType2
    {
        /// <summary>
        /// Male
        /// </summary>
        [EnumMember(Value = "male")]
        Male,

        /// <summary>
        /// Female
        /// </summary>
        [EnumMember(Value = "female")]
        Female,

        /// <summary>
        /// Unknown
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown
    }
}