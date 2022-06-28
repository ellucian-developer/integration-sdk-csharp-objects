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

namespace Ellucian.Generated.BpApi.Ban.FinanceDetailCodes100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class FinanceDetailCodes100GetResponse
    {
        [Newtonsoft.Json.JsonProperty("tbbdetc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Tbbdetc>? Tbbdetc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("tbbeact", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Tbbeact>? Tbbeact { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("tbracct", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Tbracct>? Tbracct { get; set; } = default!;

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
        /// Lineage reference object : TBBDETC_DETAIL_CODE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detailCodeInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DetailCodeInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBDETC_PAYT_CODE, Lookup lineage reference object : ttvpayt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("paytCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PaytCode { get; set; } = default!;

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
        /// Lineage reference object : TBBDETC_REFUND_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refundInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RefundInd { get; set; } = default!;

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

        /// <summary>
        /// Lineage reference object : TBBDETC_PREBILL_PRINT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prebillPrintInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PrebillPrintInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBDETC_LIKE_TERM_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("likeTermInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LikeTermInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("taxProfile", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TaxProfile { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBDETC_DCAT_CODE, Lookup lineage reference object : ttvdcat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dcatCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DcatCode { get; set; } = default!;

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
        /// Lineage reference object : TBBDETC_GL_NOS_ENTERABLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("glNosEnterable", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GlNosEnterable { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBDETC_TAXT_CODE, Lookup lineage reference object : ttvtaxt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taxtCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TaxtCode { get; set; } = default!;

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

        [Newtonsoft.Json.JsonProperty("likeScpInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LikeScpInd { get; set; } = default!;

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
        /// Lineage reference object : TBBEACT_DETAIL_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detailCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DetailCode { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Tbracct
    {
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Code { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCT_ACCOUNT_B
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accountB", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AccountB { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCT_ACCOUNT_A
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accountA", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AccountA { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("accountPercent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AccountPercent { get; set; } = default!;

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