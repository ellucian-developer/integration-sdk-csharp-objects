// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The relationship with subject person and the contact
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PersonContactRelationship
    {
        /// <summary>
        /// Person relationship string
        /// </summary>
        [JsonProperty("relationship", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Relationship { get; set; }
    }
}
