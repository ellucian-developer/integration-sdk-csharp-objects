// Copyright 2018 Ellucian Company L.P. and its affiliates.
using System;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;

namespace Ellucian.Generated.Eedm.Filters
{
    /// <summary>
    /// Filter for account-funds-available and accountSpecifications named query
    /// </summary>
    public class AccountFundsAvailableFilter
    {
        /// <summary>
        /// The full representation of the accounting string in the format specified by the authoritative system.
        /// </summary>
        [JsonProperty("accountingString")]
        [FilterProperty(new string[] { "criteria", "accountSpecification" })]
        public string AccountingString { get; set; }

        /// <summary>
        /// Status of the availability of funds.
        /// </summary>
        [JsonProperty("amount")]
        [FilterProperty(new string[] { "criteria", "accountSpecification" })]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The date for which the availability of funds was evaluated.
        /// </summary>
        [JsonProperty("balanceOn")]
        [FilterProperty(new string[] { "criteria", "accountSpecification" })]
        public DateTime? BalanceOn { get; set; }

        /// <summary>
        /// The person guid assigned to the ID of the user requesting the assessment of availableFunds
        /// </summary>
        [JsonProperty("submittedBy")]
        [FilterProperty(new string[] { "criteria", "accountSpecification" })]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 SubmittedBy { get; set; }
    }
}
