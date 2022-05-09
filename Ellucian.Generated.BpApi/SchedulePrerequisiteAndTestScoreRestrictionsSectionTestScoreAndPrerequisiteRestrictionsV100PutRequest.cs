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

namespace Ellucian.Generated.BpApi.Ban.SchedulePrerequisiteAndTestScoreRestrictionsSectionTestScoreAndPrerequisiteRestrictionsV100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SchedulePrerequisiteAndTestScoreRestrictionsSectionTestScoreAndPrerequisiteRestrictionsV100PutRequest
    {
        /// <summary>
        /// Lineage reference object : SSRRTST_CONCURRENCY_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.concurrencyInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaConcurrencyInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRRTST_TESC_CODE, Lookup lineage reference object : stvtesc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tescCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TescCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRRARE_AREA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("area", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Area { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRRTST_LPAREN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.lparen", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaLparen { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.areaDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaAreaDescription { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRRTST_CRSE_NUMB_PREQ
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crseNumbPreq", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CrseNumbPreq { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRRARE_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRRTST_MIN_GRDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.minGrde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaMinGrde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRRTST_TEST_SCORE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.testScore", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaTestScore { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ssasectCrn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssasectCrn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? SsasectCrn { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRRTST_CONNECTOR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.connector", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaConnector { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRRTST_SUBJ_CODE_PREQ, Lookup lineage reference object : stvsubj
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subjCodePreq", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SubjCodePreq { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRRTST_LEVL_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.levlCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaLevlCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRRTST_RPAREN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.rparen", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaRparen { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRRTST_CONCURRENCY_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("concurrencyInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ConcurrencyInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRRTST_SUBJ_CODE_PREQ, Lookup lineage reference object : stvsubj
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.subjCodePreq", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaSubjCodePreq { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRRTST_TESC_CODE, Lookup lineage reference object : stvtesc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.tescCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaTescCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRRTST_CRSE_NUMB_PREQ
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.crseNumbPreq", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCrseNumbPreq { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ssasectTermCode, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssasectTermCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? SsasectTermCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRRARE_AREA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.area", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaArea { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRRTST_RPAREN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rparen", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Rparen { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRRTST_MIN_GRDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minGrde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MinGrde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRRTST_LPAREN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lparen", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Lparen { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRRTST_LEVL_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("levlCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LevlCode { get; set; } = default!;

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