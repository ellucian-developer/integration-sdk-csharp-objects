// Copyright 2020 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Type of the charge the student incurred. 
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StudentPaymentTypes2
    {
        /// <summary>
        /// No value set for this enumeration
        /// </summary>
        notset = 0,
        /// <summary>
        /// Deposit
        /// </summary>
        [EnumMember(Value = "deposit")]
        deposit,
        /// <summary>
        /// Sponsor
        /// </summary>
        [EnumMember(Value = "sponsor")]
        sponsor,
        /// <summary>
        /// Payroll
        /// </summary>
        [EnumMember(Value = "payroll")]
        payroll,
        /// <summary>
        /// Cash
        /// </summary>
        [EnumMember(Value = "cash")]
        cash
    }
}