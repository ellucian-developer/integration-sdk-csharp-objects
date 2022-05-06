//Copyright 2019 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The Ethos resource (will only have one resouce in Colleague) and enumerations for the given mapping setting. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class MappingSettingsOptionsEthos
    {
        /// <summary>
        /// The Ethos resource to which the mapping applies.
        /// </summary>

        [JsonProperty("resources", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<MappingSettingsEthosResources> Resources { get; set; }

        /// <summary>
        /// The Ethos enumeration value mapped from the source Colleague value.
        /// </summary>
        [JsonProperty("enumerations", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> Enumerations { get; set; }
    }
}

