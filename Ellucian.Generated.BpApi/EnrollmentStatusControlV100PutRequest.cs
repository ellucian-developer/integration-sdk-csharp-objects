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

namespace Ellucian.Generated.BpApi.Ban.EnrollmentStatusControlV100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class EnrollmentStatusControlV100PutRequest
    {
        /// <summary>
        /// Lineage reference object : SFBESTS_ESTS_CODE, Lookup lineage reference object : stvests
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.estsCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaEstsCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.stvestsDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaStvestsDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFBESTS_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFBESTS_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset EndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : xxxxxxxTermCode, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("xxxxxxxTermCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? XxxxxxxTermCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFBRFST_TO_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("toDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ToDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : xxxxxxxTermCodeDef, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("xxxxxxxTermCodeDef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? XxxxxxxTermCodeDef { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFBESTS_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.endDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CriteriaEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFBESTS_START_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.startDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CriteriaStartDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFBRFST_TUIT_REFUND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tuitRefund", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double TuitRefund { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFBESTS_ESTS_CODE, Lookup lineage reference object : stvests
        /// </summary>
        [Newtonsoft.Json.JsonProperty("estsCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EstsCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFBRFST_FROM_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fromDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset FromDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFBRFST_FEES_REFUND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("feesRefund", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double FeesRefund { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFBESTS_START_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset StartDate { get; set; } = default!;

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