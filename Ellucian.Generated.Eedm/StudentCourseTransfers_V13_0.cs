// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Coursework completed at external institutions for which students have been awarded credit at the home institution. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentCourseTransferV13_0 : BaseModel2
    {
        /// <summary>
        /// The student who received credit for the transferred course from an external institution.
        /// </summary>

        [JsonProperty("student", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Student { get; set; }

        /// <summary>
        /// The home institution course equivalent to the course at the external institution.
        /// </summary>

        [JsonProperty("equivalentCourse", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 EquivalentCourse { get; set; }

        /// <summary>
        /// The external institution where the course was originally completed.
        /// </summary>

        [JsonProperty("transferredFrom", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 TransferredFrom { get; set; }

        /// <summary>
        /// The academic level (for example, 'Under Graduate' or 'Graduate') associated with the articulated/equivalent course.
        /// </summary>

        [JsonProperty("academicLevel", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AcademicLevel { get; set; }

        /// <summary>
        /// The academic program(s) to which the articulated/equivalent course has been applied.
        /// </summary>

        [JsonProperty("academicPrograms", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<GuidObject2> AcademicPrograms { get; set; }

        /// <summary>
        /// The academic period assigned to the articulated/equivalent course.
        /// </summary>

        [JsonProperty("academicPeriod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AcademicPeriod { get; set; }

        /// <summary>
        /// The grade scheme that was used to award a grade to the articulated/equivalent course.
        /// </summary>

        [JsonProperty("awardGradeScheme", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AwardGradeScheme { get; set; }

        /// <summary>
        /// The grade that was awarded to the articulated/equivalent course.
        /// </summary>

        [JsonProperty("grade", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Grade { get; set; }

        /// <summary>
        /// A numeric value that represents the weight associated with the grade awarded to the articulated/equivalent course.
        /// </summary>

        [JsonProperty("qualityPoints", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal? QualityPoints { get; set; }

        /// <summary>
        /// The unit specification that was awarded to the articulated/equivalent course.
        /// </summary>

        [JsonProperty("credit", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public StudentCourseTransferCreditDtoProperty Credit { get; set; }

        /// <summary>
        /// The date when the equivalency was officially applied to the student's record at the home institution.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("equivalencyAppliedOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime EquivalencyAppliedOn { get; set; }

        /// <summary>
        /// The status of the transferred course.
        /// </summary>
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Status { get; set; }

    }
}
