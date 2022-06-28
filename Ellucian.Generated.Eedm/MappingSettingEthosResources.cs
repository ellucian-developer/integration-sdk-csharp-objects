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
    public class MappingSettingsEthosResources
    {
        /// <summary>
        /// The Ethos resource to which the mapping applies.
        /// </summary>

        [JsonProperty("resource", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public string Resource { get; set; }

        /// <summary>
        /// The Ethos property name to which the mapping applies.
        /// </summary>

        [JsonProperty("propertyName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public string PropertyName { get; set; }

    }
}

