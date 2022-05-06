//Copyright 2019-2020 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The student calculated academic loads for the period. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentAcademicPeriodsAcademicLoads
    {
        /// <summary>
        /// An indicator as to whether the academic load is established for the student overall or specific to a student's academic level.
        /// </summary>
        [JsonProperty("basis", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public StudentAcademicPeriodsBasis Basis { get; set; }

        /// <summary>
        /// The academic level associated with the academic load.
        /// </summary>
        [JsonProperty("academicLevel", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AcademicLevel { get; set; }

        /// <summary>
        /// The student calculated academic load for the period.
        /// </summary>
        [JsonProperty("academicLoad", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AcademicLoad2 AcademicLoad { get; set; }

    }
}