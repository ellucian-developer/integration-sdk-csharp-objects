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

namespace Ellucian.Generated.BpApi.Ban.FundCodeMaintenance100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class FundCodeMaintenance100GetResponse
    {
        [Newtonsoft.Json.JsonProperty("progTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProgTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_REST_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("restInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RestInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("srcCapSameInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SrcCapSameInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_DATA_ENTRY_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dataEntryInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DataEntryInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_FBAL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fbalInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FbalInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("bankCodeDescr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BankCodeDescr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_LOCN_CODE_CAP_DEF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("locnCodeCapDef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LocnCodeCapDef { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_ACCT_CODE_REV
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCodeRev", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCodeRev { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_FUND_CODE_BAVL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundCodeBavl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundCodeBavl { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_BAVL_SEVERITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bavlSeverity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BavlSeverity { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("fmgrNmC", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FmgrNmC { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_BAVL_KEY_ORGN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bavlKeyOrgn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BavlKeyOrgn { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_EFF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset EffDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_FUND_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FundCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_STATUS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statusInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatusInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_ORGN_CODE_CAP_DEF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orgnCodeCapDef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrgnCodeCapDef { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_FUND_CODE_SOURCE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundCodeSource", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundCodeSource { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_ACCT_CODE_ASSET
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCodeAsset", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCodeAsset { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_FUND_CODE_PRED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundCodePred", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundCodePred { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_ACTV_CODE_DEF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("actvCodeDef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ActvCodeDef { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("netAssetClassDescr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NetAssetClassDescr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_CONP_PROJ_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("conpProjNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ConpProjNum { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_ACCT_CODE_LOSS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCodeLoss", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCodeLoss { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_GRNT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grntCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GrntCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ttlFtyp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TtlFtyp { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("propDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PropDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_ORGN_CODE_ALLOC_CONTRA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orgnCodeAllocContra", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrgnCodeAllocContra { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_LOCN_CODE_DEF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("locnCodeDef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LocnCodeDef { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("revenueAcctDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RevenueAcctDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_NET_ASSET_CLASS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("netAssetClassCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NetAssetClassCode { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : spriden,ftvfmgr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ftvfmgrFmgrCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvfmgrFmgrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_DEPR_POST_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deprPostCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DeprPostCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("accrAcctDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AccrAcctDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_TERM_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TermDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_FTYP_CODE, Lookup lineage reference object : ftvftyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ftypCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FtypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_FUND_CODE_PLANT_CONP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundCodePlantConp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundCodePlantConp { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ctextInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CtextInd { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : spriden,ftvfmgr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ftvfmgrFmgrCodeConp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvfmgrFmgrCodeConp { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_PROJ_COMPLETE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("projCompleteDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ProjCompleteDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_FUND_CODE_ALLOC_TGT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundCodeAllocTgt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundCodeAllocTgt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_CUM_COST_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cumCostAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CumCostAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_EFF_CERT_ALLOC_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effCertAllocInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EffCertAllocInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("crbcDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CrbcDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_ACTV_CODE_CAP_DEF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("actvCodeCapDef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ActvCodeCapDef { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_CLOSE_PROJ_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("closeProjInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CloseProjInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_COAS_CODE, Lookup lineage reference object : ftvcoas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coasCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoasCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("acctTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_BAVL_KEY_FUND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bavlKeyFund", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BavlKeyFund { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_PROP_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("propCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PropCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_MAX_CONSTR_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maxConstrAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MaxConstrAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_ACCT_CODE_PLANT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCodePlant", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCodePlant { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_CASH_RECEIPT_BANK_CODE, Lookup lineage reference object : gxvbank
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cashReceiptBankCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CashReceiptBankCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_HIER_TABLE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hierTableInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HierTableInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_COST_CODE_CONP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("costCodeConp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CostCodeConp { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_DEPR_EXP_EQ_DEF_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deprExpEqDefInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DeprExpEqDefInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ttlSrc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TtlSrc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_PROG_CODE_CAP_DEF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("progCodeCapDef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProgCodeCapDef { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_BANK_CODE, Lookup lineage reference object : gxvbank
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bankCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BankCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_BAVL_KEY_ACCT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bavlKeyAcct", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BavlKeyAcct { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_BAVL_KEY_PROG
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bavlKeyProg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BavlKeyProg { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_ACCT_CODE_CIP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCodeCip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCodeCip { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_ACCT_CODE_EQUITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCodeEquity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCodeEquity { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_ALLOC_PCT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allocPct", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AllocPct { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_PROJ_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("projDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProjDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_PROJ_START_DATE_CONP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("projStartDateConp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ProjStartDateConp { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_PROJ_END_DATE_CONP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("projEndDateConp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ProjEndDateConp { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_BAVL_PERIOD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bavlPeriod", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BavlPeriod { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_EXPEND_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expendEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ExpendEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_ACCT_CODE_ALLOC_CONTRA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCodeAllocContra", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCodeAllocContra { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_ORGN_CODE_DEF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orgnCodeDef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrgnCodeDef { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_ACCT_CODE_ACCR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCodeAccr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCodeAccr { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("fmgrNm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FmgrNm { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ttlPred", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TtlPred { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_FUND_CODE_PLANT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundCodePlant", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundCodePlant { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("orgnTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrgnTitle { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayNchgDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DisplayNchgDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("grntDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GrntDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_EFF_CERT_REQUIRED_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effCertRequiredInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EffCertRequiredInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_PROG_CODE_DEF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("progCodeDef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProgCodeDef { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_ACCT_CODE_GAIN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCodeGain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCodeGain { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_PROG_CODE_ALLOC_CONTRA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("progCodeAllocContra", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProgCodeAllocContra { get; set; } = default!;

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