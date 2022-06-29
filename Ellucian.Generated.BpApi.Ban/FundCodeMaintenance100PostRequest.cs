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

namespace Ellucian.Generated.BpApi.Ban.FundCodeMaintenance100PostRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class FundCodeMaintenance100PostRequest
    {
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

        /// <summary>
        /// Lineage reference object : FTVFUND_COAS_CODE, Lookup lineage reference object : ftvcoas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coasCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoasCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_ACCT_CODE_REV
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCodeRev", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCodeRev { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; } = default!;

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
        /// Lineage reference object : FTVFUND_ACCT_CODE_PLANT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCodePlant", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCodePlant { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_STATUS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statusInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatusInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_CASH_RECEIPT_BANK_CODE, Lookup lineage reference object : gxvbank
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cashReceiptBankCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CashReceiptBankCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_NET_ASSET_CLASS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("netAssetClass", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NetAssetClass { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_FUND_CODE_PRED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundCodePred", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundCodePred { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_BANK_CODE, Lookup lineage reference object : gxvbank
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bankCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BankCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_ACTV_CODE_DEF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("actvCodeDef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ActvCodeDef { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_GRNT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grntCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GrntCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_EXPEND_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expendEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ExpendEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_ORGN_CODE_DEF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orgnCodeDef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrgnCodeDef { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_LOCN_CODE_DEF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("locnCodeDef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LocnCodeDef { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_ACCT_CODE_ACCR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCodeAccr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCodeAccr { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("fmgrNm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FmgrNm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_FUND_CODE_PLANT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundCodePlant", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundCodePlant { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : spriden,ftvfmgr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ftvfmgrFmgrCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvfmgrFmgrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFUND_EFF_CERT_REQUIRED_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effCertRequiredInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EffCertRequiredInd { get; set; } = default!;

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
        /// Lineage reference object : FTVFUND_PROG_CODE_DEF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("progCodeDef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProgCodeDef { get; set; } = default!;

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