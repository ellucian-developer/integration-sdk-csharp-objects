//Copyright 2017-2018 Ellucian Company L.P. and its affiliates.

using System;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm;
using Ellucian.Generated.Eedm.Attributes;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Accounting periods for particular duration. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class FiscalPeriods_V11_0 : BaseModel2
    {
        /// <summary>
        /// The full name of the fiscal period.
        /// </summary>

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// The fiscal year associated with the fiscal period.
        /// </summary>

        [JsonProperty("fiscalYear", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 FiscalYear { get; set; }

        /// <summary>
        /// The start date of the fiscal period.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime StartOn { get; set; }

        /// <summary>
        /// The end date of the fiscal period.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime EndOn { get; set; }

        /// <summary>
        /// The status of the fiscal period.
        /// </summary>

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public FiscalPeriodsStatus Status { get; set; }

    }
}
