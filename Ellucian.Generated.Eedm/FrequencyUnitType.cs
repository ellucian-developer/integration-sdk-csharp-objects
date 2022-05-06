// Copyright 2017 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The unit of measure for the frequency
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FrequencyUnitType
    {
        /// <summary>
        /// Day
        /// </summary>
        [EnumMember(Value = "day")]
        Day,
        /// <summary>
        /// Month
        /// </summary>
        [EnumMember(Value = "month")]
        Month
    }
}
