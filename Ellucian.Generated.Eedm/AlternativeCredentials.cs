// Copyright 2015 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Attributes;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Credential DTO Property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class AlternativeCredentials
    {
        /// <summary>
        /// The type of alternative credential.
        /// </summary>
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 Type { get; set; }

        /// <summary>
        /// The value of the alternative credential.
        /// </summary>
        [FilterProperty("criteria")]
        [JsonProperty("value")]
        public string Value { get; set; }
               
    }
}
