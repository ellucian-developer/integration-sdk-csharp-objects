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
    /// The titles and values for the configuration. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class CompoundConfigurationSettingsAssociatedSettings
    {


        /// <summary>
        /// The primary title for the configuration.
        /// </summary>

        [JsonProperty("primaryTitle", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PrimaryTitle { get; set; }

        /// <summary>
        /// The primary value for the configuration.
        /// </summary>

        [JsonProperty("primaryValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PrimaryValue { get; set; }

        /// <summary>
        /// The secondary title for the configuration.
        /// </summary>

        [JsonProperty("secondaryTitle", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string SecondaryTitle { get; set; }

        /// <summary>
        /// The secondary value for the configuration.
        /// </summary>

        [JsonProperty("secondaryValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string SecondaryValue { get; set; }

        /// <summary>
        /// The tertiary title for the configuration.
        /// </summary>

        [JsonProperty("tertiaryTitle", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TertiaryTitle { get; set; }

        /// <summary>
        /// The tertiary value for the configuration.
        /// </summary>

        [JsonProperty("tertiaryValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TertiaryValue { get; set; }


    }
}
