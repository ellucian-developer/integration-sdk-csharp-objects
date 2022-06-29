//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The vendor
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class VendorDtoProperty
    {
        /// <summary>
        /// The details associated with an existing vendor.
        /// </summary>
        [JsonProperty("existingVendor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ExistingVendorDetailsDtoProperty ExistingVendor { get; set; }

        /// <summary>
        /// The details associated with an undefined vendor or an override to an existing vendor's information.
        /// </summary>
        [JsonProperty("manualVendorDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ManualVendorDetailsDtoProperty ManualVendorDetails { get; set; }

    }
}