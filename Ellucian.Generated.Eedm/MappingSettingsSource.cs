//Copyright 2019 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The Ethos resource(s) to which the configuration applies. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class MappingSettingsSource
    {
        /// <summary>
        /// The source title for the mapping
        /// </summary>
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// The source value for the mapping
        /// </summary>
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Value { get; set; }
    }
}

