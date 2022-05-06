//Copyright 2020 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using Newtonsoft.Json;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The advanced search details for large datasets.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class DefaultAdvancedSearchProperty
    {
        /// <summary>
        /// The type of advanced search (advancedSearchAvailable or advancedSearchRequired).
        /// </summary>
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AdvanceSearchType? AdvanceSearchType { get; set; }

        /// <summary>
        /// The minimum number of provided characters required to perform a search.
        /// </summary>
        [JsonProperty("minSearchLength", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? MinSearchLength { get; set; }
    }
}