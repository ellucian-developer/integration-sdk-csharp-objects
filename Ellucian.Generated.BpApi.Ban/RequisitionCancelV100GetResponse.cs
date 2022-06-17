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

namespace Ellucian.Generated.BpApi.Ban.RequisitionCancelV100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class RequisitionCancelV100GetResponse
    {
        /// <summary>
        /// Lineage reference object : FPBREQH_REQD_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fpbreqhReqdDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FpbreqhReqdDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayNetAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DisplayNetAmt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayAddlChrgAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DisplayAddlChrgAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBREQH_TRANS_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fpbreqhTransDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FpbreqhTransDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayVendName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayVendName { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayDocAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DisplayDocAmt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayTaxAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DisplayTaxAmt { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : ftvvend
        /// </summary>
        [Newtonsoft.Json.JsonProperty("displayVendCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayVendCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBREQH_RQST_TYPE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fpbreqhRqstTypeInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FpbreqhRqstTypeInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBREQH_ORIGIN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fpbreqhOriginCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FpbreqhOriginCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBREQH_REQH_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fpbreqhReqhDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FpbreqhReqhDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayDiscAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DisplayDiscAmt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayNsfOnOffInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayNsfOnOffInd { get; set; } = default!;

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