// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The amount and currency values for a general ledger transaction
    /// </summary>
    [DataContract]
    public class ChargedAmountDtoProperty
    {
        /// <summary>
        /// The monetary value for the specified currency.
        /// </summary>
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AmountDtoProperty  Amount { get; set; }

        /// <summary>
        /// The ISO 4217 currency code
        /// </summary>
        [JsonProperty("unitCost", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ChargedAmountUnitCostDtoProperty UnitCost { get; set; }
    }
}