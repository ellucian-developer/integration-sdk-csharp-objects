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

namespace Ellucian.Generated.BpApi.Ban.StudentCourseRegistrationCurriculaDuplicate100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class StudentCourseRegistrationCurriculaDuplicate100PutRequest
    {
        /// <summary>
        /// Lineage reference object : SOVLCUR_PROGRAM, Lookup lineage reference object : smrprle
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.program", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaProgram { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_EXP_GRAD_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.expGradDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaExpGradDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_LEAV_CODE, Lookup lineage reference object : stvleav
        /// </summary>
        [Newtonsoft.Json.JsonProperty("leavCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LeavCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_GAPP_SEQNO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.gappSeqno", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaGappSeqno { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaUserId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : printBill
        /// </summary>
        [Newtonsoft.Json.JsonProperty("printBill", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PrintBill { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.endDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_COLL_CODE, Lookup lineage reference object : stvcoll
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.collCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCollCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_LEVL_CODE, Lookup lineage reference object : stvlevl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.levlCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaLevlCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_PROGRAM, Lookup lineage reference object : smrprle
        /// </summary>
        [Newtonsoft.Json.JsonProperty("program", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Program { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_DEGC_CODE, Lookup lineage reference object : stvdegc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("degcCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DegcCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_START_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.startDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaStartDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : viewCurrent
        /// </summary>
        [Newtonsoft.Json.JsonProperty("viewCurrent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ViewCurrent { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : holdPassword
        /// </summary>
        [Newtonsoft.Json.JsonProperty("holdPassword", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HoldPassword { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_SITE_CODE, Lookup lineage reference object : stvsite
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.siteCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaSiteCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_TERM_CODE_ADMIT, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.termCodeAdmit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaTermCodeAdmit { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Id { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_TERM_CODE_CTLG, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.termCodeCtlg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaTermCodeCtlg { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_PRIORITY_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.priorityNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaPriorityNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_RATE_CODE, Lookup lineage reference object : stvrate
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.rateCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaRateCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_CACT_CODE, Lookup lineage reference object : stvcact,sobcact
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cactCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CactCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_APPL_KEY_SEQNO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.sovlcurApplKeySeqno", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaSovlcurApplKeySeqno { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_DEGC_CODE, Lookup lineage reference object : stvdegc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.degcCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaDegcCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_LEAV_FROM_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("leavFromDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? LeavFromDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_CACT_CODE, Lookup lineage reference object : stvcact,sobcact
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.cactCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCactCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_ROLL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rollInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RollInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_APPL_KEY_SEQNO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sovlcurApplKeySeqno", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SovlcurApplKeySeqno { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_COLL_CODE, Lookup lineage reference object : stvcoll
        /// </summary>
        [Newtonsoft.Json.JsonProperty("collCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CollCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_LMOD_CODE, Lookup lineage reference object : stvlmod
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.lmodCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaLmodCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_LEVL_CODE, Lookup lineage reference object : stvlevl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("levlCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LevlCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_START_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? StartDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_CAMP_CODE, Lookup lineage reference object : stvcamp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.campCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCampCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_TERM_CODE_MATRIC, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCodeMatric", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermCodeMatric { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_TERM_CODE, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.termCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaTermCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_TERM_CODE_END, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.termCodeEnd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaTermCodeEnd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_RATE_CODE, Lookup lineage reference object : stvrate
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rateCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RateCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_TERM_CODE_GRAD, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCodeGrad", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermCodeGrad { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_ADMT_CODE, Lookup lineage reference object : stvadmt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("admtCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AdmtCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_PRIORITY_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("priorityNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PriorityNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_LEAV_TO_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("leavToDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? LeavToDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : term, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("term", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Term { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_LEAV_FROM_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.leavFromDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaLeavFromDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_TERM_CODE_MATRIC, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.termCodeMatric", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaTermCodeMatric { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_LEAV_TO_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.leavToDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaLeavToDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_EXP_GRAD_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expGradDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ExpGradDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_TERM_CODE_CTLG, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCodeCtlg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermCodeCtlg { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_SITE_CODE, Lookup lineage reference object : stvsite
        /// </summary>
        [Newtonsoft.Json.JsonProperty("siteCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SiteCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_ADMT_CODE, Lookup lineage reference object : stvadmt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.admtCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaAdmtCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_STYP_CODE, Lookup lineage reference object : stvstyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.stypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaStypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : printSchedule
        /// </summary>
        [Newtonsoft.Json.JsonProperty("printSchedule", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PrintSchedule { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_CURRENT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.sovlcurCurrentInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaSovlcurCurrentInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyStudypath, Lookup lineage reference object : sovlcur,stvastd,stvcast,sgvstsp,sgrstsp,stvastd,stvcast,sgvstsp,sgrstsp,sovlcur
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyStudypath", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? KeyStudypath { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_ACYR_CODE, Lookup lineage reference object : stvacyr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.acyrCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaAcyrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_ACYR_CODE, Lookup lineage reference object : stvacyr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acyrCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcyrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_TERM_CODE_ADMIT, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCodeAdmit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermCodeAdmit { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : rstsEstsDate
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rstsEstsDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? RstsEstsDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_KEY_SEQNO, Lookup lineage reference object : sgvstsp,sgrstsp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.keySeqno", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaKeySeqno { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_TERM_CODE_GRAD, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.termCodeGrad", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaTermCodeGrad { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_LEAV_CODE, Lookup lineage reference object : stvleav
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.leavCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaLeavCode { get; set; } = default!;

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