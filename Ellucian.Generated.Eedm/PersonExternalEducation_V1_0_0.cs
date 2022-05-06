//Copyright 2019 Ellucian Company L.P. and its affiliates.

using System.Collections.Generic;
using Ellucian.Generated.Eedm.Attributes;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A record of person's education outside of the home institution. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PersonExternalEducation_V1_0_0 : BaseModel2
    {
        /// <summary>
        /// The person who was educated at the institution.
        /// </summary>
        [FilterProperty("criteria")]
        [JsonProperty("person")]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// The educational institution where the person studied.
        /// </summary>
        [JsonProperty("institution")]
        public GuidObject2 Institution { get; set; }

        /// <summary>
        /// The periods associated with the person's attendance at the institution.
        /// </summary>
        [JsonProperty("attendancePeriods", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<ExternalEducationAttendancePeriods> AttendancePeriods { get; set; }

        /// <summary>
        /// A measurement of the student's educational performance at the institution (e.g. GPA).
        /// </summary>
        [JsonProperty("performanceMeasure", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PerformanceMeasure { get; set; }

        /// <summary>
        /// The size of the class associated with the person's course of study.
        /// </summary>
        [JsonProperty("classSize", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? ClassSize { get; set; }

        /// <summary>
        /// The person's class percentile.
        /// </summary>
        [JsonProperty("classPercentile", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal? ClassPercentile { get; set; }

        /// <summary>
        /// The person's class rank.
        /// </summary>
        [JsonProperty("classRank", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? ClassRank { get; set; }

        /// <summary>
        /// The total number of credits completed during the person's entire attendance at the institution.
        /// </summary>
        [JsonProperty("totalCredits", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal? TotalCredits { get; set; }

        /// <summary>
        /// The details of the educational institution where the person graduated.
        /// </summary>
        [JsonProperty("graduationDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ExternalEducationGraduationDetails GraduationDetails { get; set; }

    }
}