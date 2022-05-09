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

namespace Ellucian.Generated.BpApi.Ban.HighSchoolInformationHighSchoolDetailsV100PutResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class HighSchoolInformationHighSchoolDetailsV100PutResponse
    {
        /// <summary>
        /// Lineage reference object : SORHSCH_DPLM_CODE, Lookup lineage reference object : stvdplm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dplmCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DplmCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORHSCH_COLL_PREP_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("collPrepInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CollPrepInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("epsccode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Epsccode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORHSCH_SBGI_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sbgiCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SbgiCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORHSCH_CLASS_RANK
        /// </summary>
        [Newtonsoft.Json.JsonProperty("classRank", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ClassRank { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORHSCH_TRANS_RECV_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transRecvDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TransRecvDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORHSCH_ADMR_CODE, Lookup lineage reference object : stvadmr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("admrCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AdmrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORHSCH_CLASS_SIZE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("classSize", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ClassSize { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORHSCH_PERCENTILE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("percentile", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Percentile { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORHSCH_GRADUATION_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("graduationDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? GraduationDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvsbgiDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvsbgiDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORHSCH_GPA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gpa", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Gpa { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvadmrDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvadmrDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvdplmDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvdplmDesc { get; set; } = default!;

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