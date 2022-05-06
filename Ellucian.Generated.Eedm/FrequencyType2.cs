// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The valid frequency types supported by the LDM
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FrequencyType2
    {
        /// <summary>
        /// Daily
        /// </summary>
        [EnumMember(Value = "daily")]
        Daily,
        /// <summary>
        /// Weekly
        /// </summary>
        [EnumMember(Value = "weekly")]
        Weekly,
        /// <summary>
        /// Monthly
        /// </summary>
        [EnumMember(Value = "monthly")]
        Monthly,
        /// <summary>
        /// Yearly
        /// </summary>
        [EnumMember(Value = "yearly")]
        Yearly
    }
}
