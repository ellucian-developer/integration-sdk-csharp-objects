//Copyright 2019 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The distinct academic levels associated with the student for this period. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentAcademicPeriodsAcademicLevels
    {
        /// <summary>
        /// The distinct academic level associated with the student for this period.
        /// </summary>
        [JsonProperty("academicLevel", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AcademicLevel { get; set; }

        /// <summary>
        /// An indicator as to whether the academic level is the primary for the student.
        /// </summary>
        [JsonProperty("priority", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Priority Priority { get; set; }
    }
}