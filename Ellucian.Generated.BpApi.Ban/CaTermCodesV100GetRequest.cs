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

namespace Ellucian.Generated.BpApi.Ban.CaTermCodesV100GetRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CaTermCodesV100GetRequest
    {
        /// <summary>
        /// Lineage reference object : STVTERM_FA_PERIOD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("faPeriod", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FaPeriod { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVTERM_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVTERM_TERM_LEN_MULT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termLenMult", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TermLenMult { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVTERM_TRMT_CODE, Lookup lineage reference object : stvtrmt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trmtCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TrmtCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVTERM_SYSTEM_REQ_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("systemReqInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SystemReqInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVTERM_APPORT_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apportCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ApportCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVTERM_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset EndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVTERM_FA_TERM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("faTerm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FaTerm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVTERM_TERM_LEN_MULT_IS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termLenMultIs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TermLenMultIs { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVTERM_FA_SUMMER_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("faSummerInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FaSummerInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVTERM_ACYR_CODE, Lookup lineage reference object : stvacyr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acyrCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AcyrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVTERM_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVTERM_HOUSING_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("housingEndDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset HousingEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVTERM_FA_PROC_YR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("faProcYr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FaProcYr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVTERM_MIS_TERM_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("misTermId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MisTermId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVTERM_FA_END_PERIOD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("faEndPeriod", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FaEndPeriod { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVTERM_START_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset StartDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVTERM_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Desc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVTERM_HOUSING_START_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("housingStartDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset HousingStartDate { get; set; } = default!;

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