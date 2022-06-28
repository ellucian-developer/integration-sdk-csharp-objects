// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The characteristics of the recurrence of an event
    /// </summary>
    [JsonObject]
    public class Recurrence2
    {
        /// <summary>
        /// The period of time to be repeated.
        /// </summary>
        [JsonProperty("timePeriod")]
        public RepeatTimePeriod TimePeriod { get; set; }

        /// <summary>
        /// The rule that describes how to repeat the time period.
        /// </summary>
        [JsonProperty("repeatRule")]
        public RepeatRule RepeatRule { get; set; }

        /// <summary>
        /// Constructor for Recurrence
        /// </summary>
        [JsonConstructor]
        public Recurrence2()
        {
            // All properties are required, so set default values for them
            TimePeriod = new RepeatTimePeriod();
            RepeatRule = new RepeatRule();
        }
    }
}
