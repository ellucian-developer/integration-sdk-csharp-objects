// Copyright 2019 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The employement status type and detail
    /// </summary>
    [DataContract]
    public class StudentPaymentsReportingDtoProperty
    {

        /// <summary>
        /// The usage associated with the charge (i.e. tax reporting only).
        /// </summary>
        [JsonProperty("usage", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public StudentPaymentUsageTypes? Usage { get; set; }

        /// <summary>
        /// The date the charge originated for sonsideration in tax report generation.
        /// </summary>
        [JsonProperty("originatedOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? OriginatedOn { get; set; }
    }
}