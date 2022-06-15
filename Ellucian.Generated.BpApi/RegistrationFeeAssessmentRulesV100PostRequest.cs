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

namespace Ellucian.Generated.BpApi.Ban.RegistrationFeeAssessmentRulesV100PostRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class RegistrationFeeAssessmentRulesV100PostRequest
    {
        /// <summary>
        /// Lineage reference object : SFRRGFE_VTYP_CODE, Lookup lineage reference object : stvvtyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vtypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VtypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_STYP_CODE_CURRIC, Lookup lineage reference object : stvstyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stypCodeCurric", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StypCodeCurric { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : entryType
        /// </summary>
        [Newtonsoft.Json.JsonProperty("blockKeyEntryType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? BlockKeyEntryType { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_PRIM_SEC_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("primSecCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PrimSecCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_TO_FLAT_HRS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("toFlatHrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ToFlatHrs { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_TO_STUD_HRS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("toStudHrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ToStudHrs { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_DETL_CODE, Lookup lineage reference object : tbbdetc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detlCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DetlCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_CAMP_CODE_CRSE, Lookup lineage reference object : stvcamp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("campCodeCrse", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CampCodeCrse { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_FROM_FLAT_HRS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fromFlatHrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FromFlatHrs { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_DEGC_CODE, Lookup lineage reference object : stvdegc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("degcCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DegcCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_PROGRAM, Lookup lineage reference object : smrprle
        /// </summary>
        [Newtonsoft.Json.JsonProperty("program", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Program { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_MAJR_CODE, Lookup lineage reference object : stvmajr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("majrCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MajrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_MIN_CHARGE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minCharge", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double MinCharge { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_RATE_CODE, Lookup lineage reference object : stvrate
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rateCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RateCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_SCHD_CODE, Lookup lineage reference object : stvschd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SchdCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_LFST_CODE, Lookup lineage reference object : gtvlfst
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lfstCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LfstCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_FLAT_FEE_AMOUNT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("flatFeeAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FlatFeeAmount { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_CHRT_CODE, Lookup lineage reference object : stvchrt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chrtCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ChrtCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_RATE_CODE_CURRIC, Lookup lineage reference object : stvrate
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rateCodeCurric", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RateCodeCurric { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_CAMP_CODE, Lookup lineage reference object : stvcamp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("campCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CampCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_FROM_CRED_HRS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fromCredHrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FromCredHrs { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ruleType
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ruleType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? RuleType { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_CLAS_CODE, Lookup lineage reference object : stvclas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("clasCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ClasCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_FROM_STUD_HRS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fromStudHrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FromStudHrs { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_CRSE_WAIV_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crseWaivInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CrseWaivInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_ENTRY_TYPE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("entryType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EntryType { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_GMOD_CODE, Lookup lineage reference object : stvgmod
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmodCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GmodCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_SEQNO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seqno", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Seqno { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_MAX_CHARGE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maxCharge", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double MaxCharge { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_RESD_CODE, Lookup lineage reference object : stvresd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ResdCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_INSM_CODE, Lookup lineage reference object : gtvinsm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("insmCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InsmCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_PER_CRED_CHARGE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("perCredCharge", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double PerCredCharge { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_TO_ADD_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("toAddDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ToAddDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_TO_CRED_HRS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("toCredHrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ToCredHrs { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : setCopyIndEnMassInd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("setCopyIndEnMassInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? SetCopyIndEnMassInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_ASSESS_BY_COURSE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("assessByCourseInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AssessByCourseInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_PTRM_CODE, Lookup lineage reference object : stvptrm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptrmCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PtrmCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_ATTS_CODE, Lookup lineage reference object : stvatts
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attsCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AttsCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_TERM_CODE_ADMIT, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCodeAdmit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermCodeAdmit { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_LFST_PRIM_SEC_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lfstPrimSecCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LfstPrimSecCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_STYP_CODE, Lookup lineage reference object : stvstyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_COLL_CODE, Lookup lineage reference object : stvcoll
        /// </summary>
        [Newtonsoft.Json.JsonProperty("collCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CollCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_LEVL_CODE, Lookup lineage reference object : stvlevl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("levlCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LevlCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_DEPT_CODE, Lookup lineage reference object : stvdept
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deptCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DeptCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_FROM_ADD_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fromAddDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FromAddDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : termCode, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? TermCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_COPY_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("copyInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CopyInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRRGFE_CRSE_OVERLOAD_START_HR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crseOverloadStartHr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CrseOverloadStartHr { get; set; } = default!;

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