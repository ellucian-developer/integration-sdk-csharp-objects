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

namespace Ellucian.Generated.BpApi.Ban.TermControlPartOfTermAndWebRegistrationControlsV100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TermControlPartOfTermAndWebRegistrationControlsV100GetResponse
    {
        /// <summary>
        /// Lineage reference object : SOBPTRM_ACAD_CUTOFF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acadCutoffDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? AcadCutoffDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPTRM_FGRD_WEB_UPD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fgrdWebUpdInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FgrdWebUpdInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPTRM_CENSUS_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("censusDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CensusDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPTRM_WEEKS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("weeks", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Weeks { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPTRM_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset EndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPTRM_SECT_OVER_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sectOverInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SectOverInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPTRM_CENSUS_2_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("census2Date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Census2Date { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPTRM_REFUND_CUTOFF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refundCutoffDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? RefundCutoffDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPTRM_WAITLST_WEB_DISP_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waitlstWebDispInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WaitlstWebDispInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPTRM_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPTRM_PTRM_CODE, Lookup lineage reference object : stvptrm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptrmCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PtrmCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPTRM_MGRD_WEB_UPD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mgrdWebUpdInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MgrdWebUpdInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPTRM_ENRL_CUTOFF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enrlCutoffDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EnrlCutoffDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPTRM_DROP_CUTOFF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dropCutoffDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DropCutoffDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPTRM_INCOMPLETE_EXT_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("incompleteExtDat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? IncompleteExtDat { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPTRM_START_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset StartDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPTRM_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Desc { get; set; } = default!;

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