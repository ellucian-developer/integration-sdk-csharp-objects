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
    public class CompoundConfigurationSettingsOptionsSource
    {
        /// <summary>
        /// The primary value (origin and source options) for the compound configuration setting options.
        /// </summary>

        [JsonProperty("primaryValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CompoundConfigurationSettingsOptionsPrimaryValue PrimaryValue { get; set; }

        /// <summary>
        /// The secondary value (origin and source options) for the compound configuration setting options.
        /// </summary>

        [JsonProperty("secondaryValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CompoundConfigurationSettingsOptionsSecondaryValue SecondaryValue { get; set; }

        /// <summary>
        /// The tertiary value (origin and source options) for the compound configuration setting options.
        /// </summary>

        [JsonProperty("tertiaryValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CompoundConfigurationSettingsOptionsTertiaryValue TertiaryValue { get; set; }

    }
}