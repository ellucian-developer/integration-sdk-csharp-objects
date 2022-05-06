// Copyright 2014 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The valid frequency types supported by the LDM
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FrequencyType
    {
        /// <summary>
        /// Daily
        /// </summary>
        Daily,
        /// <summary>
        /// Weekly
        /// </summary>
        Weekly,
        /// <summary>
        /// Monthly
        /// </summary>
        Monthly,
        /// <summary>
        /// Yearly
        /// </summary>
        Yearly
    }
}
