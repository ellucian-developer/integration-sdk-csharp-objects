//Copyright 2017-2020 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The date period
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class DatePeriodDtoProperty
    {

        /// <summary>
        /// The date started.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The date ended.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? EndDate { get; set; }

    }
}