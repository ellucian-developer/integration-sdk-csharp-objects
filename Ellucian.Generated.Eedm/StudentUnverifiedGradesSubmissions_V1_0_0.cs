//Copyright 2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The submissions of unverified grades or grade changes. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentUnverifiedGradesSubmissions_V1_0_0 : BaseModel2
    {
        /// <summary>
        /// The section registration associated with the unverified grade.
        /// </summary>
        [JsonProperty("sectionRegistration", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 SectionRegistration { get; set; }

        /// <summary>
        /// The grade submission details to be applied.
        /// </summary>
        [JsonProperty("grade", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public StudentUnverifiedGradesGradeDtoProperty Grade { get; set; }

        /// <summary>
        /// The last date or status of attendance associated with the unverified grade.
        /// </summary>
        [JsonProperty("lastAttendance", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public StudentUnverifiedGradesLastAttendanceDtoProperty LastAttendance { get; set; }

        /// <summary>
        /// The instructor who submitted the grade.
        /// </summary>
        [JsonProperty("submittedBy", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 SubmittedBy { get; set; }

    }
}
