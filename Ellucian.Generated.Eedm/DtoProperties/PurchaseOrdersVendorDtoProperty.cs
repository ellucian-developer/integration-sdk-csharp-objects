//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The vendor associated with the purchase order. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PurchaseOrdersVendorDtoProperty
    {
        /// <summary>
        /// The details associated with an existing vendor.
        /// </summary>
        [JsonProperty("existingVendor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 ExistingVendor { get; set; }

        /// <summary>
        /// The details associated with an undefined vendor or an override to an existing vendor's information.
        /// </summary>
        [JsonProperty("manualVendorDetail", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ManualVendorDetailsDtoProperty ManualVendorDetails { get; set; }

    }
}