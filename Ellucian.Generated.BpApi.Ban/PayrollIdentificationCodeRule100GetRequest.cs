//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#nullable enable

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"
#pragma warning disable 3016 // Disable "CS3016 Arrays as attribute arguments is not CLS-compliant"
#pragma warning disable 8603 // Disable "CS8603 Possible null reference return"

namespace Ellucian.Generated.BpApi.Ban.PayrollIdentificationCodeRule100GetRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PayrollIdentificationCodeRule100GetRequest
    {
        /// <summary>
        /// Lineage reference object : PTRPICT_BANK_CODE, Lookup lineage reference object : gxvbank
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bankCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BankCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRPICT_TS_CUTOFF_DAYS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tsCutoffDays", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TsCutoffDays { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRPICT_TS_APR_CUTOFF_DAYS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tsAprCutoffDays", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TsAprCutoffDays { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRPICT_TAX_FACTOR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taxFactor", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double TaxFactor { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRPICT_UI_MIN_EARNINGS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uiMinEarnings", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UiMinEarnings { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRPICT_TS_CUTOFF_TIME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptrpictTsCutoffTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PtrpictTsCutoffTime { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRPICT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRPICT_TS_LEAVE_REQUESTS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tsLeaveRequests", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TsLeaveRequests { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRPICT_TS_WEB_VIEW_MONTHS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tsWebViewMonths", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TsWebViewMonths { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRPICT_SUPP_PAY_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("suppPayInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SuppPayInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRPICT_CODE_ORIG
        /// </summary>
        [Newtonsoft.Json.JsonProperty("codeOrig", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CodeOrig { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("tsAprCutoffTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TsAprCutoffTime { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRPICT_PAYS_PER_YEAR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("paysPerYear", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double PaysPerYear { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRPICT_CHECK_ISSUED_DAYS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("checkIssuedDays", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CheckIssuedDays { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("tsCutoffTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TsCutoffTime { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRPICT_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRPICT_UI_WEEKS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uiWeeks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UiWeeks { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRPICT_TS_PRIOR_AFTER_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tsPriorAfterInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TsPriorAfterInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRPICT_TS_APR_CUTOFF_TIME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptrpictTsAprCutoffTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PtrpictTsAprCutoffTime { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRPICT_TS_APR_PRIOR_AFTER_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tsAprPriorAfterInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TsAprPriorAfterInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRPICT_ROE_PERIOD_TYPE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("roePeriodType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RoePeriodType { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRPICT_CHECK_ISSUED_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("checkIssuedInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CheckIssuedInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRPICT_UI_MIN_HOURS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uiMinHours", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UiMinHours { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRPICT_UI_MAX_EARNINGS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uiMaxEarnings", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UiMaxEarnings { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603