// Copyright 2015-2016 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Rules for repeating on a daily basis.
    /// </summary>
    //[JsonObject("daily")]
    [DataContract(Name = "daily")]
    public class RepeatRuleDaily : IRepeatRule
    {
        /// <summary>
        /// When to end the daily repetitions
        /// </summary>
        [JsonProperty("ends")]
        public RepeatRuleEnds Ends { get; set; }

        /// <summary>
        /// Number of days between each repetition
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public int Interval { get; set; }

        /// <summary>
        /// Repeat Rule Type
        /// </summary>
        [JsonProperty("type")]
        public FrequencyType2? Type { get; set; }

        /// <summary>
        /// Constructor for RepeatRuleDaily
        /// </summary>
        [JsonConstructor]
        public RepeatRuleDaily()
        {
            Type = FrequencyType2.Daily;
            Interval = 1;
        }
    }
}