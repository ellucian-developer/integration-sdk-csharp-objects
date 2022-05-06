// Copyright 2017-2019 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Attributes;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The results of a aptitude assessment for a student. 
    /// </summary>
    [DataContract]
    public class StudentAptitudeAssessments_V9_0 : BaseModel2
    {

        /// <summary>
        /// The student taking the aptitude assessment.
        /// </summary>
        [DataMember(Name = "student", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 Student { get; set; }

        /// <summary>
        /// The aptitude assessment the student took.
        /// </summary>
        [DataMember(Name = "assessment", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        public GuidObject2 Assessment { get; set; }

        /// <summary>
        /// The date on which the assessment occurred.
        /// </summary>
        [DataMember(Name = "assessedOn", EmitDefaultValue = false)]
        public DateTimeOffset? AssessedOn { get; set; }

        /// <summary>
        /// The score the student received for the assessment.
        /// </summary>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        public StudentAptitudeAssessmentsScore Score { get; set; }

        /// <summary>
        /// The percentile value and type associated with the score.
        /// </summary>
        [DataMember(Name = "percentiles", EmitDefaultValue = false)]
        public List<StudentAptitudeAssessmentsPercentile> Percentile { get; set; }

        /// <summary>
        /// The name and number of the form used for the assessment for this result.
        /// </summary>
        [DataMember(Name = "form", EmitDefaultValue = false)]
        public StudentAptitudeAssessmentsForm Form { get; set; }

        /// <summary>
        /// Special circumstances surrounding the taking of the assessment
        /// </summary>
        [DataMember(Name = "specialCircumstances", EmitDefaultValue = false)]
        public List<GuidObject2> SpecialCircumstances { get; set; }

        /// <summary>
        /// The update status of the student's assessment result.
        /// </summary>
        [DataMember(Name = "update", EmitDefaultValue = false)]
        public StudentAptitudeAssessmentsUpdateStatus? Update { get; set; }

        /// <summary>
        /// An indicator that this result of the assessment are the preferred values for the assessment
        /// </summary>
        [DataMember(Name = "preference", EmitDefaultValue = false)]
        public StudentAptitudeAssessmentsPreference? Preference { get; set; }

        /// <summary>
        /// The sources of the assessment results for the student.
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public GuidObject2 Source { get; set; }

        /// <summary>
        /// The status of this assessment results for the student.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StudentAptitudeAssessmentsStatus? Status { get; set; }

        /// <summary>
        /// An indicator of the nature of the assessment results.
        /// </summary>
        [DataMember(Name = "reported", EmitDefaultValue = false)]
        public StudentAptitudeAssessmentsReported? Reported { get; set; }

        /// <summary>
        /// A Student Aptitude Assesment DTO.
        /// </summary>
        public StudentAptitudeAssessments_V9_0()
        {
            Student = new GuidObject2();
            Assessment = new GuidObject2();
        }

    }
}