// Copyright 2017-2018 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Type of the charge the student incurred. 
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StudentPaymentTypes
    {
        /// <summary>
        /// No value set for this enumeration
        /// </summary>
        notset = 0,
        /// <summary>
        /// Financial Aid
        /// </summary>
        [EnumMember(Value = "financialAid")]
        financialAid,
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