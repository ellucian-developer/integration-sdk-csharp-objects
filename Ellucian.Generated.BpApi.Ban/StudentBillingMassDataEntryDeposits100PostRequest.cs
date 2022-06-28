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

namespace Ellucian.Generated.BpApi.Ban.StudentBillingMassDataEntryDeposits100PostRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class StudentBillingMassDataEntryDeposits100PostRequest
    {
        /// <summary>
        /// Lineage reference object : keybloc2DetailCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keybloc2DetailCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Keybloc2DetailCode { get; set; } = default!;

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
        /// Lineage reference object : keybloc2ExpirationDate
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keybloc2ExpirationDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Keybloc2ExpirationDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keybloc2MinAmount
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keybloc2MinAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Keybloc2MinAmount { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keybloc2TermCode, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keybloc2TermCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Keybloc2TermCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keybloc2DocumentNumber
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keybloc2DocumentNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Keybloc2DocumentNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_DETAIL_CODE_PAYMENT, Lookup lineage reference object : tbbdetc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detailCodePayment", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DetailCodePayment { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("receiptInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReceiptInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_DETAIL_CODE_DEPOSIT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detailCodeDeposit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DetailCodeDeposit { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_AUTO_RELEASE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("autoReleaseInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AutoReleaseInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keybloc2Amount
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keybloc2Amount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Keybloc2Amount { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keybloc2AutoReleaseInd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keybloc2AutoReleaseInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Keybloc2AutoReleaseInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keybloc2DetailCodePay, Lookup lineage reference object : tbbdetc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keybloc2DetailCodePay", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Keybloc2DetailCodePay { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keybloc2ReleaseDate
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keybloc2ReleaseDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Keybloc2ReleaseDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keybloc2EffDate
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keybloc2EffDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Keybloc2EffDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Id { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Desc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRDEPO_TERM_CODE, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TermCode { get; set; } = default!;

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