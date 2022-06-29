// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The credits associated with the grade.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentTranscriptGradesQualityPointDtoProperty
    {
        /// <summary>
        /// The quality points used to compute the GPA.
        /// </summary>
        [JsonProperty("nonWeighted", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal? NonWeighted { get; set; }

        /// <summary>
        /// The weighted quality points used to compute the GPA.
        /// </summary>
        [JsonProperty("gpa", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal? Gpa { get; set; }

    }
}