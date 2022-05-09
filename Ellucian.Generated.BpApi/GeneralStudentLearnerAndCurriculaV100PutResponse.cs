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

namespace Ellucian.Generated.BpApi.Ban.GeneralStudentLearnerAndCurriculaV100PutResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GeneralStudentLearnerAndCurriculaV100PutResponse
    {
        [Newtonsoft.Json.JsonProperty("gainDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GainDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_LEAV_CODE, Lookup lineage reference object : stvleav
        /// </summary>
        [Newtonsoft.Json.JsonProperty("leavCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LeavCode { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvastd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shrttrmAstdCodeEndOfTerm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ShrttrmAstdCodeEndOfTerm { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvcast
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shrttrmCastCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ShrttrmCastCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_INCM_CODE, Lookup lineage reference object : stvincm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("incmCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IncmCode { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvclas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shrttrmClasCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ShrttrmClasCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("termEffBegin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermEffBegin { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvprev
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shrttrmPrevCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ShrttrmPrevCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_SESS_CODE, Lookup lineage reference object : stvsess
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sessCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SessCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvdegcDescDual", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvdegcDescDual { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_PRAC_CODE, Lookup lineage reference object : stvprac
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pracCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PracCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("incmDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IncmDescription { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_EMEX_CODE, Lookup lineage reference object : stvemex
        /// </summary>
        [Newtonsoft.Json.JsonProperty("emexCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EmexCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_TERM_CODE_ASTD, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCodeAstd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermCodeAstd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("aprnDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AprnDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_ORSN_CODE, Lookup lineage reference object : stvorsn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orsnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrsnCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvlevlDescDual", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvlevlDescDual { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvststDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvststDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvresdDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvresdDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("shrttrmPrevDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ShrttrmPrevDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvastdDescHistory", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvastdDescHistory { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvsessDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvsessDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("edlvDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EdlvDescription { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_LEAV_FROM_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("leavFromDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? LeavFromDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_RESD_CODE, Lookup lineage reference object : stvresd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ResdCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("blckDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BlckDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvastdDescOverride", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvastdDescOverride { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_SCPC_CODE, Lookup lineage reference object : stvscpc,sobscps,sorscpt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scpcCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ScpcCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_STST_CODE, Lookup lineage reference object : stvstst
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ststCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StstCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_GRAD_CREDIT_APPR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gradCreditApprInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GradCreditApprInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_BSKL_CODE, Lookup lineage reference object : stvbskl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bsklCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BsklCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_DEPT_CODE_DUAL, Lookup lineage reference object : stvdept
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deptCodeDual", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DeptCodeDual { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("trcnDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TrcnDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvpracDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvpracDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_GAIN_CODE, Lookup lineage reference object : stvgain
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gainCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GainCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_VOED_CODE, Lookup lineage reference object : stvvoed
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voedCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VoedCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_MAJR_CODE_DUAL, Lookup lineage reference object : stvmajr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("majrCodeDual", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MajrCodeDual { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_PREV_CODE, Lookup lineage reference object : stvprev
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prevCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PrevCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("egolDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EgolDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("termEffDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermEffDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_EDLV_CODE, Lookup lineage reference object : stvedlv
        /// </summary>
        [Newtonsoft.Json.JsonProperty("edlvCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EdlvCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvmajrDescDual", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvmajrDescDual { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvorsnDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvorsnDesc { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shrttrmTermCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ShrttrmTermCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvcollDescDual", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvcollDescDual { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_RATE_CODE, Lookup lineage reference object : stvrate
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rateCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RateCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_TERM_CODE_GRAD, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCodeGrad", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermCodeGrad { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvcaplDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvcaplDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("voedDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VoedDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvstypDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvstypDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_LEAV_TO_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("leavToDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? LeavToDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvscpcDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvscpcDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_TRCN_CODE, Lookup lineage reference object : stvtrcn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trcnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TrcnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_COLL_CODE_DUAL, Lookup lineage reference object : stvcoll
        /// </summary>
        [Newtonsoft.Json.JsonProperty("collCodeDual", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CollCodeDual { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_CAST_CODE, Lookup lineage reference object : stvcast
        /// </summary>
        [Newtonsoft.Json.JsonProperty("castCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CastCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvleavDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvleavDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("termEffEnd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermEffEnd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_FULL_PART_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fullPartInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FullPartInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_EXP_GRAD_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expGradDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ExpGradDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("castDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CastDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_TERM_CODE_PREV, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCodePrev", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermCodePrev { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_SITE_CODE, Lookup lineage reference object : stvsite
        /// </summary>
        [Newtonsoft.Json.JsonProperty("siteCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SiteCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_TERM_CODE_EFF, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCodeEff", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermCodeEff { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_LEVL_CODE_DUAL, Lookup lineage reference object : stvlevl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("levlCodeDual", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LevlCodeDual { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_CAPL_CODE, Lookup lineage reference object : stvcapl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("caplCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CaplCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("prevDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PrevDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvdeptDescDual", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvdeptDescDual { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("bsklDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BsklDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvsiteDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvsiteDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("shrttrmCastDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ShrttrmCastDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_ACYR_CODE, Lookup lineage reference object : stvacyr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acyrCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcyrCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvrateDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvrateDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_BLCK_CODE, Lookup lineage reference object : stvblck
        /// </summary>
        [Newtonsoft.Json.JsonProperty("blckCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BlckCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_EGOL_CODE, Lookup lineage reference object : stvegol
        /// </summary>
        [Newtonsoft.Json.JsonProperty("egolCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EgolCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_APRN_CODE, Lookup lineage reference object : stvaprn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aprnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AprnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_STYP_CODE, Lookup lineage reference object : stvstyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_ASTD_CODE, Lookup lineage reference object : stvastd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("astdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AstdCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("emexDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EmexDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvclasDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvclasDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_DEGC_CODE_DUAL, Lookup lineage reference object : stvdegc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("degcCodeDual", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DegcCodeDual { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_TERM_CODE_CAST, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCodeCast", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermCodeCast { get; set; } = default!;

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