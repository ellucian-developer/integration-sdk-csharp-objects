//Copyright 2017 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The override rate for the room assignment.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class HousingAssignmentRateOverrideProperty
    {
        /// <summary>
        /// The override rate for the room assignment.
        /// </summary>

        [JsonProperty("rate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public HousingAssignmentRateChargeProperty HousingAssignmentRate { get; set; }

        /// <summary>
        /// The reason the standard room rate was overridden.
        /// </summary>

        [JsonProperty("reason", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 RateOverrideReason { get; set; }
    }
}
