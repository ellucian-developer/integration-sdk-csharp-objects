//Copyright 2018 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The amount and currency values for a general ledger transaction
    /// </summary>
    [DataContract]
    public class QuantityAmount2DtoProperty
    {
        /// <summary>
        /// The quantity
        /// </summary>
        [JsonProperty("quantity", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// The amount
        /// </summary>
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Amount2DtoProperty Cost { get; set; }
    }
}