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

namespace Ellucian.Generated.BpApi.Ban.GeneralStudentMiscellaneousTypes100QapiPost
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GeneralStudentMiscellaneousTypes100QapiPost
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Id { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvtermTermCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvtermTermCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_TERM_CODE_EFF, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCodeEff", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermCodeEff { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_RESD_CODE, Lookup lineage reference object : stvresd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ResdCode { get; set; } = default!;

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
        /// Lineage reference object : SGBSTDN_RATE_CODE, Lookup lineage reference object : stvrate
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rateCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RateCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_FULL_PART_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fullPartInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FullPartInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_STYP_CODE, Lookup lineage reference object : stvstyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_SITE_CODE, Lookup lineage reference object : stvsite
        /// </summary>
        [Newtonsoft.Json.JsonProperty("siteCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SiteCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_BLCK_CODE, Lookup lineage reference object : stvblck
        /// </summary>
        [Newtonsoft.Json.JsonProperty("blckCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BlckCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_SESS_CODE, Lookup lineage reference object : stvsess
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sessCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SessCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_ORSN_CODE, Lookup lineage reference object : stvorsn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orsnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrsnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_GAIN_CODE, Lookup lineage reference object : stvgain
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gainCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GainCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_CAPL_CODE, Lookup lineage reference object : stvcapl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("caplCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CaplCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_VOED_CODE, Lookup lineage reference object : stvvoed
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voedCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VoedCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_PRAC_CODE, Lookup lineage reference object : stvprac
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pracCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PracCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_TRCN_CODE, Lookup lineage reference object : stvtrcn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trcnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TrcnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_EDLV_CODE, Lookup lineage reference object : stvedlv
        /// </summary>
        [Newtonsoft.Json.JsonProperty("edlvCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EdlvCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_EGOL_CODE, Lookup lineage reference object : stvegol
        /// </summary>
        [Newtonsoft.Json.JsonProperty("egolCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EgolCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_INCM_CODE, Lookup lineage reference object : stvincm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("incmCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IncmCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_BSKL_CODE, Lookup lineage reference object : stvbskl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bsklCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BsklCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_EMEX_CODE, Lookup lineage reference object : stvemex
        /// </summary>
        [Newtonsoft.Json.JsonProperty("emexCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EmexCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_GRAD_CREDIT_APPR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gradCreditApprInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GradCreditApprInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_APRN_CODE, Lookup lineage reference object : stvaprn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aprnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AprnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_LEAV_FROM_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("leavFromDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? LeavFromDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_LEAV_CODE, Lookup lineage reference object : stvleav
        /// </summary>
        [Newtonsoft.Json.JsonProperty("leavCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LeavCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_LEAV_TO_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("leavToDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? LeavToDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ActivityDate { get; set; } = default!;

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