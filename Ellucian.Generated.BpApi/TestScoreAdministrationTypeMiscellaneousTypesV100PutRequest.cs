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

namespace Ellucian.Generated.BpApi.Ban.TestScoreAdministrationTypeMiscellaneousTypesV100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TestScoreAdministrationTypeMiscellaneousTypesV100PutRequest
    {
        /// <summary>
        /// Lineage reference object : SGBSTDN_LEAV_FROM_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sgbstdnLeavFromDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? SgbstdnLeavFromDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_GAIN_CODE, Lookup lineage reference object : stvgain
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sgbstdnGainCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SgbstdnGainCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_BSKL_CODE, Lookup lineage reference object : stvbskl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sgbstdnBsklCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SgbstdnBsklCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_EDLV_CODE, Lookup lineage reference object : stvedlv
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sgbstdnEdlvCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SgbstdnEdlvCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_EMEX_CODE, Lookup lineage reference object : stvemex
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sgbstdnEmexCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SgbstdnEmexCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_APRN_CODE, Lookup lineage reference object : stvaprn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sgbstdnAprnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SgbstdnAprnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_LEAV_TO_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sgbstdnLeavToDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? SgbstdnLeavToDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_TRCN_CODE, Lookup lineage reference object : stvtrcn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sgbstdnTrcnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SgbstdnTrcnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_ORSN_CODE, Lookup lineage reference object : stvorsn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sgbstdnOrsnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SgbstdnOrsnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_EGOL_CODE, Lookup lineage reference object : stvegol
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sgbstdnEgolCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SgbstdnEgolCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_VOED_CODE, Lookup lineage reference object : stvvoed
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sgbstdnVoedCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SgbstdnVoedCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_PRAC_CODE, Lookup lineage reference object : stvprac
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sgbstdnPracCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SgbstdnPracCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_CAPL_CODE, Lookup lineage reference object : stvcapl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sgbstdnCaplCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SgbstdnCaplCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_GRAD_CREDIT_APPR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sgbstdnGradCreditApprInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SgbstdnGradCreditApprInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Id { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_INCM_CODE, Lookup lineage reference object : stvincm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sgbstdnIncmCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SgbstdnIncmCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_LEAV_CODE, Lookup lineage reference object : stvleav
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sgbstdnLeavCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SgbstdnLeavCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : stvtermTermCode, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stvtermTermCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? StvtermTermCode { get; set; } = default!;

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