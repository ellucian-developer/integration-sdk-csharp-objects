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

namespace Ellucian.Generated.BpApi.Ban.SupportServiceDetailServiceAssignmentV100QapiPost
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SupportServiceDetailServiceAssignmentV100QapiPost
    {
        [Newtonsoft.Json.JsonProperty("seadetlId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SeadetlId { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("seadetlTermCodeEff", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SeadetlTermCodeEff { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("seadetlSsgpCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SeadetlSsgpCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SERDTSR_SSER_CODE, Lookup lineage reference object : stvsser
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sserCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SserCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SERDTSR_SSGP_CODE, Lookup lineage reference object : stvssgp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssgpCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsgpCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SERDTSR_SSST_CODE, Lookup lineage reference object : stvssst
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssstCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsstCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SERDTSR_SEPR_CODE, Lookup lineage reference object : stvsepr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seprCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SeprCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SERDTSR_SPRV_CODE, Lookup lineage reference object : stvsprv
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sprvCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SprvCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SERDTSR_SSEP_CODE, Lookup lineage reference object : stvssep
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssepCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsepCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SERDTSR_BEGIN_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("beginDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? BeginDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SERDTSR_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SERDTSR_SSRS_CODE, Lookup lineage reference object : stvssrs
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssrsCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsrsCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SERDTSR_ORIG_CODE, Lookup lineage reference object : stvorig
        /// </summary>
        [Newtonsoft.Json.JsonProperty("origCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrigCode { get; set; } = default!;

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