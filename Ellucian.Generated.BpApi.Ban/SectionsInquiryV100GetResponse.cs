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

namespace Ellucian.Generated.BpApi.Ban.SectionsInquiryV100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SectionsInquiryV100GetResponse
    {
        /// <summary>
        /// Lineage reference object : SSBSECT_DUNT_CODE, Lookup lineage reference object : gtvdunt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("duntCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DuntCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_ENRL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Enrl { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Title { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_REG_FROM_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("regFromDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? RegFromDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_SCHD_CODE, Lookup lineage reference object : stvschd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SchdCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_RESERVED_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reservedInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ReservedInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("syllabusInfoExists", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SyllabusInfoExists { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_CAMP_CODE, Lookup lineage reference object : stvcamp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("campCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CampCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_SSTS_CODE, Lookup lineage reference object : stvssts
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sstsCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SstsCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_CRN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Crn { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("sectionCommentsExist", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SectionCommentsExist { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_WAIT_CAPACITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waitCapacity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? WaitCapacity { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_SUBJ_CODE, Lookup lineage reference object : stvsubj
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subjCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SubjCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_LINK_IDENT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("linkIdent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LinkIdent { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_INSM_CODE, Lookup lineage reference object : gtvinsm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("insmCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InsmCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_SEATS_AVAIL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seatsAvail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SeatsAvail { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_MAX_ENRL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maxEnrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MaxEnrl { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("blockInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BlockInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_CRSE_NUMB
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crseNumb", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CrseNumb { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_NUMBER_OF_UNITS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("numberOfUnits", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NumberOfUnits { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_PTRM_CODE, Lookup lineage reference object : stvptrm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptrmCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PtrmCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("longTitleExists", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LongTitleExists { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_WAIT_AVAIL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waitAvail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? WaitAvail { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_REG_TO_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("regToDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? RegToDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_SEQ_NUMB
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seqNumb", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SeqNumb { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_WAIT_COUNT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waitCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? WaitCount { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRXLST_XLST_GROUP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssrxlstXlstGroup", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsrxlstXlstGroup { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_TERM_CODE, Lookup lineage reference object : stvterm
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


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603