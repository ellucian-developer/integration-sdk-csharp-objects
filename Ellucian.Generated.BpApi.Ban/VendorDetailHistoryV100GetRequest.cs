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

namespace Ellucian.Generated.BpApi.Ban.VendorDetailHistoryV100GetRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class VendorDetailHistoryV100GetRequest
    {
        /// <summary>
        /// Lineage reference object : FAVVIC2_PMT_DUE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("favvic2PmtDueDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Favvic2PmtDueDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : faavndhVendCode, Lookup lineage reference object : ftvvend
        /// </summary>
        [Newtonsoft.Json.JsonProperty("faavndhVendCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FaavndhVendCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : endDate
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAVVIC2_APPR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("favvic2ApprInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Favvic2ApprInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAVVIC2_INVH_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("favvic2InvhCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Favvic2InvhCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : faavndhVendName
        /// </summary>
        [Newtonsoft.Json.JsonProperty("faavndhVendName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FaavndhVendName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAVVIC2_VEND_INV_TOTAL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("favvic2VendInvTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Favvic2VendInvTotal { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : faavndhSelInd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("faavndhSelInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FaavndhSelInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAVVIC2_CANCEL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("favvic2CancelInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Favvic2CancelInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAVVIC2_VEND_INV_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("favvic2VendInvCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Favvic2VendInvCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAVVIC2_CHECK_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("favvic2CheckDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Favvic2CheckDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAVVIC2_PAY_TYPE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("favvic2PayType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Favvic2PayType { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAVVIC2_CHECK_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("favvic2CheckNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Favvic2CheckNum { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAVVIC2_CR_MEMO_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("favvic2CrMemoInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Favvic2CrMemoInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAVVIC2_OPEN_PAID_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("favvic2OpenPaidInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Favvic2OpenPaidInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAVVIC2_MULTIPLE_INV_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("favvic2MultipleInvInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Favvic2MultipleInvInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : displayFsyrCode, Lookup lineage reference object : ftvfspd,ftvfsyr,ftvfspd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("displayFsyrCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayFsyrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : startDate
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? StartDate { get; set; } = default!;

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