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

namespace Ellucian.Generated.BpApi.Ban.SectionMeetingTimesV100PostResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SectionMeetingTimesV100PostResponse
    {
        [Newtonsoft.Json.JsonProperty("ssrmeet", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Ssrmeet>? Ssrmeet { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssrmprt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Ssrmprt>? Ssrmprt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssrmrdf", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Ssrmrdf>? Ssrmrdf { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Ssrmeet
    {
        /// <summary>
        /// Lineage reference object : SSRMEET_OVER_RIDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("overRide", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OverRide { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset EndDate { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvmeet
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MeetCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_WED_DAY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wedDay", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WedDay { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("roomAttribDet", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RoomAttribDet { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_TUE_DAY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tueDay", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TueDay { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_ROOM_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("roomCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RoomCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_CREDIT_HR_SESS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creditHrSess", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CreditHrSess { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_CATAGORY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("catagory", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Catagory { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_SCHD_CODE, Lookup lineage reference object : scrschd,stvschd,scrschd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schdCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SchdCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_SUN_DAY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sunDay", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SunDay { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_HRS_WEEK
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hrsWeek", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double HrsWeek { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_SCHS_CODE, Lookup lineage reference object : GTVSCHS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schsCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SchsCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_FRI_DAY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("friDay", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FriDay { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_THU_DAY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("thuDay", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ThuDay { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_BEGIN_TIME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("beginTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BeginTime { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_END_TIME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EndTime { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_MTYP_CODE, Lookup lineage reference object : gtvmtyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mtypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MtypCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("partDet", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PartDet { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_BLDG_CODE, Lookup lineage reference object : stvbldg
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bldgCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BldgCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_START_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset StartDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_MON_DAY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("monDay", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MonDay { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_SAT_DAY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("satDay", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SatDay { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Ssrmprt
    {
        /// <summary>
        /// Lineage reference object : SSRMPRT_PARS_CODE, Lookup lineage reference object : gtvpars
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parsCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ParsCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMPRT_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("mprtParsDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MprtParsDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMPRT_PARS_PREF_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parsPrefNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ParsPrefNumber { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Ssrmrdf
    {
        /// <summary>
        /// Lineage reference object : SSRMRDF_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMRDF_RDEF_PREF_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rdefPrefNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RdefPrefNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMRDF_RDEF_CODE, Lookup lineage reference object : stvrdef
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rdefCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RdefCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("mrdfRdefDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MrdfRdefDesc { get; set; } = default!;

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