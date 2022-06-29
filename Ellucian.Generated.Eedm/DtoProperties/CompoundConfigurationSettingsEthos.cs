//Copyright 2020 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The Ethos resources to which the compound configuration applies. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class CompoundConfigurationSettingsEthos
    {
        
        /// <summary>
        /// The Ethos resource to which the compound configuration applies.
        /// </summary>

        [JsonProperty("resource", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public string Resource { get; set; }

        /// <summary>
        /// The Ethos property to which the compound configuration applies.
        /// </summary>

        [JsonProperty("propertyName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public string PropertyName { get; set; }


    }
}
