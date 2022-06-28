// Copyright 2017 Ellucian Company L.P. and its affiliates.
using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about the instructor of an instructional event
    /// </summary>
    [JsonObject("instructorRoster")]
    public class InstructionalEventInstructor3
    {
        /// <summary>
        /// The instructor
        /// </summary>
        [JsonProperty("instructor")]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 Instructor { get; set; }

        /// <summary>
        /// The role of primary assigned to first instructor
        /// </summary>
        [JsonProperty("instructorRole", NullValueHandling = NullValueHandling.Ignore)]
        public InstructorRoleType? instructorRole { get; set; }

        /// <summary>
        /// The percentage of the workload this instructor is responsible for
        /// </summary>
        [JsonProperty("workLoad", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? WorkLoadPercentage { get; set; }

        /// <summary>
        /// The percentage of the responsibility of this instructor for this event
        /// </summary>
        [JsonProperty("responsibilityPercentage")]
        public decimal? ResponsibilityPercentage { get; set; }

        /// <summary>
        /// The date on which this instructor starts working on this event
        /// </summary>
        [JsonProperty("workStartOn")]
        public DateTimeOffset? WorkStartDate { get; set; }

        /// <summary>
        /// The day on which the instructor stops working on this event
        /// </summary>
        [JsonProperty("workEndOn")]
        public DateTimeOffset? WorkEndDate { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public InstructionalEventInstructor3()
        {
            Instructor = new GuidObject2();
        }
    }
}
