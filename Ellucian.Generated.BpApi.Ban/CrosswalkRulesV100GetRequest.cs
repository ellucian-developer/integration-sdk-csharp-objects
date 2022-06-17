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

namespace Ellucian.Generated.BpApi.Ban.CrosswalkRulesV100GetRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CrosswalkRulesV100GetRequest
    {
        /// <summary>
        /// Lineage reference object : GTVSDAX_TRANSLATION_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("translationCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TranslationCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GTVSDAX_COMMENTS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("comments", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Comments { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GTVSDAX_EXTERNAL_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("externalCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExternalCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GTVSDAX_CONCEPT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("concept", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Concept { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GTVSDAX_SYSREQ_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sysreqInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SysreqInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GTVSDAX_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GTVSDAX_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GTVSDAX_SYSI_CODE, Lookup lineage reference object : gtvsysi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sysiCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SysiCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GTVSDAX_INTERNAL_CODE_SEQNO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("internalCodeSeqno", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? InternalCodeSeqno { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GTVSDAX_REPORTING_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reportingDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ReportingDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GTVSDAX_INTERNAL_CODE_GROUP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("internalCodeGroup", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InternalCodeGroup { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GTVSDAX_INTERNAL_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("internalCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InternalCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GTVSDAX_DESC
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


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603