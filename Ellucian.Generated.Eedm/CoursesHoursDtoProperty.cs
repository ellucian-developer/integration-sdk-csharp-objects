//Copyright 2018 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The hours that may be assigned to the course by instructional method. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class CoursesHoursDtoProperty
    {
        /// <summary>
        /// The method, style, or format for which hours are established for a course.
        /// </summary>

        [JsonProperty("administrativeInstructionalMethod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AdministrativeInstructionalMethod { get; set; }

        /// <summary>
        /// The minimum number of hours that may be established for an instructional method.
        /// </summary>

        [JsonProperty("minimum", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal? Minimum { get; set; }

        /// <summary>
        /// The maximum number of hours that may be established for an instructional method.
        /// </summary>

        [JsonProperty("maximum", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal? Maximum { get; set; }

        /// <summary>
        /// The increment specified for the hours.
        /// </summary>

        [JsonProperty("increment", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal? Increment { get; set; }

        /// <summary>
        /// The interval specified for the hours.
        /// </summary>

        [JsonProperty("interval", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ContactHoursPeriod? Interval { get; set; }
    }
}
