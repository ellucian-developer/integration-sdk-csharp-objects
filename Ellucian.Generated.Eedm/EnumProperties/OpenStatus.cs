// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The open or closed status
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OpenStatus
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// open
        /// </summary>
        [EnumMember(Value = "open")]
        Open,

        /// <summary>
        /// closed
        /// </summary>
        [EnumMember(Value = "closed")]
        Closed,
    }
}