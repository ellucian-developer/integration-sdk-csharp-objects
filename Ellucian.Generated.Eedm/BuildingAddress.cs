// Copyright 2017 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Detailed information concerning financial aid applicant income. 
    /// </summary>
    [DataContract]
    public class BuildingAddress
    {
        /// <summary>
        /// The address lines, such as a street address, post office box number, etc, of the
        /// physical address associated with the building.
        /// </summary>
        [JsonProperty("addressLines", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> AddressLines { get; set; }

        /// <summary>
        /// A country specific postal region. Postal regions are expressed as a hierarchy of country, region, and sub-region, and as a locality with postal automation codes.
        /// </summary> 
        [DataMember(Name = "place", EmitDefaultValue = false)]
        public AddressPlace Place { get; set; }
        
        /// <summary>
        /// The latitude associated with the building.
        /// </summary>
        [JsonProperty("latitude", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal? Latitude { get; set; }

        /// <summary>
        /// The longitude associated with the building.
        /// </summary>
        [JsonProperty("longitude", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal? Longitude { get; set; }
    }
}
