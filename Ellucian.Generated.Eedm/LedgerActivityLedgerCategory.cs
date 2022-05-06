// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The ledger category associated with the activity.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LedgerActivityLedgerCategory
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// originalBudget
        /// </summary>
        [EnumMember(Value = "originalBudget")]
        Originalbudget,

        /// <summary>
        /// budgetAdjustment
        /// </summary>
        [EnumMember(Value = "budgetAdjustment")]
        Budgetadjustment,

        /// <summary>
        /// actuals
        /// </summary>
        [EnumMember(Value = "actuals")]
        Actuals,

        /// <summary>
        /// encumbrance
        /// </summary>
        [EnumMember(Value = "encumbrance")]
        Encumbrance,

        /// <summary>
        /// reservation
        /// </summary>
        [EnumMember(Value = "reservation")]
        Reservation,

        /// <summary>
        /// accountedBudget
        /// </summary>
        [EnumMember(Value = "accountedBudget")]
        Accountedbudget,

        /// <summary>
        /// temporaryBudget
        /// </summary>
        [EnumMember(Value = "temporaryBudget")]
        Temporarybudget,
    }
} 


