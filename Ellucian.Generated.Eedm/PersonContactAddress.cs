// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The associated physical or mailing address of the contact.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PersonContactAddress
    {
        /// <summary>
        /// The value of the address
        /// </summary>
        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ContactFullAddress { get; set; }
    }
}
