using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Attributes;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about the relationship between a student and an advisor. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentAdvisorRelationships_V8_0 : BaseModel2
    {
        /// <summary>
        /// The person who provides guidance to the student.
        /// </summary>
        [JsonProperty("advisor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 Advisor { get; set; }

        /// <summary>
        /// The student receiving guidance from the advisor.
        /// </summary>
        [JsonProperty("student", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 Student { get; set; }

        /// <summary>
        /// The type of advisor. (E.g. concentration, major, peer, thesis, etc.)
        /// </summary>
        [JsonProperty("advisorType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 AdvisorType { get; set; }

        /// <summary>
        /// The program for which the student is receiving guidance for from the advisor.
        /// </summary>
        [JsonProperty("program", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Program { get; set; }

        /// <summary>
        /// The date when the student was first assigned to the advisor.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? StartOn { get; set; }

        /// <summary>
        /// The last date when the student was associated with the advisor.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? EndOn { get; set; }

        /// <summary>
        /// The prioritization (e.g. primary) of the advisor as the source of guidance for the student.
        /// </summary>
        [JsonProperty("assignedPriority", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public StudentAdvisorRelationshipsAssignedPriority AssignedPriority { get; set; }

        /// <summary>
        /// The academic period when the advisor first provided guidance to the student.
        /// </summary>
        [JsonProperty("startAcademicPeriod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 StartAcademicPeriod { get; set; }

    }
}
