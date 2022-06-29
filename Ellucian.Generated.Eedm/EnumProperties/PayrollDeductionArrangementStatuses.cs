// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible statuses of a payroll deduction request.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PayrollDeductionArrangementStatuses
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
        /// Suspended
        /// </summary>
        [EnumMember(Value = "suspended")]
        Suspended,

        /// <summary>
        /// Rejected
        /// </summary>
        [EnumMember(Value = "rejected")]
        Rejected,

        /// <summary>
        /// Cancelled
        /// </summary>
        [EnumMember(Value = "cancelled")]
        Cancelled,

        /// <summary>
        /// Withdrawn
        /// </summary>
        [EnumMember(Value = "withdrawn")]
        Withdrawn,

        /// <summary>
        /// Terminated
        /// </summary>
        [EnumMember(Value = "terminated")]
        Terminated
    }
}