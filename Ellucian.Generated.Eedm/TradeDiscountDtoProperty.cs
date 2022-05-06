//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A discount applied to the line item in addition to the overall vendor discount, e.g. discount based on quantity purchased.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class TradeDiscountDtoProperty
    {
        /// <summary>
        /// The amount of the discount
        /// </summary>
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Amount2DtoProperty Amount { get; set; }

        /// <summary>
        /// The percentage of the discount
        /// </summary>
        [JsonProperty("percent", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal? Percent { get; set; }

    }
}