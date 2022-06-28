//Copyright 2020 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The initiation of a vendor contact person creation.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class VendorContactInitiationProcess
    {
        /// <summary>
        /// The vendor with which the contact is associated.
        /// </summary>

        [JsonProperty("vendor")]
        public GuidObject2 Vendor { get; set; }

        /// <summary>
        /// The vendor contact person.
        /// </summary>

        [JsonProperty("vendorContact")]
        public VendorContact VendorContact { get; set; }

        /// <summary>
        /// The phone type, number and extension of the contact person.
        /// </summary>

        [JsonProperty("vendorContactPhones", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<VendorContactsPhones> VendorContactPhones { get; set; }

        /// <summary>
        /// The email type and address of the contact person.
        /// </summary>

        [JsonProperty("vendorContactEmail", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public EmailProperty VendorContactEmail { get; set; }
    }
}
