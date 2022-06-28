// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The type of students cohort.
    /// </summary>
    [DataContract]
    public class StudentCohorts_V7_1_0 : CodeItem2
    {
        /// <summary>
        /// The first date when when students may be assigned to the cohort.
        /// </summary>
        [Newtonsoft.Json.JsonProperty( "startOn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore )]
        public System.DateTimeOffset? StartOn { get; set; }

        /// <summary>
        /// The last date when when students may be assigned to the cohort.
        /// </summary>
        [Newtonsoft.Json.JsonProperty( "endOn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore )]
        public System.DateTimeOffset? EndOn { get; set; }

        /// <summary>
        /// The first academic period when students may be assigned to the cohort.
        /// </summary>
        [Newtonsoft.Json.JsonProperty( "initialAcademicPeriod", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore )]
        public GuidObject2? InitialAcademicPeriod { get; set; }

        /// <summary>
        /// The last academic period when students may be assigned to the cohort.
        /// </summary>
        [Newtonsoft.Json.JsonProperty( "finalAcademicPeriod", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore )]
        public GuidObject2? FinalAcademicPeriod { get; set; }

        /// <summary>
        /// Student Cohort Type.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public CohortType StudentCohortType { get; set; }
    }
}