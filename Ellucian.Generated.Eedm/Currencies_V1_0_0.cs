//Copyright 2019 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The valid list of currencies.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Currencies_V1_0_0 : BaseModel2
    {
        /// <summary>
        /// The full name of the currency.
        /// </summary>
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// The code used to identify the currency.
        /// </summary>
        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// The ISO code used to identify the currency.
        /// </summary>
        [JsonProperty("isoCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ISOCode { get; set; }

    }
}
