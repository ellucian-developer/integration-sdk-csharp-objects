// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The relationship between the subject person and the contact.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PersonEmergencyContactsRelationship
    {
        /// <summary>
        /// The type of the relationship.
        /// </summary>
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }


        /// <summary>
        /// The user defined type of the relationship
        /// </summary>
        [JsonProperty("detail", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Detail { get; set; }
    }
}
