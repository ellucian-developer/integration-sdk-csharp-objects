//Copyright 2019 Ellucian Company L.P. and its affiliates.

using System.Collections.Generic;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Attributes;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about a student for a specified academic period. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentAcademicPeriods_V1_0_0 : BaseModel2
    {
        /// <summary>
        /// The person who is associated with the academic period.
        /// </summary>
        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// The academic period to which the student has been associated.
        /// </summary>
        [JsonProperty("academicPeriod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 AcademicPeriod { get; set; }

        /// <summary>
        /// The distinct academic levels associated with the student for this period.
        /// </summary>
        [JsonProperty("academicLevels", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<StudentAcademicPeriodsAcademicLevels> AcademicLevels { get; set; }

        /// <summary>
        /// The student academic statuses for the period.
        /// </summary>
        [JsonProperty("academicStatuses", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<StudentAcademicPeriodsAcademicStatuses> AcademicStatuses { get; set; }

        /// <summary>
        /// The student calculated academic loads for the period.
        /// </summary>
        [JsonProperty("academicLoads", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<StudentAcademicPeriodsAcademicLoads> AcademicLoads { get; set; }

    }
}