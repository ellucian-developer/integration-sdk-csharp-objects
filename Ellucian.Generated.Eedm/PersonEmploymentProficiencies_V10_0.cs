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
    /// The proficiencies specified for a person for employment. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PersonEmploymentProficiencies_V10_0 : BaseModel2
    {
        /// <summary>
        /// The person possessing the employment proficiency.
        /// </summary>

        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// The person's proficiency.
        /// </summary>

        [JsonProperty("proficiency", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Proficiency { get; set; }

        /// <summary>
        /// The person's level of proficiency.
        /// </summary>

        [JsonProperty("level", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Level { get; set; }

        /// <summary>
        /// The classifications of the person's proficiency level (e.g. read, write, translate, etc.).
        /// </summary>

        [JsonProperty("proficiencyLevelClassifications", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Proficiencylevelclassification> ProficiencyLevelClassifications { get; set; }

        /// <summary>
        /// The first date when the proficiency is valid.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime StartOn { get; set; }

        /// <summary>
        /// The last date when the proficiency is valid.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime EndOn { get; set; }

        /// <summary>
        /// The last date the proficiency was used.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("lastUsedOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime LastUsedOn { get; set; }

        /// <summary>
        /// The comments associated with the person employment proficiency.
        /// </summary>

        [JsonProperty("comment", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

    }
}
