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

namespace Ellucian.Generated.BpApi.Ban.AccountDetailDeposits100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AccountDetailDeposits100PutRequest
    {
        /// <summary>
        /// Lineage reference object : TBRDEPO_AMOUNT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.tbrdepoAmount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CriteriaTbrdepoAmount { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("relAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RelAmount { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_MIN_AMOUNT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MinAmount { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_DETAIL_CODE_PAYMENT, Lookup lineage reference object : tbbdetc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.tbrdepoDetailCodePayment", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaTbrdepoDetailCodePayment { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_RECEIPT_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.tbrdepoReceiptNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaTbrdepoReceiptNumber { get; set; } = default!;

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
        /// Lineage reference object : TBRDEPO_ATYP_SEQNO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.tbrdepoAtypSeqno", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CriteriaTbrdepoAtypSeqno { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.tbrdepoDesc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaTbrdepoDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_RELEASE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.tbrdepoReleaseDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaTbrdepoReleaseDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_DETAIL_CODE_DEPOSIT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.tbrdepoDetailCodeDeposit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaTbrdepoDetailCodeDeposit { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_DOCUMENT_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.tbrdepoDocumentNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaTbrdepoDocumentNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_EFFECTIVE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.tbrdepoEffectiveDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CriteriaTbrdepoEffectiveDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_ATYP_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.tbrdepoAtypCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaTbrdepoAtypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : receiptGenInd2
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receiptGenInd2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ReceiptGenInd2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : holdPassword
        /// </summary>
        [Newtonsoft.Json.JsonProperty("holdPassword", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HoldPassword { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_MIN_AMOUNT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.tbrdepoMinAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaTbrdepoMinAmount { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Id { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_EXPIRATION_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.tbrdepoExpirationDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaTbrdepoExpirationDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_CREATE_SOURCE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.tbrdepoCreateSource", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaTbrdepoCreateSource { get; set; } = default!;

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


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603