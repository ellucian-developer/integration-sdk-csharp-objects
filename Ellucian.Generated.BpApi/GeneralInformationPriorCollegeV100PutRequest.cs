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

namespace Ellucian.Generated.BpApi.Ban.GeneralInformationPriorCollegeV100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GeneralInformationPriorCollegeV100PutRequest
    {
        /// <summary>
        /// Lineage reference object : SORDEGR_GPA_TRANSFERRED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gpaTransferred", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? GpaTransferred { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORDEGR_TERM_DEGREE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termDegree", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermDegree { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORDEGR_DEGC_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("degcDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DegcDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORPCOL_TRANS_RECV_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.transRecvDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaTransRecvDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORMINR_MAJR_CODE_MINOR, Lookup lineage reference object : stvmajr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.majrCodeMinor", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaMajrCodeMinor { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORMINR_MAJR_CODE_MINOR, Lookup lineage reference object : stvmajr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("majrCodeMinor", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MajrCodeMinor { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORPCOL_TRANS_RECV_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transRecvDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TransRecvDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORDEGR_ATTEND_TO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.attendTo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaAttendTo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORPCOL_TRANS_REV_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transRevDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TransRevDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORDEGR_HOURS_TRANSFERRED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.hoursTransferred", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaHoursTransferred { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORDEGR_GPA_TRANSFERRED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.gpaTransferred", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaGpaTransferred { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Id { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCONC_MAJR_CODE_CONC, Lookup lineage reference object : stvmajr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.majrCodeConc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaMajrCodeConc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORPCOL_OFFICIAL_TRANS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.officialTrans", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaOfficialTrans { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORDEGR_HOURS_TRANSFERRED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hoursTransferred", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? HoursTransferred { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORDEGR_DEGC_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.degcDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaDegcDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORDEGR_DEGC_CODE, Lookup lineage reference object : stvdegc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.degcCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaDegcCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCONC_MAJR_CODE_CONC, Lookup lineage reference object : stvmajr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("majrCodeConc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MajrCodeConc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORPCOL_TRANS_REV_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.transRevDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaTransRevDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORDEGR_ATTEND_TO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attendTo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? AttendTo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORMAJR_MAJR_CODE_MAJOR, Lookup lineage reference object : stvmajr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.majrCodeMajor", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaMajrCodeMajor { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORMAJR_MAJR_CODE_MAJOR, Lookup lineage reference object : stvmajr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("majrCodeMajor", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MajrCodeMajor { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORDEGR_ATTEND_FROM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attendFrom", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? AttendFrom { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORDEGR_TERM_DEGREE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.termDegree", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaTermDegree { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORDEGR_ATTEND_FROM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.attendFrom", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaAttendFrom { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORPCOL_OFFICIAL_TRANS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("officialTrans", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OfficialTrans { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORPCOL_SBGI_CODE, Lookup lineage reference object : stvsbgi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.sbgiCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaSbgiCode { get; set; } = default!;

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