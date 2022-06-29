// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Phone Preference
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BestContactTimeType
    {
        /// <summary>
        /// Primary phone.
        /// </summary>
        [EnumMember(Value = "day")]
        Day,

        /// <summary>
        /// Primary phone.
        /// </summary>
        [EnumMember(Value = "evening")]
        Evening,

        /// <summary>
        /// Primary phone.
        /// </summary>
        [EnumMember(Value = "anytime")]
        Anytime,
    }
}
