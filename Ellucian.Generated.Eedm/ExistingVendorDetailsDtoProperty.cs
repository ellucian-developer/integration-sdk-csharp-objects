//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The details associated with an existing vendor 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ExistingVendorDetailsDtoProperty
    {
        /// <summary>
        /// The details associated with an existing vendor.
        /// </summary>
        [JsonProperty("vendor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Vendor { get; set; }

        /// <summary>
        /// The details of an alternative stored address
        /// </summary>
        [JsonProperty("alternativeVendorAddress", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AlternativeVendorAddress { get; set; }


    }
}