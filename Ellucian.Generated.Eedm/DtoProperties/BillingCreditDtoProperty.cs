// Copyright 2017-2018 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Billing credit DTO Property
    /// </summary>
    public class BillingCreditDtoProperty
    { 
        /// <summary>
        /// Billing credit minimum
        /// </summary>
        [JsonProperty("minimum")]
        public decimal Minimum { get; set; }

        /// <summary>
        /// Billing credit maximum
        /// </summary>
        [JsonProperty("maximum", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal? Maximum { get; set; }

        /// <summary>
        /// Billing credit increment
        /// </summary>
        [JsonProperty("increment", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal? Increment { get; set; }  
    }
}
