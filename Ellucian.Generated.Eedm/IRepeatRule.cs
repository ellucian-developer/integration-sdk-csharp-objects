// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The rule that describes how to repeat the time period.
    /// </summary>
    [JsonObject]
    public interface IRepeatRule
    {
        /// <summary>
        /// When to end the repetition
        /// </summary>
        [DataMember(Name = "ends")]
        RepeatRuleEnds Ends { get; set; }
        
        /// <summary>
        /// Repeat Rule Type
        /// </summary>
        [DataMember(Name = "type")]
        FrequencyType2? Type { get; set; }

        /// <summary>
        /// Number of days between each repetition
        /// </summary>
        [DataMember(Name = "interval")]
        int Interval { get; set; }
    }
}