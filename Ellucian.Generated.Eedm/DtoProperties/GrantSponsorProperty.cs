// Copyright 2015 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The person or organization sponsoring the grant.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class GrantSponsorProperty
    {
        /// <summary>
        /// The person sponsoring the grant.
        /// </summary>         
        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// The organization sponsoring the grant.
        /// </summary>         
        [JsonProperty("organization", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Organization { get; set; }
    }
}