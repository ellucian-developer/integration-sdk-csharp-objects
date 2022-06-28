//Copyright 2019 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A list of defined tax rates and their associated codes. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class CommerceTaxCodeRates_V1_0_0 : CodeItem2
    {
        /// <summary>
        /// The default compounding order in which the tax code rate will be applied.
        /// </summary>
        [JsonProperty("defaultCompoundingSequence", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int DefaultCompoundingSequence { get; set; }

        /// <summary>
        /// The tax percentage associated with the tax code rate.
        /// </summary>
        [JsonProperty("taxPercentage", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal TaxPercentage { get; set; }

        /// <summary>
        /// The tax rebate percentage associated with the tax code rate.
        /// </summary>
        [JsonProperty("taxRebatePercentage", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal? TaxRebatePercentage { get; set; }

        /// <summary>
        /// The first date that the tax code rate is effective.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime StartOn { get; set; }

        /// <summary>
        /// The last date that the tax code rate is effective.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime EndOn { get; set; }

        /// <summary>
        /// The tax code(s) which are associated with the commerce tax code rate.
        /// </summary>
        [JsonProperty("taxCodes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<GuidObject2> TaxCodes { get; set; }

    }
}