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

namespace Ellucian.Generated.BpApi.Ban.ScheduleCalendarV100PutResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ScheduleCalendarV100PutResponse
    {
        [Newtonsoft.Json.JsonProperty("acclDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcclDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_CENSUS_2_ENRL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("census2Enrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Census2Enrl { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_ACCL_CODE, Lookup lineage reference object : stvaccl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acclCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcclCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_REFUND_CUTOFF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rfndCutOffDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? RfndCutOffDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("sectStartDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? SectStartDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_CENSUS_2_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("census2Date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Census2Date { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_ENRL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Enrl { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ptrmDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PtrmDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_PTRM_CODE, Lookup lineage reference object : stvptrm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptrmCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PtrmCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("sectBeginDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? SectBeginDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_PTRM_WEEKS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptrmWeeks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PtrmWeeks { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_CENSUS_ENRL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("censusEnrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CensusEnrl { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_CENSUS_ENRL_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("censusEnrlDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CensusEnrlDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_PTRM_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptrmEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? PtrmEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_ACAD_CUT_OFF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acadCutOffDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? AcadCutOffDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_DROP_CUT_OFF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dropCutOffDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DropCutOffDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_ENRL_CUT_OFF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enrlCutOffDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EnrlCutOffDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("sectNumDay", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SectNumDay { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("sectNumWeek", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SectNumWeek { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("sectEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? SectEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_PTRM_START_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptrmStartDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? PtrmStartDate { get; set; } = default!;

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