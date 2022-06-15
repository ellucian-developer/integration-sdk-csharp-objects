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

namespace Ellucian.Generated.BpApi.Ban.CourseSectionInformationCopyCrnV100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CourseSectionInformationCopyCrnV100PutRequest
    {
        /// <summary>
        /// Lineage reference object : SSBSECT_PRNT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssbsectPrntInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsbsectPrntInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_CREDIT_HRS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creditHrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CreditHrs { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ssasectCrn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssasectCrn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? SsasectCrn { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_TUIW_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tuiwInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TuiwInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Title { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_GMOD_CODE, Lookup lineage reference object : stvgmod,scrgmod,scrgmod
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gModCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GModCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_SCHD_CODE, Lookup lineage reference object : scrschd,stvschd,scrschd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schdCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SchdCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_SESS_CODE, Lookup lineage reference object : stvsess
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sessCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SessCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_BILL_HRS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("billHrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BillHrs { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_VOICE_AVAIL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voiceAvail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VoiceAvail { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_CAMP_CODE, Lookup lineage reference object : stvcamp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("campCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CampCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_LEC_HR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lecHr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LecHr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_SSTS_CODE, Lookup lineage reference object : stvssts
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sstsCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SstsCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssasectCrnDefault", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsasectCrnDefault { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_INTG_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intgCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IntgCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_PTRM_START_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptrmStartDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? PtrmStartDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_OTH_HR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("othHr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OthHr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_CONT_HR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contHr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ContHr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_GRADABLE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gradableInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GradableInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("xlstGroup", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? XlstGroup { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_SUBJ_CODE, Lookup lineage reference object : stvsubj
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subjCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SubjCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_LINK_IDENT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("linkIdent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LinkIdent { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_LAB_HR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("labHr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LabHr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_INSM_CODE, Lookup lineage reference object : gtvinsm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("insmCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InsmCode { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssasectTermCodeDefault", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsasectTermCodeDefault { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_ACCT_CODE, Lookup lineage reference object : stvacct
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_CRSE_NUMB
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crseNumb", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CrseNumb { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_PTRM_CODE, Lookup lineage reference object : sobptrm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptrmCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PtrmCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ssasectTermCode, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssasectTermCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? SsasectTermCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_SAPR_CODE, Lookup lineage reference object : stvsapr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("saprCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SaprCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_SEQ_NUMB
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seqNumb", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeqNumb { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_PTRM_WEEKS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptrmWeeks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PtrmWeeks { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_PTRM_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptrmEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? PtrmEndDate { get; set; } = default!;

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