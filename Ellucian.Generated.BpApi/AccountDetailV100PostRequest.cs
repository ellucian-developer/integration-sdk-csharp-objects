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

namespace Ellucian.Generated.BpApi.Ban.AccountDetailV100PostRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AccountDetailV100PostRequest
    {
        /// <summary>
        /// Lineage reference object : TBRACCD_SRCE_CODE, Lookup lineage reference object : ttvsrce
        /// </summary>
        [Newtonsoft.Json.JsonProperty("srceCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SrceCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_DOCUMENT_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("documentNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DocumentNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_INV_NUMBER_PAID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invNumberPaid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InvNumberPaid { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_UNITS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("units", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Units { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : receiptGenInd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receiptGenInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? ReceiptGenInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_DETAIL_CODE, Lookup lineage reference object : tbbdetc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detailCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DetailCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : holdPassword
        /// </summary>
        [Newtonsoft.Json.JsonProperty("holdPassword", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? HoldPassword { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_RATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Rate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_MERCHANT_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchantId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MerchantId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_PAYMENT_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("paymentId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PaymentId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_ACCT_FEED_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctFeedInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AcctFeedInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_TRANS_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset TransDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_INVOICE_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invoiceNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InvoiceNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Id { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_TRAN_NUMBER_PAID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tranNumberPaid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TranNumberPaid { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_USER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string User { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_ATYP_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("atypCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AtypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_ATYP_SEQNO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("atypSeqno", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double AtypSeqno { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_EFFECTIVE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effectiveDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset EffectiveDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Desc { get; set; } = default!;

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