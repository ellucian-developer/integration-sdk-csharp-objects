// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The period of time to be repeated.
    /// </summary>
    [JsonObject]
    public class RepeatTimePeriod
    {
        /// <summary>
        /// The beginning of the time period being repeated.
        /// </summary>
        [JsonProperty("startOn")]
        public DateTime? StartOn { get; set; }

        /// <summary>
        /// The end of the time period being repeated.
        /// </summary>
        [JsonProperty("endOn")]
        public DateTime? EndOn { get; set; }

        /// <summary>
        /// Constructor for Time Period
        /// </summary>
        [JsonConstructor]
        public RepeatTimePeriod()
        {
            
        }
    }
}
