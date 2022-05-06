// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Describes a relationship    
    /// </summary>
    [DataContract]
    public class Relationship
    {
        /// <summary>
        /// The relationship type
        /// </summary>
        [DataMember(Name = "type")]
        public PersonalRelationshipType RelationshipType { get; set; }

        /// <summary>
        /// RelationshipType GUID object.
        /// </summary>
        [DataMember(Name = "detail")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 Detail { get; set; }
    }
}
