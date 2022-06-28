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

namespace Ellucian.Generated.BpApi.Ban.GlobalInstitutionFinancialAidOptionsAidYearDefinition100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GlobalInstitutionFinancialAidOptionsAidYearDefinition100PutRequest
    {
        /// <summary>
        /// Lineage reference object : ROBINST_AIDY_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aidyDesc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AidyDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblckAidyCode, Lookup lineage reference object : robinst
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckAidyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblckAidyCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_RETENTION_EXPIRED_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("retentionExpiredInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RetentionExpiredInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_AIDY_END_YEAR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aidyEndYear", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double AidyEndYear { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_STATUS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statusInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatusInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_PIVOT_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pivotDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset PivotDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_AIDY_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aidyEndDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset AidyEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_PERIOD_ENABLED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("periodEnabled", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PeriodEnabled { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_AIDY_START_YEAR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aidyStartYear", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double AidyStartYear { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_AIDY_START_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aidyStartDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset AidyStartDate { get; set; } = default!;

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