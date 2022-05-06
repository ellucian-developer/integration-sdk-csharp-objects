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
    /// The status of the supplementary item. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class AdmissionApplicationSupportingItemsStatus
    {
        /// <summary>
        /// Status type of the supplementary item.
        /// </summary>

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AdmissionApplicationSupportingItemsType Type { get; set; }

        /// <summary>
        /// Custom status type of the supplementary item.
        /// </summary>

        [JsonProperty("detail", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Detail { get; set; }

    }
}

