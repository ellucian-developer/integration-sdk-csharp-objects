// Copyright 2015 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Address Type DTO property for Person Address data
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PersonAddressTypeDtoProperty
    {
        /// <summary>
        /// The <see cref="AddressType">type</see> of address
        /// </summary>
        [JsonProperty("addressType")]
        public AddressType? AddressType { get; set; }

        /// <summary>
        /// Globally unique identifier for address type
        /// </summary>
        [JsonProperty("detail", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Detail { get; set; }
    }
}