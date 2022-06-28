//Copyright 2020 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A person or organization that offers products or services to an institution. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class VendorsMaximum_V1_0_0 : BaseModel2
    {
        /// <summary>
        /// The type(s) of vendor, i.e. Procurement, eProcurement, or Travel.
        /// </summary>

        [JsonProperty("types", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public List<VendorTypes> Types { get; set; }

        /// <summary>
        /// The person, organization or educational institution acting as the vendor.
        /// </summary>

        [JsonProperty("vendorDetail", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public VendorDetailsDtoProperty VendorDetail { get; set; }

        /// <summary>
        /// The federal tax identification number for the vendor.
        /// </summary>

        [JsonProperty("taxId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public string TaxId { get; set; }

        /// <summary>
        /// The statuses (active, approved, hold payment) that apply to the vendor.
        /// </summary>

        [JsonProperty("statuses", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public List<VendorsStatuses?> Statuses { get; set; }

        /// <summary>
        /// The first date when the vendor was active/registered.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? StartOn { get; set; }

        /// <summary>
        /// The last date when the vendor was active.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime EndOn { get; set; }

        /// <summary>
        /// The address(es) associated with the vendor.
        /// </summary>

        [JsonProperty("addresses", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<VendorsMaximumAddresses> Addresses { get; set; }

        /// <summary>
        /// The phones and phone-connected devices at which a vendor can be contacted.
        /// </summary>

        [JsonProperty("phones", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<PersonPhoneDtoProperty> Phones { get; set; }

        /// <summary>
        /// The default address(es) associated with the vendor.
        /// </summary>

        [JsonProperty("defaultAddresses", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<VendorsAddressesDtoProperty> DefaultAddresses { get; set; }

        /// <summary>
        /// The default tax form component associated with the vendor.
        /// </summary>

        [JsonProperty("defaultTaxFormComponent", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 DefaultTaxFormComponent { get; set; }

        /// <summary>
        /// The default currency for the vendor.
        /// </summary>

        [JsonProperty("defaultCurrency", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CurrencyIsoCode? DefaultCurrency { get; set; }

        /// <summary>
        /// The contacts associated with a vendor.
        /// </summary>

        [JsonProperty("contacts", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<VendorsMaximumContacts> Contacts { get; set; }

    }
}
