// Copyright 2017 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Assessments that are used to determine a student's aptitude (academic achievement, competency, proficiency). 
    /// </summary>
    [DataContract]
    public class AptitudeAssessments_V6_0 : BaseModel2
    {
        /// <summary>
        /// The full name of the Aptitude Assessment.
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// The code that identifies the Aptitude Assessment.
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// The description of the Aptitude Assessment.
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// The organization that offers the assessment.
        /// </summary>
        //[DataMember(Name = "vendor", EmitDefaultValue = false)]
        //public GuidObject2 Vendor { get; set; }

        /// <summary>
        /// The assessment of which the assessment is part.
        /// </summary>
        [DataMember(Name = "parentAssessment", EmitDefaultValue = false)]
        public GuidObject2 ParentAssessment { get; set; }

        /// <summary>
        /// The valid scores that may be awarded for the assessment.
        /// </summary>
        [DataMember(Name = "validScores", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ValidScoreProperty ValidScores { get; set; }

        /// <summary>
        /// The type and method of the calculations to be used to determent the assessment score.
        /// </summary>
        [DataMember(Name = "calculation", EmitDefaultValue = false)]
        public AssessmentCalculationProperty Calculation { get; set; }

        /// <summary>
        /// The type of the assessment (e.g. admissions, placement, ...).
        /// </summary>
        [DataMember(Name = "assessmentType", EmitDefaultValue = false)]
        public GuidObject2 AssessmentType { get; set; }

    }
}