// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The rule that describes how to repeat the time period.
    /// </summary>
    [JsonObject]
    public class RepeatRuleBy
    {
        /// <summary>
        /// The frequency at which the event occurs
        /// </summary>
        [JsonProperty("dayOfMonth", NullValueHandling = NullValueHandling.Ignore)]
        public int? DayOfMonth { get; set; }

        /// <summary>
        /// The days of the week on which to repeat the event.
        /// </summary>
        [JsonProperty("dayOfWeek", NullValueHandling = NullValueHandling.Ignore)]
        public RepeatDay DayOfWeek { get; set; }

        /// <summary>
        /// Constructor for Recurrence
        /// </summary>
        [JsonConstructor]
        public RepeatRuleBy()
        {
            // Set default values for the properties
            DayOfWeek = new RepeatDay();
        }
    }
}
