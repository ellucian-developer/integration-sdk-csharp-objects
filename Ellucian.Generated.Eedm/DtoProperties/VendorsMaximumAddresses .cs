//Copyright 2020 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The address(es) associated with the vendor. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class VendorsMaximumAddresses
    {


        /// <summary>
        /// A code used to uniquely identify the address type instance.
        /// </summary>

        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// The address lines of the vendor's location, such as a street address, post office box number, or city, region, and postal code.
        /// </summary>

        [JsonProperty("addressLines", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> AddressLines { get; set; }

        /// <summary>
        /// A country specific postal region. Postal regions are expressed as a hierarchy of country, region, and sub-region, and as a locality with postal automation codes.
        /// </summary>

        [JsonProperty("place", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AddressPlace Place { get; set; }

        /// <summary>
        /// The details associated with the address.
        /// </summary>

        [JsonProperty("detail", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 Detail { get; set; }

        /// <summary>
        /// A type of address for a vendor. Includes a standard type (e.g. 'business', 'mailing') and an optional, custom type to further identify the type of address.
        /// </summary>

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PersonAddressType2DtoProperty Type { get; set; }

        /// <summary>
        /// The status of the address (active or inactive).
        /// </summary>

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Status Status { get; set; }

        /// <summary>
        /// The phones and phone-connected devices for this address at which the vendor can be contacted.
        /// </summary>

        [JsonProperty("phones", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<PersonPhoneDtoProperty> Phones { get; set; }

        /// <summary>
        /// The earliest date that this address was valid for the vendor.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? StartOn { get; set; }

        /// <summary>
        /// The latest date when this address was valid for the vendor.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? EndOn { get; set; }

        /// <summary>
        /// The usages associated with the address.
        /// </summary>

        [JsonProperty("usages", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Usages { get; set; }


    }
}
