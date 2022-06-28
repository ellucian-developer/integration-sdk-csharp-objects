//Copyright 2019 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The Ethos resource(s) to which the configuration applies. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class DefaultSettingsSourceOptions_V1_0_0
    {
        /// <summary>
        /// The source title for the configuration
        /// </summary>
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// The source value for the configuration
        /// </summary>
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// The origin for the source configuration option setting
        /// </summary>
        [JsonProperty("origin", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Origin { get; set; }
    }
}

