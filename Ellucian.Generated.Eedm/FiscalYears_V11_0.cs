//Copyright 2017-2018 Ellucian Company L.P. and its affiliates.

using System;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Attributes;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The periods of time that an institution uses for accounting and financial statement purposes. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class FiscalYears_V11_0 : BaseModel2
    {
        /// <summary>
        /// The full name of the fiscal year.
        /// </summary>
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// The segment of the educational institution used for reporting purposes.
        /// </summary>
        [JsonProperty("reportingSegment", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public string ReportingSegment { get; set; }

        /// <summary>
        /// The start date of the fiscal year.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? StartOn { get; set; }

        /// <summary>
        /// The end date of the fiscal year.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? EndOn { get; set; }

        /// <summary>
        /// The number of periods in the fiscal year.
        /// </summary>
        [JsonProperty("numberOfPeriods", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int NumberOfPeriods { get; set; }

        /// <summary>
        /// An indication whether the year end adjustment is active or inactive.
        /// </summary>
        [JsonProperty("yearEndAdjustment", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public FiscalYearsYearEndAdjustment YearEndAdjustment { get; set; }

        /// <summary>
        /// The status of the fiscal year.
        /// </summary>
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public FiscalPeriodsStatus Status { get; set; }

    }
}