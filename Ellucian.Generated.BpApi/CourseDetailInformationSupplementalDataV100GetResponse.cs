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

namespace Ellucian.Generated.BpApi.Ban.CourseDetailInformationSupplementalDataV100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CourseDetailInformationSupplementalDataV100GetResponse
    {
        [Newtonsoft.Json.JsonProperty("topsDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TopsDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SCBSUPP_CUDE_CODE, Lookup lineage reference object : stvcude
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cudeCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CudeCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("cuddDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CuddDescription { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("cudfDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CudfDescription { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SCBSUPP_TOPS_CODE, Lookup lineage reference object : stvtops
        /// </summary>
        [Newtonsoft.Json.JsonProperty("topsCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TopsCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("occsDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OccsDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ccslDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CcslDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SCBSUPP_PERM_DIST_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("permDistInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PermDistInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("cudbDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CudbDescription { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SCBSUPP_CCSL_CODE, Lookup lineage reference object : stvccsl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ccslCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CcslCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SCBSUPP_CUDB_CODE, Lookup lineage reference object : stvcudb
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cudbCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CudbCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SCBSUPP_CUDD_CODE, Lookup lineage reference object : stvcudd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cuddCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CuddCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SCBSUPP_CUDF_CODE, Lookup lineage reference object : STVCUDF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cudfCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CudfCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SCBSUPP_CREDIT_CATEGORY_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creditCategoryInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CreditCategoryInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("cudeDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CudeDescription { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SCBSUPP_COOP_ED_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coopEdInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CoopEdInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SCBSUPP_CUDA_CODE, Lookup lineage reference object : stvcuda
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cudaCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CudaCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("cudaDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CudaDescription { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SCBSUPP_CUDC_CODE, Lookup lineage reference object : stvcudc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cudcCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CudcCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("cudcDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CudcDescription { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SCBSUPP_OCCS_CODE, Lookup lineage reference object : stvoccs
        /// </summary>
        [Newtonsoft.Json.JsonProperty("occsCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OccsCode { get; set; } = default!;

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