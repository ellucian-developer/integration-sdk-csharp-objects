//Copyright 2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The credits associated with the grade. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentTranscriptGradesCreditDtoProperty
    {
        /// <summary>
        /// The attempted credits associated with the grade.
        /// </summary>
        [JsonProperty("attemptedCredit", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal? AttemptedCredit { get; set; }

        /// <summary>
        /// The earned credits associated with the grade.
        /// </summary>
        [JsonProperty("earnedCredit", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal? EarnedCredit { get; set; }

        /// <summary>
        /// The quality points used to compute the GPA.
        /// </summary>
        [JsonProperty("qualityPoint", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public StudentTranscriptGradesQualityPointDtoProperty QualityPoint { get; set; }

        /// <summary>
        /// The indicator of how the grade should be used in the GPA calculation.
        /// </summary>
        [JsonProperty("repeatedSection", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public StudentTranscriptGradesRepeatedSection RepeatedSection { get; set; }

    }
}