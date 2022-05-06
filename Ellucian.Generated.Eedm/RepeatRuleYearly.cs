// Copyright 2015-2016 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Rules for repeating on an annual basis.
    /// </summary>
    [DataContract(Name = "yearly")]
   public class RepeatRuleYearly : IRepeatRule
    {
        /// <summary>
        /// When to end the yearly repetitions.
        /// </summary>
       [DataMember(Name = "ends")]
        public RepeatRuleEnds Ends { get; set; }

        /// <summary>
        /// Number of years between each repetition.
        /// </summary>
        [DataMember(Name = "interval")]
        public int Interval { get; set; }     

        /// <summary>
        /// Type of Repeat Rule
        /// </summary>
       [DataMember(Name = "type")]
        public FrequencyType2? Type { get; set; }

        /// <summary>
        /// Constructor for RepeatRuleYearly
        /// </summary>
        [JsonConstructor]
        public RepeatRuleYearly()
        {
            Type = FrequencyType2.Yearly;
            Interval = 1;
        }
    }
}


