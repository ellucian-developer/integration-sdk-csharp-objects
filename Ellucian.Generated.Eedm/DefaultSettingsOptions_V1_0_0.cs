//Copyright 2019 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The details for configuration values used for Ethos integration. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class DefaultSettingsOptions_V1_0_0 : BaseModel2
    {
        /// <summary>
        /// The Ethos resource(s) to which the configuration applies.
        /// </summary>
        [JsonProperty("ethos", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<DefaultSettingsEthos> Ethos { get; set; }

        /// <summary>
        /// The source values for the configuration.
        /// </summary>
        [JsonProperty("sourceOptions", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<DefaultSettingsSourceOptions_V1_0_0> SourceOptions { get; set; }
    }
}
