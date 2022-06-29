// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The employement status type and detail
    /// </summary>
    [DataContract]
    public class CourseReportingDtoProperty
    {

        /// <summary>
        /// The locality requiring additional reporting properties.
        /// </summary>
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CourseReportingType? Type { get; set; }

        /// <summary>
        /// The weight assigned to the course.
        /// </summary>
        [JsonProperty("weight", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal? Weight { get; set; }
    }
}