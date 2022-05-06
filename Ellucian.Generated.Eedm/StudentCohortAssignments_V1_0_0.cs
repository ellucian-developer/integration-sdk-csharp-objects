//Copyright 2019 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The groupings of students for reporting/tracking purposes (cohorts) to which the student is assigned for a period of time. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentCohortAssignments_V1_0_0 : BaseModel2
    {
        /// <summary>
        /// The person who has been assigned to a cohort.
        /// </summary>

        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// The grouping of students for reporting/tracking purposes (cohorts) to which the student is assigned for a period of time.
        /// </summary>

        [JsonProperty("cohort", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 Cohort { get; set; }

        /// <summary>
        /// The academic level associated with the student.
        /// </summary>

        [JsonProperty("academicLevel", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AcademicLevel { get; set; }

        /// <summary>
        /// The effective start date of the cohort.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria",  new string[] { "$eq", "$gte", "$lte" })]
        public DateTime? StartOn { get; set; }

        /// <summary>
        /// The last date of the cohort.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria", new string[] { "$eq", "$gte", "$lte" })]
        public DateTime? EndOn { get; set; }

    }
}