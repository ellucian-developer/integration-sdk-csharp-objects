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

namespace Ellucian.Generated.BpApi.Ban.CatalogPrerequisiteAndTestScoreRestrictions100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CatalogPrerequisiteAndTestScoreRestrictions100PutRequest
    {
        /// <summary>
        /// Lineage reference object : SCRPRTS_TESC_CODE, Lookup lineage reference object : stvtesc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tescCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TescCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SCRPARE_AREA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("area", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Area { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SCRCLPP_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SCRCLPP_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaUserId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SCRPRTS_CRSE_NUMB_PREQ, Lookup lineage reference object : scbcrse,scbcrky
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crseNumbPreq", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CrseNumbPreq { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SCRCLPP_CRSE_NUMB, Lookup lineage reference object : scbcrse,scbcrky
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.crseNumb", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCrseNumb { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SCRCLPP_SUBJ_CODE, Lookup lineage reference object : scbcrse,scbcrky
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subjCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SubjCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SCRPRTS_SUBJ_CODE_PREQ, Lookup lineage reference object : stvsubj
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subjCodePreq", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SubjCodePreq { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyBlckTermCode, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckTermCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblckTermCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SCRCLPP_SUBJ_CODE, Lookup lineage reference object : scbcrse,scbcrky
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.subjCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaSubjCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.inProgram", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaInProgram { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : program
        /// </summary>
        [Newtonsoft.Json.JsonProperty("program", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Program { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SCRPRTS_CONCURRENCY_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("concurrencyCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ConcurrencyCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SCRCLPP_PREREQ_CHK_METHOD_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prereqChkMethodCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PrereqChkMethodCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SCRPRTS_CONNECTOR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("connector", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Connector { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SCRPRTS_TEST_SCORE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("testScore", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TestScore { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SCRPRTS_RPAREN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rparen", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Rparen { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SCRPRTS_MIN_GRDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minGrde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MinGrde { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.subjDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaSubjDescription { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SCRCLPP_PREREQ_CHK_METHOD_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.prereqChkMethodCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaPrereqChkMethodCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SCRPRTS_LPAREN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lparen", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Lparen { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SCRPRTS_LEVL_CODE
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