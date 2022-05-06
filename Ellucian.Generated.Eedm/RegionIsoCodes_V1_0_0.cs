//Copyright 2019-2021 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Attributes;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// RegionIsoCodes
    /// </summary>   
    [JsonObject(MemberSerialization.OptIn)]
    public class RegionIsoCodes_V1_0_0 : BaseModel2
    {
        /// <summary>
        /// The full name of the region represented by the ISO code.
        /// </summary>
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// The ISO 3166-2 code associated with the region.
        /// </summary>
        [JsonProperty("isoCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ISOCode { get; set; }

        /// <summary>
        /// An indicator as to whether the ISO code is currently in use or was previously used to represent a region.
        /// </summary>
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Status Status { get; set; }

        /// <summary>
        /// The country with which this region is associated.
        /// </summary>
        [JsonProperty("country", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 Country { get; set; }
    }
}         
  
