//Copyright 2019 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The valid list of ISO 4217 currency codes. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class CurrencyIsoCodes_V1_0_0 : BaseModel2
    {
        /// <summary>
        /// The full name of the currency represented by the ISO code.
        /// </summary>
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// The ISO 4217 code associated with the currency.
        /// </summary>
        [JsonProperty("isoCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ISOCode { get; set; }

        /// <summary>
        /// An indicator as to whether the ISO code is currently in use or was previously used to represent a currency.
        /// </summary>
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Status Status { get; set; }

    }
}
