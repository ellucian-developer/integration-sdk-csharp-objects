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
    public class RepeatRule
    {
        /// <summary>
        /// The type of Repeat Rule being defined
        /// </summary>
        [JsonProperty("type")]
        public FrequencyType2 Frequency { get; set; }

        /// <summary>
        /// Number of days between each repetition.
        /// </summary>
        [JsonProperty("interval")]
        public int Interval { get; set; }

        /// <summary>
        /// The days of the week on which the events fall
        /// </summary>
        [JsonProperty("daysOfWeek", ItemConverterType = typeof(StringEnumConverter))]
        public List<HedmDayOfWeek> Days { get; set; }

        /// <summary>
        /// Repeat rule ends on repetition number or date
        /// </summary>
        [JsonProperty("ends")]
        public RepeatRuleEnd Ends { get; set; }

        /// <summary>
        /// Repeats by day of month or day of week
        /// </summary>
        [JsonProperty("repeatBy")]
        public RepeatRuleBy RepeatBy { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public RepeatRule()
        {
            // All properties are required, so set default values for them
            Frequency = FrequencyType2.Daily; 
            Interval = 1;
            Days = new List<HedmDayOfWeek>();
            Ends = new RepeatRuleEnd();
            RepeatBy = new RepeatRuleBy();
        }
    }
}
