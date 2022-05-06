// Copyright 20145Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The characteristics of duration
    /// </summary>
    [DataContract]
    public class SectionDuration2
    {
        /// <summary>
        /// The length of the duration
        /// </summary>
        [DataMember(Name = "length")]
        public int Length { get; set; }

        /// <summary>
        /// The unit of measure for the duration
        /// </summary>
        [DataMember(Name = "unit")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DurationUnit2? Unit { get; set; }
    }
}
