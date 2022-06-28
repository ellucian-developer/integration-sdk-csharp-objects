//Copyright 2019 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Various academic periods related to a student's progression in a program. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentAcademicProgramsAcademicPeriods2
    {
        /// <summary>
        /// The starting academic period of student's enrollment in the program
        /// </summary>
        [JsonProperty("starting", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Starting { get; set; }

        /// <summary>
        /// The academic period in which the student is expected to graduate.
        /// </summary>
        [JsonProperty("expectedGraduation", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 ExpectedGraduation { get; set; }

        /// <summary>
        /// The academic period in which the student actually graduated.
        /// </summary>
        //[JsonProperty("actualGraduation", DefaultValueHandling = DefaultValueHandling.Ignore)]
        //[FilterProperty("criteria")]
        //public GuidObject2 ActualGraduation { get; set; }
    }
}