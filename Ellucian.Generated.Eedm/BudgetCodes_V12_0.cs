//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Collections of budget phases for one or more fiscal years. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class BudgetCodes_V12_0 : CodeItem2
    {
        /// <summary>
        /// The segment with which the budget code is associated.
        /// </summary>
        [JsonProperty("reportingSegment", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ReportingSegment { get; set; }

        /// <summary>
        /// The fiscal year associated with the budget code.
        /// </summary>
        [JsonProperty("fiscalYear", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 FiscalYear { get; set; }

    }
}