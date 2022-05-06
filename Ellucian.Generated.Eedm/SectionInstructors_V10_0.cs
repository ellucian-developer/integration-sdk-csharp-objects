//Copyright 2017 Ellucian Company L.P. and its affiliates.

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
    /// Information about instructors assigned to sections in academic capacities. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    [DataContract]
    public class SectionInstructors_V10_0 : BaseModel2
    {
        /// <summary>
        /// The person assigned as an instructor to the section.
        /// </summary>

        [JsonProperty("instructor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        [FilterProperty("criteria")]
        public GuidObject2 Instructor { get; set; }

        /// <summary>
        /// The section to which the instructor is assigned.
        /// </summary>

        [JsonProperty("section", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        [FilterProperty("criteria")]
        public GuidObject2 Section { get; set; }

        /// <summary>
        /// The instructional event associated with the assignment of the instructor to the section, if applicable.
        /// </summary>

        [JsonProperty("instructionalEvents", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonConverter(typeof(ArrayGuidObject2FilterConverter))]
        [FilterProperty("criteria")]
        public List<GuidObject2> InstructionalEvents { get; set; }

        /// <summary>
        /// The method, style, or format of instruction associated with the instructor's involvement with the section (for example, 'Lecture', 'Lab').
        /// </summary>

        [JsonProperty("instructionalMethod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 InstructionalMethod { get; set; }

        /// <summary>
        /// An indication whether the instructor is identified as the primary instructor for the section.
        /// </summary>

        [JsonProperty("instructorRole", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SectionInstructorsInstructorRole? InstructorRole { get; set; }

        /// <summary>
        /// The amount of work attributed to the instructor for the assignment.
        /// </summary>

        [JsonProperty("workLoad", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal? WorkLoad { get; set; }

        /// <summary>
        /// The percentage of the total responsibility for managing the instructional method's activities attributed to the instructor for the assignment.
        /// </summary>

        [JsonProperty("responsibilityPercentage", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal ResponsibilityPercentage { get; set; }

        /// <summary>
        /// The first date associated with the instructor's assignment.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("workStartOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime WorkStartOn { get; set; }

        /// <summary>
        /// The last date associated with the instructor's assignment.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("workEndOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime WorkEndOn { get; set; }

    }
}
