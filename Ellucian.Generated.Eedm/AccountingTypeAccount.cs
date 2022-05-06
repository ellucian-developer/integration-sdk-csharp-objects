// Copyright 2017 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible types of accounting type accounts
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccountingTypeAccount
    {
        /// <summary>
        /// Asset
        /// </summary>
        asset,

        /// <summary>
        /// liability
        /// </summary>
        liability,

        /// <summary>
        /// Fund balance
        /// </summary>
        fundBalance,

        /// <summary>
        /// Revenue
        /// </summary>
        revenue,

        /// <summary>
        /// Expense
        /// </summary>
        expense,

        /// <summary>
        /// Personal Expense; not used in Colleague
        /// </summary>
        personalExpense,

        /// <summary>
        /// Non Personal expense; not used in Colleague
        /// </summary>
        nonPersonalExpense
    }
}
