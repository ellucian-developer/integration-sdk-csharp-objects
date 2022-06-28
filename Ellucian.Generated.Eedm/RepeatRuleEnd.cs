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
    public class RepeatRuleEnd
    {
        /// <summary>
        /// When to end the repetitions.
        /// </summary>
        [JsonProperty("repetitions")]
        public int? Repetitions { get; set; }

        /// <summary>
        /// The date after which to stop repeating.
        /// </summary>
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public RepeatRuleEnd()
        {
            // Set default values for the properties
        }
    }
}
