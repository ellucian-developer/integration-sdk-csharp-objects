//Copyright 2018 Ellucian Company L.P. and its affiliates.

using System;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A list of statuses associated with the student for specified effective periods.
    /// Banner-only
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentStatusesDtoProperty
    {
        /// <summary>
        /// The student status. (Banner-only)
        /// </summary>
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Status { get; set; }

        /// <summary>
        /// The effective administrative period associated with the student status. (Banner only)
        /// </summary>
        [JsonProperty("administrativePeriod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AdministrativePeriod { get; set; }
    }
}