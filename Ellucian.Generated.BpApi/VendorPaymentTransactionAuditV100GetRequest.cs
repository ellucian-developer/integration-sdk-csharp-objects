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

namespace Ellucian.Generated.BpApi.Ban.VendorPaymentTransactionAuditV100GetRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class VendorPaymentTransactionAuditV100GetRequest
    {
        /// <summary>
        /// Lineage reference object : payTransId
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payTransId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? PayTransId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GORCCAU_VENDOR_AUTH_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vendorAuthCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendorAuthCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : referNo
        /// </summary>
        [Newtonsoft.Json.JsonProperty("referNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? ReferNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GORCCAU_FAILURE_URL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("failureUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FailureUrl { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GORCCAU_BANNER_STATUS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bannerStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BannerStatus { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GORCCAU_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GORCCAU_MERCHANT_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchantId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MerchantId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GORCCAU_SUB_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SubCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GORCCAU_SYSI_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sysiCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SysiCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : transDate
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? TransDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GORCCAU_VENDOR_STATUS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vendorStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendorStatus { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Id { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GORCCAU_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gorccauId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GorccauId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GORCCAU_AMOUNT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Amount { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GORCCAU_PROC_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("procCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProcCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GORCCAU_APPL_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ApplNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GORCCAU_SUCCESS_URL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("successUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SuccessUrl { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GORCCAU_GIFT_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("giftNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GiftNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GORCCAU_UPDATE_FUNCTION
        /// </summary>
        [Newtonsoft.Json.JsonProperty("updateFunction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UpdateFunction { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GORCCAU_PAY_TRANS_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gorcccauPayTransId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? GorcccauPayTransId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GORCCAU_LOCATION
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Location { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GORCCAU_APPLICATION_DATA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applicationData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ApplicationData { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GORCCAU_DETAIL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Detail { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GORCCAU_VENDOR_ERROR_MSG
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vendorErrorMsg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendorErrorMsg { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GORCCAU_VENDOR_REFER_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vendorReferNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendorReferNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GORCCAU_STATUS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Status { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GORCCAU_TERM_CODE
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


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603