// Copyright 2015-2016 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Rules for repeating on a monthly basis
    /// </summary>
    [DataContract(Name = "monthly")]
    public class RepeatRuleMonthly : IRepeatRule
    {
        /// <summary>
        /// How to calculate the day of the month on which to start repeating
        /// </summary>
        [JsonProperty("repeatBy", NullValueHandling = NullValueHandling.Ignore)]
        public RepeatRuleRepeatBy RepeatBy { get; set; }

        /// <summary>
        /// Number of months between each repetition
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public int Interval { get; set; }

        /// <summary>
        /// When to end the monthly repetitions
        /// </summary>
        [JsonProperty("ends", NullValueHandling = NullValueHandling.Ignore)]
        public RepeatRuleEnds Ends { get; set; }

        /// <summary>
        /// Repeat Rule Type
        /// </summary>
        [JsonProperty("type")]
        public FrequencyType2? Type { get; set; }

        /// <summary>
        /// Constructor for RepeatRuleMonthly
        /// </summary>
        [JsonConstructor]
        public RepeatRuleMonthly()
        {
            Type = FrequencyType2.Monthly;
            Interval = 1;
        }
    }
}