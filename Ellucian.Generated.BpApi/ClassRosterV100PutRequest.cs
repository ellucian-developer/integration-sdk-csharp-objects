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

namespace Ellucian.Generated.BpApi.Ban.ClassRosterV100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ClassRosterV100PutRequest
    {
        [Newtonsoft.Json.JsonProperty("criteria.spridenId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaSpridenId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ssbsectCrnt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssbsectCrnt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? SsbsectCrnt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ssbsectDegsAwrdInd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssbsectDegsAwrdInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? SsbsectDegsAwrdInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ssbsectTermCodet, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssbsectTermCodet", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? SsbsectTermCodet { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_REG_SEQ
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.regSeq", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaRegSeq { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.rolled", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaRolled { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_GRDE_CODE_MID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grdeCodeMid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GrdeCodeMid { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : rollIndicator
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rollIndicator", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? RollIndicator { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_RSTS_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.rstsDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaRstsDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_GRDE_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grdeCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GrdeCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_RSTS_CODE, Lookup lineage reference object : stvrsts
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.rstsCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaRstsCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_GRDE_CODE_INCMP_FINAL, Lookup lineage reference object : shrgrde,shrgrde
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grdeIncmpFinal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GrdeIncmpFinal { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_GRDE_CODE_MID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.grdeCodeMid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaGrdeCodeMid { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_GCMT_CODE, Lookup lineage reference object : stvgcmt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gcmtCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GcmtCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_CREDIT_HR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.creditHr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaCreditHr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_INCOMPLETE_EXT_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.incompleteExtDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaIncompleteExtDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_GRDE_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.grdeCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaGrdeCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.gcmtCodeDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaGcmtCodeDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.spridenCurrName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaSpridenCurrName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_GRDE_CODE_INCMP_FINAL, Lookup lineage reference object : shrgrde,shrgrde
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.grdeIncmpFinal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaGrdeIncmpFinal { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_GCMT_CODE, Lookup lineage reference object : stvgcmt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.gcmtCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaGcmtCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_GMOD_CODE, Lookup lineage reference object : stvgmod
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.gmodCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaGmodCode { get; set; } = default!;

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