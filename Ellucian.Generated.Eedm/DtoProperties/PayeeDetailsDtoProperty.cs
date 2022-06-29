//Copyright 2017 Ellucian Company L.P. and its affiliates.

using System.Collections.Generic;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The details associated with the payee
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PayeeDetailsDtoProperty
    {
        /// <summary>
        /// The payee associated with the transaction
        /// </summary>
        [JsonProperty("payee", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LedgerActivityReference Payee { get; set; }

        /// <summary>
        /// The full name of the payee
        /// </summary>
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The address lines of the persons location, such as a street address or 
        /// post office box number, city, region, and postal code.
        /// </summary>
        [JsonProperty("addressLines", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> AddressLines { get; set; }

        /// <summary>
        /// A country specific postal region.  Postal regions are expressed as a hierarchy of country, 
        /// region, and sub-region, and as a locality with postal automation codes
        /// </summary>
        [JsonProperty("place", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AddressPlace Place { get; set; }

    }
}