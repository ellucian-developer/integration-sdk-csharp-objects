// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Ellucian.Generated.Eedm.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The characteristics of the recurrence of an event
    /// </summary>
    [DataContract]
    public class Recurrence3
    {
        /// <summary>
        /// Time Period
        /// </summary>
        [DataMember(Name = "timePeriod")]
        public RepeatTimePeriod2 TimePeriod { get; set; }

        /// <summary>
        /// Repeat Rule
        /// </summary> 
        [JsonConverter(typeof(RepeatRuleConverter))]
        [DataMember(Name = "repeatRule")]
        public IRepeatRule RepeatRule { get; set; }

        /// <summary>
        /// Constructor for Recurrence3
        /// </summary>
        [JsonConstructor]
        public Recurrence3()
        {
            TimePeriod = new RepeatTimePeriod2();
        }
    }
}