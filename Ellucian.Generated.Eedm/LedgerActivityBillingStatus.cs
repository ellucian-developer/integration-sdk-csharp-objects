// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The billing status of the expenditure activity (billed or unbilled).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LedgerActivityBillingStatus
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// billed
        /// </summary>
        [EnumMember(Value = "billed")]
        Billed,

        /// <summary>
        /// unbilled
        /// </summary>
        [EnumMember(Value = "unbilled")]
        Unbilled,
    }
} 


