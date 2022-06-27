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

namespace Ellucian.Generated.BpApi.Ban.StudentDetailCodesV100PutResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class StudentDetailCodesV100PutResponse
    {
        [Newtonsoft.Json.JsonProperty("tbbdetc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Tbbdetc>? Tbbdetc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("tbracct2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Tbracct2>? Tbracct2 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("tbbeact", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Tbbeact>? Tbbeact { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Tbbdetc
    {
        /// <summary>
        /// Lineage reference object : TBBDETC_DETAIL_CODE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detailCodeInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DetailCodeInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("taxMethod", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TaxMethod { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBDETC_DETC_ACTIVE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detcActiveInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DetcActiveInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBDETC_PAYHIST_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payhistInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PayhistInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBDETC_PREBILL_PRINT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prebillPrintInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PrebillPrintInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBDETC_TIV_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tivInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TivInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBDETC_TBDC_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbdcInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbdcInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBDETC_LIKE_TERM_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("likeTermInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LikeTermInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBDETC_GL_NOS_ENTERABLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("glNosEnterable", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GlNosEnterable { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("likeScpInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LikeScpInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("tbbdectNonAllowChgInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbbdectNonAllowChgInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBDETC_AMOUNT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Amount { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBDETC_TYPE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("typeInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TypeInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBDETC_PAYT_CODE, Lookup lineage reference object : ttvpayt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("paytCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PaytCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBDETC_REFUND_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refundInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RefundInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBDETC_LIKE_AIDY_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("likeAidyInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LikeAidyInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBDETC_LIKE_PERIOD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("likePeriodInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LikePeriodInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBDETC_PRIORITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("priority", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Priority { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBDETC_DETAIL_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detailCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DetailCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBDETC_RECEIPT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receiptInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ReceiptInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("taxProfile", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TaxProfile { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBDETC_DCAT_CODE, Lookup lineage reference object : ttvdcat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dcatCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DcatCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBDETC_ABDC_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("abdcInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AbdcInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBDETC_DIRD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dirdInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DirdInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBDETC_REFUNDABLE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refundableInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RefundableInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBDETC_TAXT_CODE, Lookup lineage reference object : ttvtaxt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taxtCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TaxtCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBDETC_INST_CHG_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instChgInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InstChgInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBDETC_EFFECTIVE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effectiveDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EffectiveDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBDETC_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Desc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBDETC_TERM_CODE, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermCode { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Tbracct2
    {
        /// <summary>
        /// Lineage reference object : TBRACCT_A_ORGN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbracctAOrgnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbracctAOrgnCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("tbracctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbracctCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCT_B_RUCL_CODE2
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbracctBRuclCode2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbracctBRuclCode2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCT_B_RUCL_CODE3
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbracctBRuclCode3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbracctBRuclCode3 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCT_A_ACCI_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbracctAAcciCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbracctAAcciCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCT_B_ORGN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbracctBOrgnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbracctBOrgnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCT_B_RUCL_CODE1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbracctBRuclCode1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbracctBRuclCode1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCT_A_ACTV_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbracctAActvCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbracctAActvCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCT_B_ACTV_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbracctBActvCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbracctBActvCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCT_A_RUCL_CODE1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbracctARuclCode1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbracctARuclCode1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCT_A_RUCL_CODE2
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbracctARuclCode2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbracctARuclCode2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCT_B_FUND_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbracctBFundCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbracctBFundCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCT_A_RUCL_CODE3
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbracctARuclCode3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbracctARuclCode3 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCT_A_FUND_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbracctAFundCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbracctAFundCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCT_A_LOCN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbracctALocnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbracctALocnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCT_B_ACCT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbracctBAcctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbracctBAcctCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCT_A_PROG_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbracctAProgCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbracctAProgCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCT_B_PROG_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbracctBProgCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbracctBProgCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCT_A_ACCT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbracctAAcctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbracctAAcctCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCT_B_COAS_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbracctBCoasCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbracctBCoasCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCT_A_COAS_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbracctACoasCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbracctACoasCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCT_PERCENT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbracctPercent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TbracctPercent { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCT_B_ACCI_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbracctBAcciCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbracctBAcciCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCT_B_LOCN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbracctBLocnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbracctBLocnCode { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Tbbeact
    {
        [Newtonsoft.Json.JsonProperty("detailDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DetailDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBEACT_EFF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset EffDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayNchgDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DisplayNchgDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBEACT_ABDC_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("abdcInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AbdcInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBEACT_DETAIL_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detailCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DetailCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBEACT_TBDC_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbdcInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbdcInd { get; set; } = default!;

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