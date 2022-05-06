//Copyright 2019 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The Ethos resource(s) to which the configuration applies. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class DefaultSettingsEthos
    {
        /// <summary>
        /// The Ethos resource(s) to which the configuration applies.
        /// </summary>

        [JsonProperty("resource", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public string Resource { get; set; }

        /// <summary>
        /// The Ethos propertyName(s) to which the configuration applies.
        /// </summary>

        [JsonProperty("propertyName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public string PropertyName { get; set; }
    }
}

