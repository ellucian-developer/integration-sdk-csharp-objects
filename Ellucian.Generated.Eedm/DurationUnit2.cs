// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Units of measure for duration
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DurationUnit2
    {
        /// <summary>
        /// Measured in days
        /// </summary>
        [EnumMember(Value = "days")]
        Days,
        /// <summary>
        /// Measured in weeks
        /// </summary>
        [EnumMember(Value = "weeks")]
        Weeks,
        /// <summary>
        /// Measured in months
        /// </summary>
        [EnumMember(Value = "months")]
        Months,
        /// <summary>
        /// Measured in years
        /// </summary>
        [EnumMember(Value = "years")]
        Years
    }
}
