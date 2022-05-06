// Copyright 2014 Ellucian Company L.P. and its affiliates.
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
    public class Recurrence
    {
        /// <summary>
        /// The frequency at which the event occurs
        /// </summary>
        [JsonProperty("frequency")]
        public FrequencyType Frequency { get; set; }

        /// <summary>
        /// The number of intervals between the events
        /// </summary>
        [JsonProperty("interval")]
        public int Interval { get; set; }

        /// <summary>
        /// The days of the week on which the events fall
        /// </summary>
        [JsonProperty("byDay", ItemConverterType = typeof(StringEnumConverter))]
        public List<DayOfWeek> Days { get; set; }

        /// <summary>
        /// Constructor for Recurrence
        /// </summary>
        [JsonConstructor]
        public Recurrence()
        {
            // All properties are required, so set default values for them
            Frequency = FrequencyType.Daily; 
            Interval = 1;
            Days = new List<DayOfWeek>();
        }
    }
}
