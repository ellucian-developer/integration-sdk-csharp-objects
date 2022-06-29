//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The details associated with an undefined vendor or an override to an existing vendors 
    /// information
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ManualVendorDetailsDtoProperty
    {

        /// <summary>
        /// The name of the vendor
        /// </summary>
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }


        /// <summary>
        /// An indication of wheather the vendor is a person or an organization
        /// </summary>
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ManualVendorType? Type { get; set; }

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
        /// The contact for the vendor
        /// </summary>
        [JsonProperty("contact", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhoneDtoProperty Contact { get; set; }

    }
}