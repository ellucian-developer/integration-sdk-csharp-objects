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
    /// The requested preferences for the room assignment. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class HousingAssignmentPreferenceProperty
    {
        /// <summary>
        /// A reference to the student's request for housing.
        /// </summary>

        [JsonProperty("housingRequest", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 HousingRequest { get; set; }
    }
}
