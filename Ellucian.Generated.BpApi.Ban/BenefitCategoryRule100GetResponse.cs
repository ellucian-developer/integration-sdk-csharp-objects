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

namespace Ellucian.Generated.BpApi.Ban.BenefitCategoryRule100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BenefitCategoryRule100GetResponse
    {
        [Newtonsoft.Json.JsonProperty("ptrbcat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Ptrbcat>? Ptrbcat { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ptrbcdn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Ptrbcdn>? Ptrbcdn { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Ptrbcat
    {
        [Newtonsoft.Json.JsonProperty("calcFactor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CalcFactor { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBCAT_NEWHIRE_ENROLL_DAYS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("newhireEnrollDays", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NewhireEnrollDays { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBCAT_FLEX_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("flexAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FlexAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBCAT_OPEN_BEGIN_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openBeginDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? OpenBeginDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBCAT_ENRL_BASE_DATE_METHOD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enrlBaseDateMethod", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EnrlBaseDateMethod { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBCAT_OPEN_EFFECTIVE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openEffectiveDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? OpenEffectiveDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBCAT_WEB_ACCESS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webAccessInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebAccessInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBCAT_DATE_OVERRIDE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dateOverrideInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DateOverrideInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBCAT_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Desc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBCAT_OPEN_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? OpenEndDate { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Ptrbcdn
    {
        /// <summary>
        /// Lineage reference object : PTRBCDN_NEWHIRE_CUTOFF_DAY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("newhireCutoffDay", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NewhireCutoffDay { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBCDN_WAIT_DAY_MONTH_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waitDayMonthInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaitDayMonthInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("defaultValuesInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DefaultValuesInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBCDN_DISP_ON_STMT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dispOnStmtInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DispOnStmtInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBCDN_BDCA_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bdcaCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BdcaCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBCDN_SEQ_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seqNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SeqNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBCDN_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBCDN_ENRL_BEGIN_DATE_METHOD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enrlBeginDateMethod", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EnrlBeginDateMethod { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBCDN_REQ_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reqInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ReqInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stmtSetupBdsgDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StmtSetupBdsgDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBCDN_BEGIN_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("beginDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset BeginDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBCDN_SETUP_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("setupInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SetupInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBCDN_BEGIN_DATE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("beginDateInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BeginDateInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBCDN_ACA_START_PLAN_MONTH
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acaStartPlanMonth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AcaStartPlanMonth { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("bdcaDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BdcaDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBCDN_COVERAGE_END_DATE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coverageEndDateInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoverageEndDateInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBCDN_NEWHIRE_WAITING_PERIOD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("newhireWaitingPeriod", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NewhireWaitingPeriod { get; set; } = default!;

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