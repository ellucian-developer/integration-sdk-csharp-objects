// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The manner in which a student's transcript grade will be reported.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TranscriptMode2
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// Standard Registration (for regular grade)
        /// </summary>
        [EnumMember(Value = "standard")]
        Standard,

        /// <summary>
        /// Registration in section for Pass/Fail grade
        /// </summary>
        [EnumMember(Value = "passFail")]
        PassFail,

        /// <summary>
        /// Registration in section for Audit grade
        /// </summary>
        [EnumMember(Value = "audit")]
        Audit,

        /// <summary>
        /// Withdraw from Section receives a withdraw grade
        /// </summary>
        [EnumMember(Value = "withdraw")]
        Withdraw,

        /// <summary>
        /// Failure to complete course work receives Incomplete
        /// but student is given time to complete course work before
        /// receiving a failing grade.
        /// </summary>
        [EnumMember(Value = "incomplete")]
        Incomplete
    }
}