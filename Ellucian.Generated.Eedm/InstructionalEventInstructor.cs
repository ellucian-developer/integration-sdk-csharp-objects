// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about the instructor of an instructional event
    /// </summary>
    [JsonObject("instructorRoster")]
    public class InstructionalEventInstructor
    {
        /// <summary>
        /// The instructor
        /// </summary>
        [JsonProperty("instructor")]
        public GuidObject Instructor { get; set; }

        /// <summary>
        /// The percentage of the workload this instructor is responsible for
        /// </summary>
        [JsonProperty("workloadPercentage")]
        public decimal? WorkLoadPercentage { get; set; }

        /// <summary>
        /// The percentage of the responsibility of this instructor for this event
        /// </summary>
        [JsonProperty("responsibilityPercentage")]
        public decimal? ResponsibilityPercentage { get; set; }

        /// <summary>
        /// The date on which this instructor starts working on this event
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("workStartDate")]
        public DateTime? WorkStartDate { get; set; }

        /// <summary>
        /// The day on which the instructor stops working on this event
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("workEndDate")]
        public DateTime? WorkEndDate { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public InstructionalEventInstructor()
        {
            Instructor = new GuidObject();
        }
    }
}
