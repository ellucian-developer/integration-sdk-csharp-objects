//Copyright 2020 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The details for compound configuration values used for Ethos integration. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class CompoundConfigurationSettingsOptions_V1_0_0 : BaseModel2
    {
        
        /// <summary>
        /// The Ethos resources to which the compound configuration applies.
        /// </summary>

        [JsonProperty("ethos", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<CompoundConfigurationSettingsEthos> Ethos { get; set; }

        /// <summary>
        /// The source values for the associated configuration.
        /// </summary>

        [JsonProperty("source", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CompoundConfigurationSettingsOptionsSource Source { get; set; }       

    }
}