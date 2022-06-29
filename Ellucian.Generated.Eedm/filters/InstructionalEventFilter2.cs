// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm.Filters
{
    /// <summary>
    /// Instructional Event query parameters
    /// </summary>
    public class InstructionalEventFilter2
    {
        /// <summary>
        /// The section for which this event occurs
        /// </summary>
        [JsonProperty("section")]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 Section { get; set; }

        /// <summary>
        /// The beginning of the time period being repeated.
        /// </summary>
        [JsonProperty("startOn")]
        [FilterProperty("criteria")]
        public DateTimeOffset? StartOn { get; set; }

        /// <summary>
        /// The end of the time period being repeated
        /// </summary>
        [JsonProperty("endOn")]
        [FilterProperty("criteria")]
        public DateTimeOffset? EndOn { get; set; }

        /// <summary>
        /// room where the event will take place.
        /// </summary>
        [JsonProperty("room")]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 Room { get; set; }

        /// <summary>
        /// instructor
        /// </summary>        
        [JsonProperty("instructor")]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 InstructorId { get; set; }

        /// <summary>
        /// The recurrence information for this instructional event
        /// </summary>
        [JsonProperty("recurrence", DefaultValueHandling = DefaultValueHandling.Ignore)]
        //[FilterProperty("criteria")]
        public RecurrenceFilter Recurrence { get; set; }

        /// <summary>
        /// The locations where the instructional event will take place
        /// </summary>
        [JsonProperty("locations")]
        //[FilterProperty("criteria")]
        public List<InstructionalEventLocationFilter> Locations { get; set; }

        /// <summary>
        /// The roster of instructors assigned to teach an instructional event
        /// </summary>
        [JsonProperty("instructorRoster")]
        //[FilterProperty("criteria")]
        public List<InstructionalEventInstructor3> Instructors { get; set; }

        /// <summary>
        /// instructor
        /// </summary>        
        [JsonProperty("academicPeriod")]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 AcademicPeriod { get; set; }
    }
    /// <summary>
    /// A physical location within the organization where the event will take place
    /// </summary>
    [DataContract]
    public class InstructionalEventLocationFilter
    {
        /// <summary>
        /// The location information for this instructional event
        /// </summary>
        [JsonProperty("location")]        
        public InstructionalRoomFilter Location { get; set; }
    }
    /// <summary>
    /// Filter on Location and Room
    /// </summary>
    [DataContract]
    public class InstructionalRoomFilter
    {
        /// <summary>
        /// room where the event will take place.
        /// </summary>
        [JsonProperty("room")]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 Room { get; set; }
    }
}
