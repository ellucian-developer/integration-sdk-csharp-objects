// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Possible statuses of the position (e.g. active, frozen, cancelled, inactive).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PositionStatus
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// Active
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// Frozen
        /// </summary>
        [EnumMember(Value = "frozen")]
        Frozen,

        /// <summary>
        /// Cancelled
        /// </summary>
        [EnumMember(Value = "cancelled")]
        Cancelled,

        /// <summary>
        /// Inactive
        /// </summary>
        [EnumMember(Value = "inactive")]
        Inactive
    }
}