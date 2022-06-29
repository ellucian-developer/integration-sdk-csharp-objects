//Copyright 2019 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Ellucian.Generated.Eedm;
using Ellucian.Generated.Eedm.Attributes;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The student academic statuses for the period. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentAcademicPeriodsAcademicStatuses
    {
        /// <summary>
        /// An indicator as to whether the academic status is established for the student overall or specific to a student's academic level.
        /// </summary>
        [JsonProperty("basis", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public StudentAcademicPeriodsBasis Basis { get; set; }

        /// <summary>
        /// The academic level associated with the academic period status.
        /// </summary>
        [JsonProperty("academicLevel", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AcademicLevel { get; set; }

        /// <summary>
        /// The student academic status for the period as established by the institution.
        /// </summary>
        [JsonProperty("academicPeriodStatus", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 AcademicPeriodStatus { get; set; }

    }
}