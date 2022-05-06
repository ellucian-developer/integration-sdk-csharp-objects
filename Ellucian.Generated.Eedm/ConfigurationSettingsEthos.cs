//Copyright 2019 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The Ethos resource(s) to which the configuration applies. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ConfigurationSettingsEthos
    {
        /// <summary>
        /// The Ethos resource(s) to which the configuration applies.
        /// </summary>

        [JsonProperty("resources", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public List<string> Resources { get; set; }
    }
}

