// Copyright 2020 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Address Type DTO property for Person Address data with title
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PersonAddressType2DtoProperty
    {
        /// <summary>
        /// The <see cref="AddressType">type</see> of address
        /// </summary>
        [JsonProperty("addressType")]
        public AddressType? AddressType { get; set; }

        /// <summary>
        /// The full name of the address type.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }


        /// <summary>
        /// The code used to identify the address type
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Globally unique identifier for address type
        /// </summary>
        [JsonProperty("detail", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Detail { get; set; }
    }
}