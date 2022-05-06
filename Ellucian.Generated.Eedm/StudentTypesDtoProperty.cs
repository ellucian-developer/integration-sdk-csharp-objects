//Copyright 2018 Ellucian Company L.P. and its affiliates.

using System;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Attributes;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The student types associated with the student.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentTypesDtoProperty
    {
        /// <summary>
        /// A student type
        /// </summary>
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 Type { get; set; }

        /// <summary>
        /// The start date of the type for the student.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? StartOn { get; set; }

        /// <summary>
        /// Administrative period type. (Banner only)
        /// </summary>
        [JsonProperty("administrativePeriod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AdministrativePeriod { get; set; }
    }
}