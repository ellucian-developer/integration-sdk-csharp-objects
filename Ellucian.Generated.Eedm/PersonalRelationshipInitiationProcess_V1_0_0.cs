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
    /// The relationships between two people. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PersonalRelationshipInitiationProcess_V1_0_0 : BaseModel2
    {
        /// <summary>
        /// The primary person for whom the relationship is described.
        /// </summary>

        [JsonProperty("subjectPerson", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 SubjectPerson { get; set; }

        /// <summary>
        /// The person who has the relationship with the subject person.
        /// </summary>

        [JsonProperty("related", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PersonalRelationshipInitiationProcessRelated Related { get; set; }

        /// <summary>
        /// The subject person's relationship type with the related person.
        /// </summary>

        [JsonProperty("relationshipType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 RelationshipType { get; set; }

        /// <summary>
        /// The status of the person relationship.
        /// </summary>

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Status { get; set; }

        /// <summary>
        /// The date when the relationship started.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? StartOn { get; set; }

        /// <summary>
        /// The date when the relationship ended.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? EndOn { get; set; }

        /// <summary>
        /// The comment on the relationship.
        /// </summary>

        [JsonProperty("comment", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Comment { get; set; }

    }
}
