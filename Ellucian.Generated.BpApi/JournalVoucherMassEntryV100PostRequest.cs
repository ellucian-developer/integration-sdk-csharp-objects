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

namespace Ellucian.Generated.BpApi.Ban.JournalVoucherMassEntryV100PostRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class JournalVoucherMassEntryV100PostRequest
    {
        /// <summary>
        /// Lineage reference object : FGBJVCD_CURR_CODE, Lookup lineage reference object : gtvcurr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CurrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBJVCD_PRJD_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prjdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PrjdCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBJVCD_COAS_CODE, Lookup lineage reference object : ftvcoas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coasCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoasCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBJVCD_LOCN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("locnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LocnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBJVCD_ORGN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orgnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrgnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBJVCD_FUND_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBJVCD_STATUS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statusInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatusInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBJVCD_BUDGET_PERIOD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budgetPeriod", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BudgetPeriod { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBJVCH_TRANS_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset TransDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBJVCD_PROG_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("progCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProgCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBJVCD_TRANS_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transAmt", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double TransAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBJVCD_EMC_UNITS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("emcUnits", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? EmcUnits { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBJVCH_NSF_ON_OFF_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nsfOnOffInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NsfOnOffInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBJVCD_ACTV_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("actvCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ActvCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBJVCH_DOC_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("docAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DocAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBJVCD_DR_CR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("drCrInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DrCrInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBJVCD_DEP_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("depNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DepNum { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBJVCD_BANK_CODE, Lookup lineage reference object : gxvbank
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bankCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BankCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBJVCD_SEQ_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seqNum", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double SeqNum { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBJVCD_GIFT_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("giftDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? GiftDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBJVCD_ACCI_CODE, Lookup lineage reference object : ftvacci
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acciCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcciCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBJVCD_ACCT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBJVCH_EDIT_DEFER_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("editDeferInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EditDeferInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBJVCD_TRANS_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transDesc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TransDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBJVCD_ABAL_OVERRIDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("abalOverride", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AbalOverride { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBJVCD_RUCL_CODE, Lookup lineage reference object : ftvrucl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ruclCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RuclCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBJVCD_DIST_PCT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("distPct", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DistPct { get; set; } = default!;

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