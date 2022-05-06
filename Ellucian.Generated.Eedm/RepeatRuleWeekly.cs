// Copyright 2015-2016 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Rules for repeating on a weekly basis
    /// </summary>
    [DataContract(Name = "weekly")]
    public class RepeatRuleWeekly : IRepeatRule
    {
        /// <summary>
        /// When to end the weekly repetitions
        /// </summary>
        [DataMember(Name = "ends")]
        public RepeatRuleEnds Ends { get; set; }

        /// <summary>
        /// Number of weeks between each repetition.
        /// </summary>
        [DataMember(Name = "interval")]
        public int Interval { get; set; }

        /// <summary>
        /// The days of the week on which to repeat the event.
        /// </summary>
        [JsonProperty(ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(Name = "daysOfWeek")]
        public List<HedmDayOfWeek?> DayOfWeek { get; set; }
       
        /// <summary>
        /// Type of Repeat Rule
        /// </summary>
        [DataMember(Name = "type")]
        public FrequencyType2? Type { get; set; }

        /// <summary>
        /// Constructor for RepeatRuleWeekly
        /// </summary>
        [JsonConstructor]
        public RepeatRuleWeekly()
        {
            Type = FrequencyType2.Weekly;
            Interval = 1;
        }
    }
}