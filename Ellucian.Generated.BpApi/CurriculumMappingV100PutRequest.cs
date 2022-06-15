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

namespace Ellucian.Generated.BpApi.Ban.CurriculumMappingV100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CurriculumMappingV100PutRequest
    {
        /// <summary>
        /// Lineage reference object : SKRPOFR_PROGRAM, Lookup lineage reference object : SOBCURR,SORMCRL,SORMCRL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.program", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaProgram { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_EXP_ACCEPT_PERCENTAGE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expAcceptPercentage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExpAcceptPercentage { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaUserId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_ADMIT_COURSE_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.admitCourseCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaAdmitCourseCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_SBGI_CODE, Lookup lineage reference object : stvsbgi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sbgiCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SbgiCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_PROGRAM, Lookup lineage reference object : SOBCURR,SORMCRL,SORMCRL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("program", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Program { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_ENROLLED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.enrolled", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaEnrolled { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_MAJR_CODE, Lookup lineage reference object : STVMAJR,JOIN,X,SORCMJR_MAJR_CODE,STVMAJR_CODE,SORCMJR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("majrCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MajrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_CRS_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.crsCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCrsCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_QUOTA_LOAD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.quotaLoad", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaQuotaLoad { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_SESS_CODE, Lookup lineage reference object : stvsess
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sessCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SessCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : academicYear, Lookup lineage reference object : STVACYR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("academicYear", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? AcademicYear { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_ADMIT_COURSE_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("admitCourseCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdmitCourseCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_CAMP_CODE, Lookup lineage reference object : stvcamp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("campCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CampCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_EXPIRY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.expiryDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaExpiryDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_RATE_CODE, Lookup lineage reference object : stvrate
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.rateCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaRateCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_OFFERS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Offers { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_QUOTA_LOAD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quotaLoad", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? QuotaLoad { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_ACTIVE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.activeInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaActiveInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_PTRM_CODE, Lookup lineage reference object : STVPTRM,SOBPTRM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.ptrmCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaPtrmCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_CHRT_CODE, Lookup lineage reference object : stvchrt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.chrtCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaChrtCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_RESD_CODE, Lookup lineage reference object : stvresd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ResdCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_ENFORCE_LAPSE_DATE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.enforceLapseDateInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaEnforceLapseDateInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_PTRM_CODE, Lookup lineage reference object : STVPTRM,SOBPTRM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptrmCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PtrmCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_ENFORCE_LAPSE_DATE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enforceLapseDateInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EnforceLapseDateInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_CAMP_CODE, Lookup lineage reference object : stvcamp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.campCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCampCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_OFFERS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.offers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaOffers { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_ADMIT_CATEGORY_CODE, Lookup lineage reference object : SKRRVAL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.admitCategoryCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaAdmitCategoryCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_ADMIT_CATEGORY_CODE, Lookup lineage reference object : SKRRVAL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("admitCategoryCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdmitCategoryCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_TERM_CODE, Lookup lineage reference object : STVTERM,SOBTERM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.termCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaTermCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_QUOTA_COUNT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.quotaCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaQuotaCount { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_RATE_CODE, Lookup lineage reference object : stvrate
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rateCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RateCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_EXPIRY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expiryDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ExpiryDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_CHRT_CODE, Lookup lineage reference object : stvchrt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chrtCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ChrtCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_CRICOS_CODE, Lookup lineage reference object : SKRCRIC,SKRCRIC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.cricosCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCricosCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_ACTIVE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activeInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ActiveInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_RESD_CODE, Lookup lineage reference object : stvresd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.resdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaResdCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_CRICOS_CODE, Lookup lineage reference object : SKRCRIC,SKRCRIC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cricosCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CricosCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_MAJR_CODE, Lookup lineage reference object : STVMAJR,JOIN,X,SORCMJR_MAJR_CODE,STVMAJR_CODE,SORCMJR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.majrCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaMajrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_ENROLLED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enrolled", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Enrolled { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_FULL_PART_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.fullPartInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaFullPartInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_FULL_PART_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fullPartInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FullPartInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_SESS_CODE, Lookup lineage reference object : stvsess
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.sessCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaSessCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_QUOTA_COUNT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quotaCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? QuotaCount { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_STYP_CODE, Lookup lineage reference object : stvstyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.stypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaStypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_NATIONAL_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.nationalId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaNationalId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_NATIONAL_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nationalId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NationalId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_CRS_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crsCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CrsCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_EXP_ACCEPT_PERCENTAGE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.expAcceptPercentage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaExpAcceptPercentage { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_STYP_CODE, Lookup lineage reference object : stvstyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_SBGI_CODE, Lookup lineage reference object : stvsbgi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.sbgiCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaSbgiCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SKRPOFR_TERM_CODE, Lookup lineage reference object : STVTERM,SOBTERM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TermCode { get; set; } = default!;

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