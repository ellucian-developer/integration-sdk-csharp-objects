// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    ///  Person relationship
    /// </summary>
    [DataContract]
    public class PersonalRelationships_V6_0 : BaseModel2
    {
        /// <summary>
        /// A person, with regards to whom the relationship is considered.
        /// </summary>
        [DataMember(Name = "subjectPerson")]
        public GuidObject2 SubjectPerson { get; set; }

        /// <summary>
        /// A person related to the subject.
        /// </summary>
        [DataMember(Name = "relatedPerson")]
        public GuidObject2 RelatedPerson { get; set; }

        /// <summary>
        /// The relationship between the subject and related person, going from the latter to the former
        /// </summary>
        [DataMember(Name = "directRelationship")]
        public Relationship DirectRelationship { get; set; }

        /// <summary>
        /// The reverse relationship between the persons
        /// </summary>
        [DataMember(Name = "reciprocalRelationship")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Relationship ReciprocalRelationship { get; set; }

        /// <summary>
        /// The status of the relationship (where appropriate).
        /// </summary>
        [DataMember(Name = "status")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 PersonalRelationshipStatus { get; set; }

        /// <summary>
        /// The date when the relationship started
        /// </summary>
        [DataMember(Name = "startOn")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DateOnlyConverter))]
        public DateTime? StartOn { get; set; }

        /// <summary>
        /// The date when the relationship started
        /// </summary>
        [DataMember(Name = "endOn")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DateOnlyConverter))]
        public DateTime? EndOn { get; set; }

        /// <summary>
        /// A person, with regards to whom the relationship is considered.
        /// </summary>
        [DataMember(Name = "comment")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }
    }
}
