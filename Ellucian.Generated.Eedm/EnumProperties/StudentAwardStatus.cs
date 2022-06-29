// Copyright 2017 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible Status of the financial aid award.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StudentAwardStatus
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// Offered
        /// </summary>
        [EnumMember(Value = "offered")]
        Offered,

        /// <summary>
        /// Accepted
        /// </summary>
        [EnumMember(Value = "accepted")]
        Accepted,

        /// <summary>
        /// Declined
        /// </summary>
        [EnumMember(Value = "declined")]
        Declined,

        /// <summary>
        /// Cancelled
        /// </summary>
        [EnumMember(Value = "cancelled")]
        Cancelled
    }
}