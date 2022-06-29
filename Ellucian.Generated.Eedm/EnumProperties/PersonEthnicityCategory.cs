// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible ethnic origins to which a person belongs.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PersonEthnicityCategory
    {
        /// <summary>
        /// Hispanic.
        /// </summary>
        [EnumMember(Value = "hispanic")]
        Hispanic,
        /// <summary>
        /// Non Hispanic.
        /// </summary>
        [EnumMember(Value = "nonHispanic")]
        NonHispanic
    }
}