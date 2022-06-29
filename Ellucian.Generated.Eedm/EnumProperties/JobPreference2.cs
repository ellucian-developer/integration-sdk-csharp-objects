// Copyright 2015 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The preference for a job (primary).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobPreference2
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
        /// Secondary
        /// </summary>
        [EnumMember(Value = "secondary")]
        Secondary,

        /// <summary>
        /// Overload
        /// </summary>
        [EnumMember(Value = "overload")]
        Overload
    }
}