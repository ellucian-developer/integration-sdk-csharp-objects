// Copyright 2015-2016 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Ellucian.Generated.Eedm;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The rule that describes how to repeat the time period.
    /// </summary>
    [JsonObject]
    public class RepeatDay
    {
        /// <summary>
        /// The number of intervals between the events
        /// </summary>
        [JsonProperty("interval")]
        public int? Occurrence { get; set; }

        /// <summary>
        /// The days of the week on which the events fall
        /// </summary>
        [JsonProperty("day", ItemConverterType = typeof(StringEnumConverter))]
        public HedmDayOfWeek Day { get; set; }

        /// <summary>
        /// Constructor for Recurrence
        /// </summary>
        [JsonConstructor]
        public RepeatDay()
        {
            // Set default values for the properties
        }
    }
}
