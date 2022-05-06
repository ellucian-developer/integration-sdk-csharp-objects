//Copyright 2020 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The source values for a configuration with three associated settings. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class CompoundConfigurationSettingsSource
    {
        /// <summary>
        /// The primary display label for the configuration.
        /// </summary>

        [JsonProperty("primaryDisplayLabel", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PrimaryDisplayLabel { get; set; }

        /// <summary>
        /// The secondary display label for the configuration.
        /// </summary>

        [JsonProperty("secondaryDisplayLabel", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string SecondaryDisplayLabel { get; set; }

        /// <summary>
        /// The tertiary display label for the configuration.
        /// </summary>

        [JsonProperty("tertiaryDisplayLabel", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TertiaryDisplayLabel { get; set; }

        /// <summary>
        /// The titles and values for the configuration.
        /// </summary>

        [JsonProperty("associatedSettings", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<CompoundConfigurationSettingsAssociatedSettings> AssociatedSettings { get; set; }


        /// <summary>
        /// The titles and values for the configuration.
        /// </summary>

        [JsonProperty("pairedSettings", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<CompoundConfigurationSettingsPairedSettings> PairedSettings { get; set; }
    }
}