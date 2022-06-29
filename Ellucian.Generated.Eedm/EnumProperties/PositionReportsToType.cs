// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The possible types of reporting position (e.g. primary, alternate, etc.).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PositionReportsToType
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// Primary
        /// </summary>
        [EnumMember(Value = "primary")]
        Primary,

        /// <summary>
        /// Alternate
        /// </summary>
        [EnumMember(Value = "alternate")]
        Alternative

       
    }
}