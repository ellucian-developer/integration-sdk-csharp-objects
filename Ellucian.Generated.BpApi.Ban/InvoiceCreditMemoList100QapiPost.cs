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

namespace Ellucian.Generated.BpApi.Ban.InvoiceCreditMemoList100QapiPost
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class InvoiceCreditMemoList100QapiPost
    {
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Status { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAVINVQ_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Code { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAVINVQ_POHD_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pohdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PohdCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAVINVQ_VEND_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vendId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAVINVQ_VENDOR_NAME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vendorName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendorName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAVINVQ_VEND_HOLD_RSN_CODE, Lookup lineage reference object : ftvhrsn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vendHoldRsnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendHoldRsnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAVINVQ_CR_MEMO_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crMemoInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CrMemoInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAVINVQ_COMPLETE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("completeInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CompleteInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAVINVQ_APPR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apprInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ApprInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAVINVQ_INVOICE_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invoiceAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? InvoiceAmt { get; set; } = default!;

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