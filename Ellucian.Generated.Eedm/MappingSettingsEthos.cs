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
    public class MappingSettingsEthos
    {
        /// <summary>
        /// The Ethos resource(s) to which the mapping applies.
        /// </summary>

        [JsonProperty("resources", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<MappingSettingsEthosResources> Resources { get; set; }

        /// <summary>
        /// The Ethos enumeration value mapped from the source Colleague value.
        /// </summary>
        [JsonProperty("enumeration", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Enumeration { get; set; }
    }
}

