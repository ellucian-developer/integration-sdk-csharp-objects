// Copyright 2018 Ellucian Company L.P. and its affiliates.
using System;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;

namespace Ellucian.Generated.Eedm.Filters
{
    /// <summary>
    /// Filter for account-funds-available and accountSpecifications named query
    /// </summary>
    public class AccountingStringsFilter
    {
        /// <summary>
        /// Filter to return all records effective on a given date.
        /// </summary>
        [JsonProperty("effectiveOn")]
        [FilterProperty("effectiveOn")]
        public DateTime? EffectiveOn { get; set; }
    }
}
