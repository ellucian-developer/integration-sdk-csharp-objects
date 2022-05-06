// Copyright 2017 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// An event, possibly recurring, at which instruction occurs
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class InstructionalEvents_V8_0 : BaseModel2
    {
        /// <summary>
        /// Title of the instructional event
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// Long description of the event
        /// </summary>
        [JsonProperty("description",NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// The section for which this event occurs
        /// </summary>
        [JsonProperty("section", NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 Section { get; set; }

        /// <summary>
        /// The type of instruction at this event
        /// </summary>
        [JsonProperty("instructionalMethod", NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 InstructionalMethod { get; set; }

        /// <summary>
        /// The total faculty workload for this event
        /// </summary>
        [JsonProperty("workLoad", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Workload { get; set; }

        /// <summary>
        /// The recurrence information for this instructional event
        /// </summary>
        [JsonProperty("recurrence", NullValueHandling = NullValueHandling.Ignore)]
        public Recurrence3 Recurrence { get; set; }

        /// <summary>
        /// The locations where the instructional event will take place
        /// </summary>
        [JsonProperty("locations", NullValueHandling = NullValueHandling.Ignore)]
        public List<Location> Locations { get; set; }

        /// <summary>
        /// The roster of instructors assigned to teach an instructional event
        /// </summary>
        [JsonProperty("instructorRoster", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstructionalEventInstructor3> Instructors { get; set; }

        /// <summary>
        /// Approvals controlling the behavior of related validations
        /// </summary>
        [JsonProperty("approvals", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstructionalEventApproval2> Approvals { get; set; }
    }
}