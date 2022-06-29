//Copyright 2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The course associated with the grade. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentTranscriptGradesCourseDtoProperty
    {
        /// <summary>
        /// The section associated with the grade.
        /// </summary>
        [JsonProperty("section", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Section { get; set; }

        /// <summary>
        /// The details of the course associated with the grade.
        /// </summary>
        [JsonProperty("detail", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Detail { get; set; }

        /// <summary>
        /// The name of the course associated with the grade.
        /// </summary>
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }
    }
}