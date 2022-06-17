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

namespace Ellucian.Generated.BpApi.Ban.GradableComponentDefinitionV100PostRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GradableComponentDefinitionV100PostRequest
    {
        /// <summary>
        /// Lineage reference object : SHRGCOM_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRGCOM_COMP_LATE_RULE, Lookup lineage reference object : shbgrul
        /// </summary>
        [Newtonsoft.Json.JsonProperty("compLateRule", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CompLateRule { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRGCOM_COMP_RESIT_RULE, Lookup lineage reference object : shbgrul
        /// </summary>
        [Newtonsoft.Json.JsonProperty("compResitRule", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CompResitRule { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRGCOM_SEQ_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seqNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SeqNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRGCOM_PASS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("passInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PassInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRGCOM_ANDOR_SEQ_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("andorSeqNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AndorSeqNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_BEST_OF_COMP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bestOfComp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BestOfComp { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRGCOM_DESCRIPTION
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRGCOM_WEIGHT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("weight", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Weight { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRGCOM_ANONYMOUS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("anonymousInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AnonymousInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_SUBSET_OF_COMP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subsetOfComp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SubsetOfComp { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRGCOM_TOTAL_SCORE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("totalScore", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double TotalScore { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : componentSort
        /// </summary>
        [Newtonsoft.Json.JsonProperty("componentSort", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? ComponentSort { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_GSCH_NAME, Lookup lineage reference object : shbgsch,ssbsect,scbcrse,scbcrse
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gschName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GschName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRGCOM_SUBSET_OF_SUB
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subsetOfSub", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SubsetOfSub { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRGCOM_MIN_PASS_SCORE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minPassScore", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MinPassScore { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRGCOM_GRADE_SCALE, Lookup lineage reference object : shbgsch,ssbsect,scbcrse,scbcrse
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gradeScale", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GradeScale { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRGCOM_BEST_OF_SUB
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bestOfSub", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BestOfSub { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRGCOM_NAME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRGCOM_INCL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inclInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InclInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRGCOM_SUB_SET
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subSet", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SubSet { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : crn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Crn { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : termCode, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? TermCode { get; set; } = default!;

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