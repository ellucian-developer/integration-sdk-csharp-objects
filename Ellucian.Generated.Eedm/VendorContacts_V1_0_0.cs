//Copyright 2020 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The contacts associated with a vendor. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class VendorContacts_V1_0_0 : BaseModel2
    {
        /// <summary>
        /// The vendor associated with the contact.
        /// </summary>

        [JsonProperty("vendor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 Vendor { get; set; }

        /// <summary>
        /// The details for the vendor contact.
        /// </summary>

        [JsonProperty("contact", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public VendorContactsContact Contact { get; set; }

    }
}