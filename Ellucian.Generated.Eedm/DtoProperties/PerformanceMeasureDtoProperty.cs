// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Performance Measure DTO Property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PerformanceMeasureDtoProperty
    {
        /// <summary>
        /// An academic level associated with the student during the academic period.
        /// </summary>
        [JsonProperty("level", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Level { get; set; }

        /// <summary>
        /// Measurement of the student's performance by academic level. (e.g. GPA).
        /// </summary>     
        [JsonProperty("performanceMeasure", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PerformanceMeasure { get; set; }

        /// <summary>
        /// The student's classification by academic level during the academic period. (E.g Freshman, Senior, ...)
        /// </summary>
        [JsonProperty("classification", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Classification { get; set; }
    }
}