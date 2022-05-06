// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The grading scheme used to award the student their grade for the section.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentGradeSchemeDtoProperty
    {
        /// <summary>
        /// The global identifier for the Detail.
        /// /grade-schemes/{id}
        /// </summary>
        [JsonProperty("detail", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Detail { get; set; }

        /// <summary>
        /// The full name of the grading scheme.
        /// </summary>
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
    }
}