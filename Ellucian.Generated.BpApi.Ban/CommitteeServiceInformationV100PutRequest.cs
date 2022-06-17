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

namespace Ellucian.Generated.BpApi.Ban.CommitteeServiceInformationV100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CommitteeServiceInformationV100PutRequest
    {
        /// <summary>
        /// Lineage reference object : SHBCOMI_INITIATED_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("initiatedDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset InitiatedDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHBCOMI_COMS_CODE, Lookup lineage reference object : stvcoms
        /// </summary>
        [Newtonsoft.Json.JsonProperty("comsCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComsCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHBCOMI_DISSOLVED_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dissolvedInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DissolvedInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHBCOMI_TRANS_PRINT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.transPrint", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaTransPrint { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHBCOMI_DICD_CODE, Lookup lineage reference object : gtvdicd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dicdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DicdCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHBCOMI_DISSOLVED_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.dissolvedDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaDissolvedDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHBCOMI_COLL_CODE, Lookup lineage reference object : stvcoll
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.collCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCollCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHBCOMI_DEPT_CODE, Lookup lineage reference object : stvdept
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.deptCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaDeptCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHBCOMI_DISSOLVED_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dissolvedDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DissolvedDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHBCOMI_INITIATED_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.initiatedDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CriteriaInitiatedDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHBCOMI_DICD_CODE, Lookup lineage reference object : gtvdicd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.dicdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaDicdCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHBCOMI_COMS_CODE, Lookup lineage reference object : stvcoms
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.comsCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaComsCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHBCOMI_DISSOLVED_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.dissolvedInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaDissolvedInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Id { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : shacomiComtCode, Lookup lineage reference object : stvcomt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shacomiComtCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object ShacomiComtCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHBCOMI_COLL_CODE, Lookup lineage reference object : stvcoll
        /// </summary>
        [Newtonsoft.Json.JsonProperty("collCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CollCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHBCOMI_DEPT_CODE, Lookup lineage reference object : stvdept
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deptCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DeptCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHBCOMI_TRANS_PRINT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transPrint", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TransPrint { get; set; } = default!;

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