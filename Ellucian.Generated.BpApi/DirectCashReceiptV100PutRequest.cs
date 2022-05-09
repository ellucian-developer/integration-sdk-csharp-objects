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

namespace Ellucian.Generated.BpApi.Ban.DirectCashReceiptV100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DirectCashReceiptV100PutRequest
    {
        /// <summary>
        /// Lineage reference object : FGBCSHD_DIST_PCT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.distPct", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaDistPct { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_TGRP_CODE, Lookup lineage reference object : ftvtrat,ftvtgrp,ftrtgtr,ftvtgrp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tgrpCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TgrpCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_CURR_CODE, Lookup lineage reference object : gtvcurr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CurrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_STATUS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.statusInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaStatusInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_TRANS_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.transDesc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaTransDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : documentNumber
        /// </summary>
        [Newtonsoft.Json.JsonProperty("documentNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? DocumentNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_COAS_CODE, Lookup lineage reference object : ftvcoas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coasCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoasCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_PROG_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.progCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaProgCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_LOCN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("locnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LocnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_ORGN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orgnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrgnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_DOC_REF_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.docRefNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaDocRefNum { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.displayTaxDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaDisplayTaxDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_ACCI_CODE, Lookup lineage reference object : ftvacci
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.acciCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaAcciCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_DEP_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.depNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaDepNum { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_FUND_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyBlockVendor
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vendor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Vendor { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHH_TRANS_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset TransDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_PROG_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("progCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProgCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_TRANS_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transAmt", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double TransAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_TRANS_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.transAmt", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CriteriaTransAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_DOC_REF_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("docRefNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DocRefNum { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_SEQ_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.seqNum", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CriteriaSeqNum { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_COAS_CODE, Lookup lineage reference object : ftvcoas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.coasCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaCoasCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayTaxDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayTaxDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_ACTV_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("actvCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ActvCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_DR_CR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("drCrInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DrCrInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_DEP_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("depNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DepNum { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_BANK_CODE, Lookup lineage reference object : gxvbank
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bankCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BankCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_LOCN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.locnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaLocnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_FUND_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.fundCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaFundCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_ACCT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.acctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaAcctCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_ABAL_OVERRIDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.abalOverride", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaAbalOverride { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_SEQ_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seqNum", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double SeqNum { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_ACCI_CODE, Lookup lineage reference object : ftvacci
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acciCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcciCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_ACTV_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.actvCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaActvCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_ABAL_OVERRIDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fgbcshdAbalOverride", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FgbcshdAbalOverride { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_ACCT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_DR_CR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.drCrInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaDrCrInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_CURR_CODE, Lookup lineage reference object : gtvcurr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.currCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCurrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_TGRP_CODE, Lookup lineage reference object : ftvtrat,ftvtgrp,ftrtgtr,ftvtgrp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.tgrpCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaTgrpCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_TRANS_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transDesc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TransDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_ABAL_OVERRIDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("abalOverride", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AbalOverride { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_DIST_PCT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("distPct", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DistPct { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_ORGN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.orgnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaOrgnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_BANK_CODE, Lookup lineage reference object : gxvbank
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.bankCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaBankCode { get; set; } = default!;

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