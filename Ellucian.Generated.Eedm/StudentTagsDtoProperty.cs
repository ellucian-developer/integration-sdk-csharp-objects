//Copyright 2018 Ellucian Company L.P. and its affiliates.

using System;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A list of custom defined attributes or characteristics (tags) assigned to the student for a period of time.
    /// (Banner-only)
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentTagsDtoProperty
    {
        /// <summary>
        /// The custom defined attribute or characteristic (tag) assigned to the student. (Banner-only)
        /// </summary>
        [JsonProperty("tag", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Tag { get; set; }

        /// <summary>
        /// The starting administrative period for the tag. (Banner only)
        /// </summary>
        [JsonProperty("startAdministrativePeriod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 StartAdministrativePeriod { get; set; }

        /// <summary>
        /// The ending administrative period for the tag. (Banner only)
        /// </summary>
        [JsonProperty("endAdministrativePeriod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 EndAdministrativePeriod { get; set; }
    }
}