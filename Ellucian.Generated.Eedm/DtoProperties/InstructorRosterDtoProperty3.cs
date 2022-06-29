// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using System.Collections.Generic;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about the instructor of an instructional event
    /// </summary>
    [JsonObject("instructorRoster")]
    public class InstructorRosterDtoProperty3
    {
        /// <summary>
        /// The Instructor details
        /// </summary>
        [JsonProperty("instructor")]
        public InstructorDtoProperty3 Instructor { get; set; }

        /// <summary>
        /// An indication whether the instructor is identified as the primary instructor for the section.
        /// </summary>
        [JsonProperty("instructorRole", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SectionInstructorsInstructorRole InstructorRole { get; set; }

        /// <summary>
        /// The percentage of the workload this instructor is responsible for
        /// </summary>
        [JsonProperty("workLoad", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal? WorkLoadPercentage { get; set; }

        /// <summary>
        /// The percentage of the responsibility of this instructor for this event
        /// </summary>
        [JsonProperty("responsibilityPercentage", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal? ResponsibilityPercentage { get; set; }

        /// <summary>
        /// The date on which this instructor starts working on this event
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("workStartOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? WorkStartDate { get; set; }

        /// <summary>
        /// The day on which the instructor stops working on this event
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("workEndOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? WorkEndDate { get; set; }

        /// <summary>
        /// The methods, styles, or formats of instruction associated with the instructor's involvement with the section (e.g. lecture, lab, etc.).
        /// </summary>
        [JsonProperty("instructionalMethods", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<GuidObject2> InstructionalMethods { get; set; }

        /// <summary>
        /// The instructional events associated with the assignment of the instructor to the section, if applicable.
        /// </summary>
        [JsonProperty("instructionalEvents", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<GuidObject2> InstructionalEvents { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public InstructorRosterDtoProperty3()
        {
            
        }
    }
}
