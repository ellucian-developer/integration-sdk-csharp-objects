// Copyright 2015-2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Ellucian.Generated.Eedm;
using Ellucian.Generated.Eedm.Attributes;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// AccountingCodeCategoryDtoProperty 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class AccountingCodeCategoryDtoProperty 
    {
        /// <summary>
        /// The usage of the accounting code.
        /// </summary>
        [JsonProperty("usage", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public AccountingCodeCategoryType AccountingCodeCategory { get; set; }

        /// <summary>
        /// The user defined category of the accounting code.
        /// </summary>
        [JsonProperty("detail", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 Detail { get; set; }
    }
}