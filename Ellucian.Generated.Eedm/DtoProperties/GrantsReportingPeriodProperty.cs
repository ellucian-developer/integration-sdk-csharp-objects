// Copyright 2015 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The reporting periods associated with the grant.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class GrantsReportingPeriodProperty
    {
        /// <summary>
        /// Start date.
        /// </summary>
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonConverter(typeof(DateOnlyConverter))]
        public DateTime? Start { get; set; }


        /// <summary>
        /// End date.
        /// </summary>
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonConverter(typeof(DateOnlyConverter))]
        public DateTime? End { get; set; }

    }
}