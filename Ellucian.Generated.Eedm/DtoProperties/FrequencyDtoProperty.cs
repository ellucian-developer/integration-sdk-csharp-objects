// Copyright 2017 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The frequency at which the performance review occurs.
    /// </summary>
    [DataContract]
    public class FrequencyDtoProperty
    {
        /// <summary>
        /// The unit of measure for the frequency
        /// </summary>
        [JsonProperty("unit")]
        public FrequencyUnitType Unit { get; set; }

        /// <summary>
        /// The value of the frequency at which the performance review occurs
        /// </summary>
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Value { get; set; }
    }
}