//Copyright 2020 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The details for default settings advanced search options used for Ethos integration. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    //public class DefaultSettingsAdvancedSearchOptions : BaseModel2
    public class DefaultSettingsAdvancedSearchOptions_V1_0_0
    {
        /// <summary>
        /// The full name of the default settings advanced search option.
        /// </summary>
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// The value for the default settings advanced search option.
        /// </summary>
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 	The origin of the default settings advanced search option.
        /// </summary>
        [JsonProperty("origin", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Origin { get; set; }
    }
}
