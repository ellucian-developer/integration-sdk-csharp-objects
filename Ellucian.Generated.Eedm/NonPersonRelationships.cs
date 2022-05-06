//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Converters;

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The relationships between organizations or institutions and other persons, organizations or institutions. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class NonPersonRelationships : BaseModel2
    {
        /// <summary>
        /// The primary organization or institution for which the relationship is described.
        /// </summary>

        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public NonpersonRelationshipsSubject Subject { get; set; }

        /// <summary>
        /// The person, organization or institution that has a relationship with the subject.
        /// </summary>

        [JsonProperty("related", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public NonpersonRelationshipsRelated Related { get; set; }

        /// <summary>
        /// The relationship type associated with the subject.
        /// </summary>

        [JsonProperty("directRelationshipType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 DirectRelationshipType { get; set; }

        /// <summary>
        /// The reverse relationship type associated with the subject.
        /// </summary>

        [JsonProperty("reciprocalRelationshipType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 ReciprocalRelationshipType { get; set; }

        /// <summary>
        /// The status of the nonperson relationship.
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
