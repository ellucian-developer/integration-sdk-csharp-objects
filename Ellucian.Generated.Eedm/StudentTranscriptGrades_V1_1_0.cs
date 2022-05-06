//Copyright 2018 Ellucian Company L.P. and its affiliates.

using System;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Attributes;
using System.Collections.Generic;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The grades eligible to be displayed on the student's transcript. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentTranscriptGrades_V1_1_0 : BaseModel2
    {
        /// <summary>
        /// The student associated with the grade.
        /// </summary>
        [JsonProperty("student", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 Student { get; set; }

        /// <summary>
        /// The course associated with the grade.
        /// </summary>
        [JsonProperty("course", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public StudentTranscriptGradesCourseDtoProperty Course { get; set; }

        /// <summary>
        /// The academic period to which the transcript grade has been assigned.
        /// </summary>
        [JsonProperty( "academicPeriod", DefaultValueHandling = DefaultValueHandling.Ignore )]
        [FilterProperty( "criteria" )]
        public GuidObject2 AcademicPeriod { get; set; }

        /// <summary>
        /// The grade entered.
        /// </summary>
        [JsonProperty("grade", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Grade { get; set; }

        /// <summary>
        /// The default incomplete final grade and the extension date associated with the student's grade.
        /// </summary>
        [JsonProperty("incompleteGrade", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public StudentTranscriptGradesIncompleteGradeDtoProperty IncompleteGrade { get; set; }

        /// <summary>
        /// The award grade scheme assigned to the student.
        /// </summary>
        [JsonProperty("awardGradeScheme", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AwardGradeScheme { get; set; }

        /// <summary>
        /// The credit category associated with the grade.
        /// </summary>
        [JsonProperty("creditCategory", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 CreditCategory { get; set; }

        /// <summary>
        /// The credits associated with the grade.
        /// </summary>
        [JsonProperty("credit", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public StudentTranscriptGradesCreditDtoProperty Credit { get; set; }

        /// <summary>
        /// The reason specified for a change to a previously entered grade.
        /// </summary>
        [JsonProperty("changeReason", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 ChangeReason { get; set; }

        /// <summary>
        /// The date the grade was recorded.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("recordedOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime RecordedOn { get; set; }

        /// <summary>
        /// The associated instance of unverified grades.
        /// </summary>
        [JsonProperty("unverifiedGrade", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 UnverifiedGrade { get; set; }

        /// <summary>
        /// The grade change details of the grades eligible to be displayed on the transcript.
        /// </summary>
        [JsonProperty("changeDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<StudentTranscriptGradesChangeDetails> ChangeDetails { get; set; }


    }
}