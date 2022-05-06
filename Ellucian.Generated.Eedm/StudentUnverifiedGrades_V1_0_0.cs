//Copyright 2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The unverified grades for a student. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentUnverifiedGrades_V1_0_0 : BaseModel2
    {
        /// <summary>
        /// The student associated with the unverified grade.
        /// </summary>

        [JsonProperty("student", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 Student { get; set; }

        /// <summary>
        /// The section registration associated with the grade.
        /// </summary>

        [JsonProperty("sectionRegistration", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 SectionRegistration { get; set; }

        /// <summary>
        /// The award grade scheme associated with the student.
        /// </summary>

        [JsonProperty("awardGradeScheme", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AwardGradeScheme { get; set; }

        /// <summary>
        /// The default incomplete final grade and the extension date associated with the student's grade.
        /// </summary>

        [JsonProperty("incompleteGrade", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public StudentUnverifiedGradesIncompleteGrade IncompleteGrade { get; set; }

        /// <summary>
        /// The grade and/or last attendance details.
        /// </summary>

        [JsonProperty("details", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public StudentUnverifiedGradesDetails Details { get; set; }

    }
}
