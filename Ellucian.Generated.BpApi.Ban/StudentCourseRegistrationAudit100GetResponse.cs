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

namespace Ellucian.Generated.BpApi.Ban.StudentCourseRegistrationAudit100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class StudentCourseRegistrationAudit100GetResponse
    {
        [Newtonsoft.Json.JsonProperty("sfrstca", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Sfrstca>? Sfrstca { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("sfrrscm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Sfrrscm>? Sfrrscm { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Sfrstca
    {
        /// <summary>
        /// Lineage reference object : SFRSTCA_ATTEMPT_HR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attemptHr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AttemptHr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCA_GMOD_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmodCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GmodCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCA_STSP_KEY_SEQUENCE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stspKeySequence", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? StspKeySequence { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCA_BILL_HR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("billHr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BillHr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_CRSE_NUMB
        /// </summary>
        [Newtonsoft.Json.JsonProperty("courseNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CourseNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCA_CREDIT_HR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creditHr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CreditHr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_SEQ_NUMB
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sectionNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SectionNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCA_ERROR_FLAG
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errorFlag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ErrorFlag { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCA_SOURCE_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sourceCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SourceCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCA_MESSAGE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Message { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCA_ADD_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? AddDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCA_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCA_RSTS_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rstsCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RstsCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCA_CAMP_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("campCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CampCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCA_RSTS_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rstsDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? RstsDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCA_BLCK_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("blckCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BlckCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCA_SEQ_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seqNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SeqNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCA_USER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? User { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_SUBJ_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subjectCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SubjectCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCA_CRN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Crn { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCA_LEVL_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("levlCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LevlCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCA_TERM_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermCode { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Sfrrscm
    {
        /// <summary>
        /// Lineage reference object : SFRRSCM_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRSCM_REGISTRATION_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("registrationDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? RegistrationDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRSCM_ERROR_FLAG
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errorFlag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ErrorFlag { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRSCM_SESSIONID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sessionid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Sessionid { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRSCM_MESSAGE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Message { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRSCM_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRSCM_CRN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Crn { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRSCM_RMSG_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rmsgCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RmsgCde { get; set; } = default!;

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