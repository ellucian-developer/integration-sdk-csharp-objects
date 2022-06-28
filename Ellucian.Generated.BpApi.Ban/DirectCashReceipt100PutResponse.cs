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

namespace Ellucian.Generated.BpApi.Ban.DirectCashReceipt100PutResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DirectCashReceipt100PutResponse
    {
        [Newtonsoft.Json.JsonProperty("fgbcshh", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Fgbcshh>? Fgbcshh { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("fgbcshd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Fgbcshd>? Fgbcshd { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Fgbcshh
    {
        [Newtonsoft.Json.JsonProperty("collectTaxDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CollectTaxDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHH_TRANS_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset TransDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHH_NSF_ON_OFF_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nsfOnOffInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NsfOnOffInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayCollectTax", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayCollectTax { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHH_DOC_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("docAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DocAmt { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Fgbcshd
    {
        [Newtonsoft.Json.JsonProperty("progTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProgTitle { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("fundTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_CURR_CODE, Lookup lineage reference object : gtvcurr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CurrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_TGRP_CODE, Lookup lineage reference object : ftvtrat,ftvtgrp,ftrtgtr,ftvtgrp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tgrpCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TgrpCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_COAS_CODE, Lookup lineage reference object : ftvcoas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coasCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoasCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("acctTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctTitle { get; set; } = default!;

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
        /// Lineage reference object : FGBCSHD_FUND_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("actvTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ActvTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_STATUS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statusInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatusInd { get; set; } = default!;

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
        /// Lineage reference object : FGBCSHD_DOC_REF_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("docRefNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DocRefNum { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayTaxDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayTaxDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("locnTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LocnTitle { get; set; } = default!;

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
        /// Lineage reference object : FGBCSHD_ACCT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("orgnTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrgnTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_FSYR_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fsyrCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FsyrCode { get; set; } = default!;

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

        [Newtonsoft.Json.JsonProperty("acciTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcciTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBCSHD_DIST_PCT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("distPct", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DistPct { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("coasTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CoasTitle { get; set; } = default!;

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