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

namespace Ellucian.Generated.BpApi.Ban.AdmissionsApplicationCurriculaV100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AdmissionsApplicationCurriculaV100PutRequest
    {
        [Newtonsoft.Json.JsonProperty("criteria.stvadmtDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaStvadmtDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.termCodeEntryDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaTermCodeEntryDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.decMaintIndDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaDecMaintIndDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.stvsiteDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaStvsiteDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_APPL_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.applNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaApplNo { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.stvresdDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaStvresdDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.sarappdMaintInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaSarappdMaintInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.stvapstDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaStvapstDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.recruiterAppl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaRecruiterAppl { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_APST_CODE, Lookup lineage reference object : stvapst
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apstCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ApstCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_APST_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apstDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ApstDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.stvstypDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaStvstypDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.sarappdApdcDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaSarappdApdcDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_ADMT_CODE, Lookup lineage reference object : stvadmt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("admtCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AdmtCode { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvapdc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.sarappdApdcCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaSarappdApdcCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.reqDocInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaReqDocInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_RESD_CODE, Lookup lineage reference object : stvresd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.resdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaResdCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_SITE_CODE, Lookup lineage reference object : stvsite
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.siteCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaSiteCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_MAINT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.maintInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaMaintInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Id { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_FULL_PART_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.fullPartInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaFullPartInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_FULL_PART_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fullPartInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FullPartInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_SITE_CODE, Lookup lineage reference object : stvsite
        /// </summary>
        [Newtonsoft.Json.JsonProperty("siteCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SiteCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_ADMT_CODE, Lookup lineage reference object : stvadmt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.admtCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaAdmtCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.stvapdcDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaStvapdcDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : kbentryTermCode, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kbentryTermCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KbentryTermCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_APST_CODE, Lookup lineage reference object : stvapst
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.apstCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaApstCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_APST_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.apstDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaApstDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_STYP_CODE, Lookup lineage reference object : stvstyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.stypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaStypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_RESD_CODE, Lookup lineage reference object : stvresd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ResdCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_APPL_PREFERENCE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.applPreference", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaApplPreference { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_APPL_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.applDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaApplDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_APPL_PREFERENCE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applPreference", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ApplPreference { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_STYP_CODE, Lookup lineage reference object : stvstyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SARADAP_TERM_CODE_ENTRY, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.termCodeEntry", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaTermCodeEntry { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.statMaintIndDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaStatMaintIndDesc { get; set; } = default!;

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