// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The amount and currency values for a general ledger transaction
    /// </summary>
    [DataContract]
    public class ChargedAmountUnitCostDtoProperty
    {
        /// <summary>
        /// Quantity times value is total cost
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The monetary value for the specified currency.
        /// </summary>
        [JsonProperty("cost", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AmountDtoProperty Cost { get; set; }
    }
}