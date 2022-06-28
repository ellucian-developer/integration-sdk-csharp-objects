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

namespace Ellucian.Generated.BpApi.Ban.AccountDetailDeposits100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AccountDetailDeposits100GetResponse
    {
        [Newtonsoft.Json.JsonProperty("tbraccd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Tbraccd>? Tbraccd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("tbrdepo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Tbrdepo>? Tbrdepo { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("tbrcrcp2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Tbrcrcp2>? Tbrcrcp2 { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Tbraccd
    {
        /// <summary>
        /// Lineage reference object : TBRACCD_SRCE_CODE, Lookup lineage reference object : ttvsrce
        /// </summary>
        [Newtonsoft.Json.JsonProperty("srceCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SrceCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_CROSSREF_DETAIL_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crossrefDetailCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CrossrefDetailCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("additionalText", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AdditionalText { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("taxMethod", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TaxMethod { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_DOCUMENT_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("documentNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DocumentNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_DUE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dueDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DueDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_STATEMENT_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statementDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? StatementDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_UNITS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("units", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Units { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_BALANCE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("balance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Balance { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_CROSSREF_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crossrefNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CrossrefNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_MERCHANT_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchantId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MerchantId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_RATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Rate { get; set; } = default!;

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
        /// Lineage reference object : TBRACCD_INVOICE_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invoiceNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InvoiceNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_TRANS_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset TransDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_CROSSREF_DCAT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crossrefDcatCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CrossrefDcatCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_TRAN_NUMBER_PAID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tranNumberPaid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TranNumberPaid { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_ATYP_SEQNO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("atypSeqno", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double AtypSeqno { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_CRN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Crn { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_RECEIPT_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receiptNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ReceiptNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_AMOUNT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Amount { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_FEED_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("feedDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FeedDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_ENTRY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("entryDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EntryDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_CSHR_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cshrEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CshrEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_TRAN_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tranNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TranNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_BILL_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("billDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? BillDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_INV_NUMBER_PAID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invNumberPaid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InvNumberPaid { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("crossrefId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CrossrefId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_DETAIL_CODE, Lookup lineage reference object : tbbdetc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detailCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DetailCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_CROSSREF_SRCE_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crossrefSrceCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CrossrefSrceCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_CREATE_SOURCE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("createSource", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CreateSource { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_FEED_DOC_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("feedDocCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FeedDocCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_SESSION_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sessionNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SessionNumber { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("taxAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TaxAmount { get; set; } = default!;

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

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Tbrdepo
    {
        [Newtonsoft.Json.JsonProperty("relAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RelAmount { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_MIN_AMOUNT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MinAmount { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_AMOUNT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Amount { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_ENTRY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("entryDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EntryDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_RELEASE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("releaseDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ReleaseDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_DOCUMENT_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("documentNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DocumentNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_DETAIL_CODE_PAYMENT, Lookup lineage reference object : tbbdetc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detailCodePayment", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DetailCodePayment { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("depositBalance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DepositBalance { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_DETAIL_CODE_DEPOSIT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detailCodeDeposit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DetailCodeDeposit { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_CREATE_SOURCE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("createSource", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CreateSource { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_ACCT_FEED_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctFeedInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctFeedInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_ATYP_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("atypCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AtypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_ATYP_SEQNO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("atypSeqno", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double AtypSeqno { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_EFFECTIVE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effectiveDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset EffectiveDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_RECEIPT_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receiptNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ReceiptNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Desc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_EXPIRATION_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expirationDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ExpirationDate { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Tbrcrcp2
    {
        [Newtonsoft.Json.JsonProperty("dummy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Dummy { get; set; } = default!;

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