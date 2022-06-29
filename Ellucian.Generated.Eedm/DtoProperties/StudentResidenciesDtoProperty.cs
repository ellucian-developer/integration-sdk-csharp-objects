//Copyright 2018 Ellucian Company L.P. and its affiliates.

using System;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Attributes;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The residency types (e.g.: international, in state, out of state, etc.) associated with the student for periods of time.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentResidenciesDtoProperty
    {
        /// <summary>
        /// The residency type associated with the student
        /// </summary>
        [FilterProperty("criteria")]
        [JsonProperty("residency", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Residency { get; set; }

        /// <summary>
        /// The date the residency became effective
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? StartOn { get; set; }

        /// <summary>
        /// The starting administrative period associated with the residency. (Banner only)
        /// </summary>
        [JsonProperty("administrativePeriod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AdministrativePeriod { get; set; }
    }
}