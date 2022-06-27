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

namespace Ellucian.Generated.BpApi.Ban.HighSchoolInformationHighSchoolSubjectsV100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class HighSchoolInformationHighSchoolSubjectsV100PutRequest
    {
        /// <summary>
        /// Lineage reference object : SORHSCH_CLASS_SIZE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.classSize", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaClassSize { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORHSCH_ADMR_CODE, Lookup lineage reference object : stvadmr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.admrCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaAdmrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORHSCH_COLL_PREP_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.collPrepInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCollPrepInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORHSBJ_SUBJ_GPA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subjGpa", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SubjGpa { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORHSCH_GRADUATION_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.graduationDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaGraduationDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORHSCH_GPA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.gpa", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaGpa { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORHSCH_PERCENTILE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.percentile", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaPercentile { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORHSCH_TRANS_RECV_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.transRecvDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaTransRecvDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORHSBJ_SUBJ_YEARS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subjYears", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SubjYears { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORHSBJ_GRADE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.grade", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaGrade { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORHSBJ_SUBJ_GPA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.subjGpa", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaSubjGpa { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORHSCH_DPLM_CODE, Lookup lineage reference object : stvdplm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.dplmCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaDplmCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORHSBJ_GRADE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grade", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Grade { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORHSBJ_SBJC_CODE, Lookup lineage reference object : stvsbjc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.sbjcCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaSbjcCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORHSBJ_SBJC_CODE, Lookup lineage reference object : stvsbjc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sorhsbjSbjcCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SorhsbjSbjcCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Id { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORHSBJ_SUBJ_YEARS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.subjYears", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaSubjYears { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORHSCH_SBGI_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.sbgiCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaSbgiCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORHSCH_CLASS_RANK
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.classRank", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaClassRank { get; set; } = default!;

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