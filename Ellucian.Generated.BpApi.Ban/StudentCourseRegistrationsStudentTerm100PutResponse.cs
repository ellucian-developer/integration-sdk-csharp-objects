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

namespace Ellucian.Generated.BpApi.Ban.StudentCourseRegistrationsStudentTerm100PutResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class StudentCourseRegistrationsStudentTerm100PutResponse
    {
        [Newtonsoft.Json.JsonProperty("key_block", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Key_block>? Key_block { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("sgbstdn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Sgbstdn>? Sgbstdn { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Key_block
    {
        /// <summary>
        /// Lineage reference object : printBill
        /// </summary>
        [Newtonsoft.Json.JsonProperty("printBill", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PrintBill { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : printSchedule
        /// </summary>
        [Newtonsoft.Json.JsonProperty("printSchedule", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PrintSchedule { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : holdDesc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("holdDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HoldDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : confidInd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("confidInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ConfidInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyStudypath, Lookup lineage reference object : sovlcur,stvastd,stvcast,sgvstsp,sgrstsp,stvastd,stvcast,sgvstsp,sgrstsp,sovlcur
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyStudypath", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? KeyStudypath { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : dcsdInd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dcsdInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DcsdInd { get; set; } = default!;

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
        /// Lineage reference object : rwname
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rwname", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Rwname { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : rstsEstsDate
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rstsEstsDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? RstsEstsDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : term, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("term", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Term { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Id { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : lastAssessmentDate
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lastAssessmentDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? LastAssessmentDate { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Sgbstdn
    {
        [Newtonsoft.Json.JsonProperty("termCastDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermCastDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("astdDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AstdDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("advrName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AdvrName { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("termEffDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermEffDesc { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvcast
        /// </summary>
        [Newtonsoft.Json.JsonProperty("xxxxxxxCastCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? XxxxxxxCastCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("lastTermAttended", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LastTermAttended { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ststDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StstDesc { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvprev
        /// </summary>
        [Newtonsoft.Json.JsonProperty("xxxxxxxPrevCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? XxxxxxxPrevCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_RATE_CODE, Lookup lineage reference object : stvrate
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rateCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RateCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("resdDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ResdDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("xxxxxxxTermCodePrev", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? XxxxxxxTermCodePrev { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stypDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StypDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvscpcDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvscpcDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("fullPartDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FullPartDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("xxxxxxxTermCodeCast", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? XxxxxxxTermCodeCast { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("termPrevDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermPrevDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_FULL_PART_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fullPartInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FullPartInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("castDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CastDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("termAstdDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermAstdDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_TERM_CODE_EFF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCodeEff", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermCodeEff { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvastd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("xxxxxxxAstdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? XxxxxxxAstdCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("prevDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PrevDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_RESD_CODE, Lookup lineage reference object : stvresd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resdCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResdCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("blckDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BlckDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("termaDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermaDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_SCPC_CODE, Lookup lineage reference object : stvscpc,sobscps,sorscpt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scpcCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ScpcCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rateDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RateDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_STST_CODE, Lookup lineage reference object : stvstst
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ststCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StstCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_BLCK_CODE, Lookup lineage reference object : stvblck
        /// </summary>
        [Newtonsoft.Json.JsonProperty("blckCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BlckCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_STYP_CODE, Lookup lineage reference object : stvstyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stypCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StypCode { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvclas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sgrclsrClasCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SgrclsrClasCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("clasDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ClasDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("xxxxxxxTermCodeAstd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? XxxxxxxTermCodeAstd { get; set; } = default!;

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