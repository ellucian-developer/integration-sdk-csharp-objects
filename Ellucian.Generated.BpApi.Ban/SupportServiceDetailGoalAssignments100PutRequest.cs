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

namespace Ellucian.Generated.BpApi.Ban.SupportServiceDetailGoalAssignments100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SupportServiceDetailGoalAssignments100PutRequest
    {
        /// <summary>
        /// Lineage reference object : SERDTGL_ORIG_CODE, Lookup lineage reference object : stvorig
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.origCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaOrigCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : seadetlTermCodeEff, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCodeEff", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermCodeEff { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SERDTGL_GOAL_CODE, Lookup lineage reference object : stvgoal
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goalCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GoalCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SERDTGL_GOAL_CODE, Lookup lineage reference object : stvgoal
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.goalCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaGoalCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SERDTGL_ESTIMATE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.estimateDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaEstimateDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SERDTGL_ORIG_CODE, Lookup lineage reference object : stvorig
        /// </summary>
        [Newtonsoft.Json.JsonProperty("origCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrigCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SERDTGL_SSRS_CODE, Lookup lineage reference object : stvssrs
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.ssrsCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaSsrsCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SERDTGL_ACTUAL_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.actualDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaActualDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : seadetlSsgpCode, Lookup lineage reference object : stvssgp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssgpCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsgpCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SERDTGL_TREQ_CODE, Lookup lineage reference object : stvtreq
        /// </summary>
        [Newtonsoft.Json.JsonProperty("treqCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TreqCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SERDTGL_PRIORITY_NBR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.priorityNbr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaPriorityNbr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SERDTGL_TREQ_CODE, Lookup lineage reference object : stvtreq
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.treqCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaTreqCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SERDTGL_ACTUAL_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("actualDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActualDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SERDTGL_SSGP_CODE, Lookup lineage reference object : stvssgp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.ssgpCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaSsgpCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : seadetlId
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Id { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SERDTGL_SSGP_CODE, Lookup lineage reference object : stvssgp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("serdtglSsgpCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SerdtglSsgpCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SERDTGL_PRIORITY_NBR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("priorityNbr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PriorityNbr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SERDTGL_SSRS_CODE, Lookup lineage reference object : stvssrs
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssrsCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsrsCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SERDTGL_ESTIMATE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("estimateDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EstimateDate { get; set; } = default!;

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