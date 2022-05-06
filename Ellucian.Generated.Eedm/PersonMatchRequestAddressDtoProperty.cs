// Copyright 2019 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about an address
    /// </summary>
    [DataContract]
    public class PersonMatchRequestAddressDtoProperty
    {
        /// <summary>
        /// The <see cref="Type">type</see> of address
        /// </summary>
        [JsonProperty("type")]
        public GuidObject2 Type { get; set; }

        /// <summary>
        /// The address lines of the address, such as a street address, post office box number, or city, region, and postal code
        /// </summary>
        [DataMember(Name = "addressLines", EmitDefaultValue = false)]
        public List<string> AddressLines { get; set; }

        /// <summary>
        /// A country specific postal region.  Postal regions are expressed as a hierarchy of country, region, and sub-region, and as a locality with postal automation codes
        /// </summary> 
        [DataMember(Name = "place", EmitDefaultValue = false)]
        public AddressPlace Place { get; set; }
    }
}