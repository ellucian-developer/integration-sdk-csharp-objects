//Copyright 2017 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The person who has the relationship with the subject person.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PersonalRelationshipsRelatedPerson
    {
        /// <summary>
        /// The person who has the relationship with the subject person.
        /// </summary>

        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 person { get; set; }
    }
}