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
    /// Housing request roommate preference
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class HousingRequestRoommatePreferenceProperty
    {
        /// <summary>
        /// The person's preferred roommate.
        /// </summary>
        [JsonProperty("roommate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public HousingPreferenceRequiredProperty Roommate { get; set; }

        /// <summary>
        /// The person's preferred roommate characteristic.
        /// </summary>
        [JsonProperty("roommateCharacteristic", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public HousingPreferenceRequiredProperty RoommateCharacteristic { get; set; }
    }
}
