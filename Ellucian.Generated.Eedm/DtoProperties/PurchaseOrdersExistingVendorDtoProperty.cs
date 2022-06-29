// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The details associated with an existing vendor.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    [DataContract]
    public class PurchaseOrdersExistingVendorDtoProperty
    {
        /// <summary>
        /// The vendor associated with the invoice.
        /// </summary>
        [JsonProperty("vendor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Vendor { get; set; }

        /// <summary>
        /// The vendor address to be used for this invoice (defaults to the vendors primary address).
        /// </summary>
        [JsonProperty("alternativeVendorAddress", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AlternativeVendorAddress { get; set; }
    }
}