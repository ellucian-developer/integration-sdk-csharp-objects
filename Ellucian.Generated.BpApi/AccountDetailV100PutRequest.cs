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

namespace Ellucian.Generated.BpApi.Ban.AccountDetailV100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AccountDetailV100PutRequest
    {
        /// <summary>
        /// Lineage reference object : TBRACCD_DETAIL_CODE, Lookup lineage reference object : tbbdetc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.detailCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaDetailCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_ATYP_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.atypCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaAtypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_AMOUNT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CriteriaAmount { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_CROSSREF_DETAIL_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.crossrefDetailCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCrossrefDetailCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.crossrefId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCrossrefId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_DOCUMENT_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("documentNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DocumentNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.desc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_TRAN_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.tranNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaTranNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : holdPassword
        /// </summary>
        [Newtonsoft.Json.JsonProperty("holdPassword", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? HoldPassword { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_PAYMENT_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("paymentId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PaymentId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_SRCE_CODE, Lookup lineage reference object : ttvsrce
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.srceCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaSrceCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_TRAN_NUMBER_PAID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.tranNumberPaid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaTranNumberPaid { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_DUE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.dueDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaDueDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_ACCT_FEED_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.acctFeedInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaAcctFeedInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Id { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : gtvcurr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.currCodeV", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaCurrCodeV { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_TRAN_NUMBER_PAID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tranNumberPaid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TranNumberPaid { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_CROSSREF_SRCE_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.crossrefSrceCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCrossrefSrceCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_TRANS_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.transDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CriteriaTransDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.taxAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaTaxAmount { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_ATYP_SEQNO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.atypSeqno", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CriteriaAtypSeqno { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_DOCUMENT_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.documentNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaDocumentNumber { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.additionalText", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaAdditionalText { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_USER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.user", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaUser { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_CROSSREF_SRCE_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crossrefSrceCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CrossrefSrceCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_ENTRY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.entryDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaEntryDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_CSHR_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.cshrEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaCshrEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_RECEIPT_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.receiptNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaReceiptNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Desc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_PAYMENT_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.paymentId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaPaymentId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_SESSION_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.sessionNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaSessionNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_STATEMENT_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.statementDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaStatementDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.taxMethod", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaTaxMethod { get; set; } = default!;

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
        /// Lineage reference object : TBRACCD_BILL_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.billDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaBillDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_RATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.rate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaRate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_MERCHANT_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.merchantId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaMerchantId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_ATYP_SEQNO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("atypSeqno", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double AtypSeqno { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_EFFECTIVE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.effectiveDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CriteriaEffectiveDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_CREATE_SOURCE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.createSource", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCreateSource { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_BALANCE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.balance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaBalance { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_UNITS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.units", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaUnits { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_CROSSREF_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.crossrefNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaCrossrefNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_INV_NUMBER_PAID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invNumberPaid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InvNumberPaid { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_INV_NUMBER_PAID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.invNumberPaid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaInvNumberPaid { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_DETAIL_CODE, Lookup lineage reference object : tbbdetc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detailCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DetailCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_CROSSREF_DCAT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.crossrefDcatCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCrossrefDcatCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_CRN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.crn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCrn { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_FEED_DOC_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.feedDocCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaFeedDocCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_INVOICE_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.invoiceNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaInvoiceNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRACCD_FEED_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.feedDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaFeedDate { get; set; } = default!;

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