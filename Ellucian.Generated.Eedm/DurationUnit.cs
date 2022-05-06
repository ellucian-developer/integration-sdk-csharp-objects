// Copyright 2014 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Units of measure for duration
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DurationUnit
    {
        /// <summary>
        /// Measured in days
        /// </summary>
        Days,
        /// <summary>
        /// Measured in weeks
        /// </summary>
        Weeks,
        /// <summary>
        /// Measured in months
        /// </summary>
        Months,
        /// <summary>
        /// Measured in years
        /// </summary>
        Years
    }
}
