// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm.Filters
{
    /// <summary>
    /// Filter for the detailed activity that is posted against the ledger. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class LedgerActivityFilter 
    {     
        /// <summary>
        /// The reporting segment with which the ledger activity is associated (e.g. chart, campus, institution, etc.).
        /// </summary>
        [JsonProperty("reportingSegment", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public string ReportingSegment { get; set; }
      
        /// <summary>
        /// The fiscal period during which the activity is posted to the ledger.
        /// </summary>
        [JsonProperty("fiscalPeriod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 FiscalPeriod { get; set; }

        /// <summary>
        /// The fiscal period during which the activity is posted to the ledger.
        /// </summary>
        [JsonProperty("period", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 Period { get; set; }


        /// <summary>
        /// The fiscal year during which the activity is posted to the ledger.
        /// </summary>
        [JsonProperty("fiscalYear", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 FiscalYear { get; set; }

        /// <summary>
        /// The date the activity is posted to the account in the ledger.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("transactionDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public DateTime? TransactionDate { get; set; }
     
    }
}
