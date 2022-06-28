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

namespace Ellucian.Generated.BpApi.Ban.ResearchAccountingFundMaintenance100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ResearchAccountingFundMaintenance100GetResponse
    {
        [Newtonsoft.Json.JsonProperty("inddCodeDistrName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InddCodeDistrName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRVFUND_WITHHOLDING_PERCENT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("withholdingPercent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? WithholdingPercent { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRVFUND_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("wholdingArAcctCodeDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WholdingArAcctCodeDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("basiCodeIcName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BasiCodeIcName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRVFUND_COAS_CODE, Lookup lineage reference object : ftvcoas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coasCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoasCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("acctCodeRev", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCodeRev { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("cstrCodeRateName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CstrCodeRateName { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("grntCodeDisplay1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GrntCodeDisplay1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRVFUND_CSTA_CODE_CHARGE, Lookup lineage reference object : frbcsta,frvcsta
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cstaCodeCharge", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CstaCodeCharge { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRVFUND_CSTD_CODE_DISTR, Lookup lineage reference object : frbcstd,frvcstd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cstdCodeDistr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CstdCodeDistr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRVFUND_EFF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset EffDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRVFUND_ENC_MULT_YR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("encMultYrInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EncMultYrInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("grntTitleDisplay1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GrntTitleDisplay1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRVFUND_WITHHOLDING_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("withholdingAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? WithholdingAmt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("cashReceiptBankCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CashReceiptBankCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRVFUND_BILLED_AR_ACCT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("billedArAcctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BilledArAcctCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("indrCodeRateName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IndrCodeRateName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRVFUND_BASI_CODE_IC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("basiCodeIc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BasiCodeIc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRVFUND_WHOLDING_AR_ACCT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wholdingArAcctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WholdingArAcctCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRVFUND_BUDG_PRD_START_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budgPrdStartDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? BudgPrdStartDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRVFUND_BUDG_PRD_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budgPrdEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? BudgPrdEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRVFUND_INDD_CODE_DISTR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inddCodeDistr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InddCodeDistr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRVFUND_IDC_ENC_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("idcEncInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IdcEncInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRVFUND_INDR_CODE_RATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("indrCodeRate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IndrCodeRate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("billedArAcctCodeDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BilledArAcctCodeDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("cstaCodeChargeName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CstaCodeChargeName { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("acctCodeAccr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCodeAccr { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("indaCodeChargeName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IndaCodeChargeName { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("cstdCodeDistrName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CstdCodeDistrName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRVFUND_BASI_CODE_CS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("basiCodeCs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BasiCodeCs { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayNchgDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DisplayNchgDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRVFUND_CSTR_CODE_RATE, Lookup lineage reference object : frrcstr,frvcstr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cstrCodeRate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CstrCodeRate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("basiCodeCsName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BasiCodeCsName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRVFUND_TERM_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TermDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRVFUND_INDA_CODE_CHARGE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("indaCodeCharge", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IndaCodeCharge { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ftvfundTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvfundTitle { get; set; } = default!;

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