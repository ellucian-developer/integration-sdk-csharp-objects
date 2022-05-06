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
    /// The person's housing preferences.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class HousingRequestPreferenceProperty
    {
        /// <summary>
        /// The person's preferred location or campus.
        /// </summary>
        [JsonProperty("site", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public HousingPreferenceRequiredProperty Site { get; set; }

        /// <summary>
        /// The person's preferred building.
        /// </summary>
        [JsonProperty("building", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public HousingPreferenceRequiredProperty Building { get; set; }

        /// <summary>
        /// The person's preferred building wing.
        /// </summary>
        [JsonProperty("wing", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public HousingPreferenceRequiredProperty Wing { get; set; }

        /// <summary>
        /// A person's preferred floor.
        /// </summary>
        [JsonProperty("floor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public HousingFloorPreferenceRequiredProperty Floor { get; set; }

        /// <summary>
        /// A person's preferred room.
        /// </summary>
        [JsonProperty("room", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public HousingPreferenceRequiredProperty Room { get; set; }
    }
}
