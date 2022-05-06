// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible types of an health check
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HealthCheckType
    {
        /// <summary>
        /// Available
        /// </summary>
        [EnumMember(Value = "available")]
        Available,

        /// <summary>
        /// Unavailable
        /// </summary>
        [EnumMember(Value = "unavailable")]
        Unavailable,
    }
}