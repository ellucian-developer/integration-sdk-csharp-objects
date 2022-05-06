// Copyright 2018 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Instrucitonal Event DTO Property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class InstructionalEventDtoProperty3
    {
        /// <summary>
        /// Id of the InstructionalEvent
        /// </summary>
        [JsonProperty("detail")]
        public GuidObject2 Detail { get; set; }

        /// <summary>
        /// Title of the InstructionalEvent
        /// </summary>
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// InstructionalMethod of the InstructionalEvent
        /// </summary>
        [JsonProperty("instructionalMethod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InstructionalMethodDtoProperty InstructionalMethod { get; set; }

        /// <summary>
        /// The locations where the instructional event will take place
        /// </summary>
        [JsonProperty("locations", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<LocationDtoProperty> Locations { get; set; }

        /// <summary>
        /// The recurrence information for this instructional event
        /// </summary>
        [JsonProperty("recurrence", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Recurrence3 Recurrence { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public InstructionalEventDtoProperty3()
        {
            Detail = new GuidObject2();
        }
    }
}
