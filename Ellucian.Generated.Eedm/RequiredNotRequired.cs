// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// An indicator whether the value is required.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RequiredNotRequired
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// required
        /// </summary>
        [EnumMember(Value = "required")]
        Required,

        /// <summary>
        /// notRequired
        /// </summary>
        [EnumMember(Value = "notRequired")]
        NotRequired,
    }
}


