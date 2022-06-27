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

namespace Ellucian.Generated.BpApi.Ban.PriorCollegePriorCollegeAndDegreeV100PostRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PriorCollegePriorCollegeAndDegreeV100PostRequest
    {
        /// <summary>
        /// Lineage reference object : SORDEGR_HOURS_TRANSFERRED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hoursTransferred", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? HoursTransferred { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORDEGR_GPA_TRANSFERRED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gpaTransferred", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? GpaTransferred { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORPCOL_SBGI_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sbgiCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SbgiCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORDEGR_DEGC_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("degcDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DegcDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORDEGR_DEGC_CODE, Lookup lineage reference object : stvdegc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("degcCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DegcCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORDEGR_ATTEND_TO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attendTo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? AttendTo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORPCOL_TRANS_RECV_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transRecvDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TransRecvDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORDEGR_ATTEND_FROM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attendFrom", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? AttendFrom { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORDEGR_DEGC_YEAR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("degcYear", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DegcYear { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORDEGR_HONR_CODE, Lookup lineage reference object : stvhonr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("honrCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HonrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORPCOL_ADMR_CODE, Lookup lineage reference object : stvadmr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("admrCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AdmrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORPCOL_OFFICIAL_TRANS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("officialTrans", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OfficialTrans { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORDEGR_EGOL_CODE, Lookup lineage reference object : stvegol
        /// </summary>
        [Newtonsoft.Json.JsonProperty("egolCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EgolCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORPCOL_TRANS_REV_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transRevDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TransRevDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Id { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORDEGR_COLL_CODE, Lookup lineage reference object : stvcoll
        /// </summary>
        [Newtonsoft.Json.JsonProperty("collCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CollCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORDEGR_PRIMARY_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("primaryInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PrimaryInd { get; set; } = default!;

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