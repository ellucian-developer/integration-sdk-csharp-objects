//Copyright 2017 Ellucian Company L.P. and its affiliates.

using System.Collections.Generic;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Overrides the shipping information specified in the ship to destination.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class OverrideShippingDestinationDtoProperty
    {

        /// <summary>
        /// The description of the shipping destination
        /// </summary>
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// The address lines of the destinations location, such as a street address or 
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

        /// <summary>
        /// The contact for the shipping destination
        /// </summary>
        [JsonProperty("contact", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhoneDtoProperty Contact { get; set; }

    }
}