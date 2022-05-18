//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
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

namespace Ellucian.Generated.BpApi.Ban.MassTimeEntryV100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class MassTimeEntryV100PutRequest
    {
        /// <summary>
        /// Lineage reference object : PHRMTIM_PROJ_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("projCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProjCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : year
        /// </summary>
        [Newtonsoft.Json.JsonProperty("year", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Year { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_SUFF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.suff", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaSuff { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_SHIFT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shift", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Shift { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_SPECIAL_RATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("specialRate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SpecialRate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.endDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_COAS_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coasCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CoasCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_PROG_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.progCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaProgCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_LOCN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("locnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LocnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_CTYP_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.ctypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCtypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_ORGN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orgnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrgnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_BEGIN_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.beginDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CriteriaBeginDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : pictCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pictCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? PictCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_ACCI_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.acciCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaAcciCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_SUFF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("suff", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Suff { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_PERCENT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.percent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaPercent { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_PROG_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("progCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProgCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_SHIFT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.shift", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaShift { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_COAS_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.coasCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCoasCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_POSN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.posn", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaPosn { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_ACTV_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("actvCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ActvCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_PROJ_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.projCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaProjCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_EFFECTIVE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.effectiveDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaEffectiveDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_FUND_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.fundCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaFundCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_ACCT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.acctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaAcctCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_LOCN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.locnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaLocnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_DEEMED_HRS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deemedHrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DeemedHrs { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_SPECIAL_RATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.specialRate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaSpecialRate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_ACCI_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acciCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcciCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_HRS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hrs", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Hrs { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_ACTV_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.actvCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaActvCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("deleteInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DeleteInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_EARN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("earnCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EarnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_ACCT_CODE_EXTERNAL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.acctCodeExternal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaAcctCodeExternal { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_ACCT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : payno
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payno", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Payno { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_BEGIN_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("beginDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset BeginDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_EARN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.earnCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaEarnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_DEEMED_HRS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.deemedHrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaDeemedHrs { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_HRS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.hrs", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CriteriaHrs { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_CTYP_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ctypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CtypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_ORGN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.orgnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaOrgnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRMTIM_EFFECTIVE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effectiveDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EffectiveDate { get; set; } = default!;

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