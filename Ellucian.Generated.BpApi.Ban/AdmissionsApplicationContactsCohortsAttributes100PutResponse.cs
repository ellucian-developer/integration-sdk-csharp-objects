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

namespace Ellucian.Generated.BpApi.Ban.AdmissionsApplicationContactsCohortsAttributes100PutResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AdmissionsApplicationContactsCohortsAttributes100PutResponse
    {
        [Newtonsoft.Json.JsonProperty("saradap", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Saradap>? Saradap { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("sorcont", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Sorcont>? Sorcont { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("sarchrt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Sarchrt>? Sarchrt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("saraatt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Saraatt>? Saraatt { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Saradap
    {
        [Newtonsoft.Json.JsonProperty("reqDocInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ReqDocInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_APPL_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ApplDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvapdcDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvapdcDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("termCodeEntryDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermCodeEntryDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_MAINT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maintInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MaintInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_SBGI_CODE, Lookup lineage reference object : stvsbgi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sbgiCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SbgiCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_FEE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("feeDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FeeDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_APST_CODE, Lookup lineage reference object : stvapst
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apstCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ApstCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_SESS_CODE, Lookup lineage reference object : stvsess
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sessCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SessCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("waivDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WaivDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_RECR_CODE, Lookup lineage reference object : stvrecr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recrCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RecrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_WRSN_CODE, Lookup lineage reference object : stvwrsn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wrsnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WrsnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_TERM_CODE_ENTRY, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCodeEntry", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermCodeEntry { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvadmtDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvadmtDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvresdDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvresdDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_WEB_AMOUNT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? WebAmount { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvintvDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvintvDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvsessDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvsessDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_RESD_CODE, Lookup lineage reference object : stvresd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ResdCode { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvapdc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sarappdApdcCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SarappdApdcCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("edlvDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EdlvDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_INTV_CODE, Lookup lineage reference object : stvintv
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intvCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IntvCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_WAIV_CODE, Lookup lineage reference object : stvwaiv
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waivCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WaivCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_FEE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("feeInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FeeInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_RTYP_CODE, Lookup lineage reference object : stvrtyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rtypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RtypCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("changeFeeInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ChangeFeeInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("tbbdetcAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TbbdetcAmt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("egolDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EgolDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_EDLV_CODE, Lookup lineage reference object : stvedlv
        /// </summary>
        [Newtonsoft.Json.JsonProperty("edlvCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EdlvCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_WEB_RECEIPT_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webReceiptNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? WebReceiptNumber { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvrecrDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvrecrDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_RATE_CODE, Lookup lineage reference object : stvrate
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rateCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RateCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("decMaintIndDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DecMaintIndDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_APST_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apstDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ApstDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_ADMT_CODE, Lookup lineage reference object : stvadmt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("admtCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AdmtCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvrtypDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvrtypDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvstypDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvstypDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvsbgiDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvsbgiDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("tbbdetcDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbbdetcDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("statMaintIndDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatMaintIndDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_FULL_PART_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fullPartInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FullPartInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_WEB_TRANS_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webTransNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? WebTransNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_SITE_CODE, Lookup lineage reference object : stvsite
        /// </summary>
        [Newtonsoft.Json.JsonProperty("siteCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SiteCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_APPL_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ApplNo { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvsiteDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvsiteDesc { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : tbbdetc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detailCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DetailCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvapstDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvapstDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("sarappdApdcDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? SarappdApdcDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvwrsnDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvwrsnDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvrateDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvrateDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_APPL_PREFERENCE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applPreference", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ApplPreference { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_EGOL_CODE, Lookup lineage reference object : stvegol
        /// </summary>
        [Newtonsoft.Json.JsonProperty("egolCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EgolCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_STYP_CODE, Lookup lineage reference object : stvstyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_WEB_ACCT_MISC_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webAcctMiscInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebAcctMiscInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("sarappdMaintInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SarappdMaintInd { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Sorcont
    {
        [Newtonsoft.Json.JsonProperty("contDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ContDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCONT_CONTACT_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contactDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ContactDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCONT_CTYP_CODE, Lookup lineage reference object : stvctyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ctypCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CtypCode { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Sarchrt
    {
        /// <summary>
        /// Lineage reference object : SARCHRT_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARCHRT_CHRT_CODE, Lookup lineage reference object : stvchrt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chrtCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChrtCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("chrtDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ChrtDesc { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Saraatt
    {
        /// <summary>
        /// Lineage reference object : SARAATT_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARAATT_ATTS_CODE, Lookup lineage reference object : stvatts
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attsCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AttsCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARAATT_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("attsDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AttsDesc { get; set; } = default!;

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