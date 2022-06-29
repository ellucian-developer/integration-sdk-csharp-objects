// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm.Filters
{
    /// <summary>
    /// Filter on Time Period startOn and endOn
    /// </summary>
    [DataContract]
    public class RecurrenceFilter
    {
        /// <summary>
        /// Time Period
        /// </summary>
        [JsonProperty("timePeriod")]     
        public TimePeriodFilter TimePeriod { get; set; }
    }
    /// <summary>
    /// The period of time to be repeated.
    /// </summary>
    [DataContract]
    public class TimePeriodFilter
    {
        /// <summary>
        /// The beginning of the time period being repeated.
        /// </summary>
        [JsonProperty("startOn")]
        [FilterProperty("criteria")]
        public DateTimeOffset? StartOn { get; set; }

        /// <summary>
        /// The end of the time period being repeated
        /// </summary>
        [JsonProperty("endOn")]
        [FilterProperty("criteria")]
        public DateTimeOffset? EndOn { get; set; }
    }
}
