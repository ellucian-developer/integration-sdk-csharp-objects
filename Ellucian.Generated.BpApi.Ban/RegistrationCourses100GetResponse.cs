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

namespace Ellucian.Generated.BpApi.Ban.RegistrationCourses100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class RegistrationCourses100GetResponse
    {
        [Newtonsoft.Json.JsonProperty("ssrmeet", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Ssrmeet>? Ssrmeet { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssbsect", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Ssbsect>? Ssbsect { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("sfrstcr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Sfrstcr>? Sfrstcr { get; set; } = default!;

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
        /// Lineage reference object : SSRMEET_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EndDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("buildingDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BuildingDescription { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_WED_DAY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wedDay", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WedDay { get; set; } = default!;

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
        /// Lineage reference object : SSRMEET_SUN_DAY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sunDay", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SunDay { get; set; } = default!;

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
        /// Lineage reference object : SSRMEET_BLDG_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bldgCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BldgCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRMEET_START_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? StartDate { get; set; } = default!;

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
    public partial class Ssbsect
    {
        [Newtonsoft.Json.JsonProperty("scbcrseOthHrLow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ScbcrseOthHrLow { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_CREDIT_HRS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creditHrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CreditHrs { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseOthHrHigh", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ScbcrseOthHrHigh { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseBillHrInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ScbcrseBillHrInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseContHrHigh", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ScbcrseContHrHigh { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseContHrInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ScbcrseContHrInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Title { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseBillHrLow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ScbcrseBillHrLow { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_SCHD_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schdCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SchdCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_BILL_HRS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("billHrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BillHrs { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseLabHrLow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ScbcrseLabHrLow { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_CAMP_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("campCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CampCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_LEC_HR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lecHr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LecHr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_SSTS_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sstsCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SstsCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseLecHrHigh", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ScbcrseLecHrHigh { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseCreditHrInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ScbcrseCreditHrInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseLabHrInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ScbcrseLabHrInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseContHrLow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ScbcrseContHrLow { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_OTH_HR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("othHr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OthHr { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseLecHrLow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ScbcrseLecHrLow { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_CONT_HR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contHr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ContHr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_GMOD_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmodCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GmodCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseBillHrHigh", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ScbcrseBillHrHigh { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("xlstGroup", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? XlstGroup { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_SUBJ_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subjCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SubjCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("xlstAvail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? XlstAvail { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_LAB_HR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("labHr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LabHr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_SEATS_AVAIL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seatsAvail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SeatsAvail { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseCeuInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ScbcrseCeuInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseCreditHrLow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ScbcrseCreditHrLow { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseLecHrInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ScbcrseLecHrInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("blockInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BlockInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_CRSE_NUMB
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crseNumb", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CrseNumb { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseCreditHrHigh", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ScbcrseCreditHrHigh { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseMaxRptUnits", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ScbcrseMaxRptUnits { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseLabHrHigh", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ScbcrseLabHrHigh { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_SEQ_NUMB
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seqNumb", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeqNumb { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseRepsCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ScbcrseRepsCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseOthHrInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ScbcrseOthHrInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseRepeatLimit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ScbcrseRepeatLimit { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_WAIT_COUNT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waitCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? WaitCount { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Sfrstcr
    {
        /// <summary>
        /// Lineage reference object : SFRSTCR_PREQ_OVER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("preqOver", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PreqOver { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_LEVL_OVER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("levlOver", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LevlOver { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_DUPL_OVER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("duplOver", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DuplOver { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_LINK_OVER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("linkOver", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LinkOver { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_REPT_OVER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reptOver", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ReptOver { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_TIME_OVER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timeOver", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TimeOver { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_COLL_OVER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("collOver", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CollOver { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_DEPT_OVER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deptOver", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DeptOver { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_PROG_OVER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("progOver", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProgOver { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_CAPC_OVER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("capcOver", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CapcOver { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_CORQ_OVER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("corqOver", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CorqOver { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_APPR_OVER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apprOver", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ApprOver { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_CAMP_OVER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("campOver", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CampOver { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_CHRT_OVER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chrtOver", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ChrtOver { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_ATTS_OVER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attsOver", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AttsOver { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_DEGC_OVER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("degcOver", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DegcOver { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_RPTH_OVER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rpthOver", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RpthOver { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_CLAS_OVER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("clasOver", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ClasOver { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSTCR_MAJR_OVER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("majrOver", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MajrOver { get; set; } = default!;

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