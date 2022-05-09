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

namespace Ellucian.Generated.BpApi.Ban.ApplicantInformationV100PostResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ApplicantInformationV100PostResponse
    {
        /// <summary>
        /// Lineage reference object : PABAPPL_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset Date { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PABAPPL_DESIRED_HOURLY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desiredHourly", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DesiredHourly { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("pclsDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PclsDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PABAPPL_REQ_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reqNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ReqNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PABAPPL_ASRC_CODE, Lookup lineage reference object : ptvasrc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("asrcCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AsrcCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PABAPPL_PCLS_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pclsCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PclsCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("esklDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EsklDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PABAPPL_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("asrcDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AsrcDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PABAPPL_POSN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("posn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Posn { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PABAPPL_DESIRED_SALARY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desiredSalary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DesiredSalary { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("currAppsCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CurrAppsCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("currAppsDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CurrAppsDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("currComment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CurrComment { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PABAPPL_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("currAppsDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CurrAppsDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PABAPPL_ESKL_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("esklCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EsklCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("dispDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DispDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("posnTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PosnTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PABAPPL_FULL_PART_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fullPartInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FullPartInd { get; set; } = default!;

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