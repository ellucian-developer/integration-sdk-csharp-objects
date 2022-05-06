// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The type of adjustment (opening balance or year-end adjustment).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LedgerActivityAdjustmentType
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// openingBalance
        /// </summary>
        [EnumMember(Value = "openingBalance")]
        Openingbalance,

        /// <summary>
        /// yearEndAdjustment
        /// </summary>
        [EnumMember(Value = "yearEndAdjustment")]
        Yearendadjustment,
    }
} 


