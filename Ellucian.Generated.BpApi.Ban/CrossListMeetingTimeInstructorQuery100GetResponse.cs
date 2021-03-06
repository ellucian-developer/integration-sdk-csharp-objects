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

namespace Ellucian.Generated.BpApi.Ban.CrossListMeetingTimeInstructorQuery100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CrossListMeetingTimeInstructorQuery100GetResponse
    {
        [Newtonsoft.Json.JsonProperty("ssvxmti", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Ssvxmti>? Ssvxmti { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("sirasgn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Sirasgn>? Sirasgn { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Ssvxmti
    {
        /// <summary>
        /// Lineage reference object : SSRMEET_BEGIN_TIME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssrmeetBeginTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsrmeetBeginTime { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_ROOM_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssrmeetRoomCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsrmeetRoomCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_END_TIME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssrmeetEndTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsrmeetEndTime { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_CREDIT_HR_SESS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssrmeetCreditHrSess", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SsrmeetCreditHrSess { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_START_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssrmeetStartDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? SsrmeetStartDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_OVER_RIDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssrmeetOverRide", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsrmeetOverRide { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("meetDays", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MeetDays { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssrmeetEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? SsrmeetEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_BLDG_CODE, Lookup lineage reference object : stvbldg
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssrmeetBldgCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsrmeetBldgCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_MTYP_CODE, Lookup lineage reference object : gtvmtyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssrmeetMtypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsrmeetMtypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_CATAGORY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssrmeetCatagory", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsrmeetCatagory { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_SCHD_CODE, Lookup lineage reference object : stvschd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssrmeetSchdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsrmeetSchdCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("meetCrn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MeetCrn { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("meetInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MeetInd { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Sirasgn
    {
        /// <summary>
        /// Lineage reference object : SIRASGN_PERCENT_RESPONSE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("percentResponse", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PercentResponse { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRASGN_OVER_RIDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("overRide", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OverRide { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Name { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRASGN_CATEGORY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Category { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("idno", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Idno { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRASGN_PERCENT_SESS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("percentSess", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PercentSess { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRASGN_PRIMARY_IND
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