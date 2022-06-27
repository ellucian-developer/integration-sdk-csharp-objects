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

namespace Ellucian.Generated.BpApi.Ban.CourseMaintenanceV100PostRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CourseMaintenanceV100PostRequest
    {
        /// <summary>
        /// Lineage reference object : keyblckValidationCheck
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckValidationCheck", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblckValidationCheck { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRTCKN_CRSE_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crseTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CrseTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRTCKG_GCHG_CODE, Lookup lineage reference object : stvgchg
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gchgCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GchgCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRTCKN_SESS_CODE, Lookup lineage reference object : stvsess
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sessCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SessCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Id { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRTCKN_COURSE_COMMENT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("courseComment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CourseComment { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRTCKN_CRN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Crn { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRTCKN_PTRM_START_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptrmStartDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? PtrmStartDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRTCKN_STSP_KEY_SEQUENCE, Lookup lineage reference object : SGVSTSP,SGRSTSP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stspKeySequence", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? StspKeySequence { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRTCKN_CONT_HR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contHr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ContHr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRTCKG_GMOD_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmodCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GmodCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRTCKG_HOURS_ATTEMPTED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hoursAttempted", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? HoursAttempted { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRTCKN_SUBJ_CODE, Lookup lineage reference object : stvsubj
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subjCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SubjCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblckTermCode, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckTermCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblckTermCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRTCKG_CREDIT_HOURS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creditHours", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CreditHours { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRTCKN_CRSE_NUMB, Lookup lineage reference object : scbcrky
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crseNumb", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CrseNumb { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRTCKG_GRDE_CODE_INCMP_FINAL, Lookup lineage reference object : shrgrde,shrgrde
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grdeCodeIncmpFinal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GrdeCodeIncmpFinal { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRTCKL_PRIMARY_LEVL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("primaryLevlInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PrimaryLevlInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRTCKG_GCMT_CODE, Lookup lineage reference object : stvgcmt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gcmtCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GcmtCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRTCKG_INCOMPLETE_EXT_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("incompleteExtDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? IncompleteExtDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRTCKN_REPEAT_COURSE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("repeatCourseInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RepeatCourseInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRTCKN_LONG_COURSE_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("longCourseTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LongCourseTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRTCKN_PTRM_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptrmEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? PtrmEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRTCKN_DIVS_CODE, Lookup lineage reference object : stvdivs
        /// </summary>
        [Newtonsoft.Json.JsonProperty("divsCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DivsCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRTCKN_COLL_CODE, Lookup lineage reference object : stvcoll
        /// </summary>
        [Newtonsoft.Json.JsonProperty("collCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CollCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRTCKN_DEPT_CODE, Lookup lineage reference object : stvdept
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deptCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DeptCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRTCKL_LEVL_CODE, Lookup lineage reference object : stvlevl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("levlCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LevlCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHRTCKG_GRDE_CODE_FINAL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grdeCodeFinal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GrdeCodeFinal { get; set; } = default!;

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