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

namespace Ellucian.Generated.BpApi.Ban.AttributeValuesMaintenanceV100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AttributeValuesMaintenanceV100PutRequest
    {
        /// <summary>
        /// Lineage reference object : FTRATTV_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTRATTV_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTRATTV_VALID_LOCN_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("validLocnInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ValidLocnInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTRATTV_VALID_ACCT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.validAcctInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaValidAcctInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTRATTV_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTRATTV_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.endDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : coasCode, Lookup lineage reference object : ftvcoas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coasCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CoasCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTRATTV_VALID_ORGN_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.validOrgnInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaValidOrgnInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTRATTV_VALID_FUND_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.validFundInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaValidFundInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTRATTV_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.desc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTRATTV_BEGIN_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.beginDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CriteriaBeginDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTRATTV_VALID_ALL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.validAllInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaValidAllInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTRATTV_GASB_DEFER_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.gasbDeferInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaGasbDeferInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTRATTV_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTRATTV_VALID_LOCN_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.validLocnInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaValidLocnInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : atttCode, Lookup lineage reference object : ftvattt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("atttCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AtttCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTRATTV_VALID_ORGN_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("validOrgnInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ValidOrgnInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTRATTV_VALID_FUND_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("validFundInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ValidFundInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTRATTV_VALID_PROG_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("validProgInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ValidProgInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTRATTV_GASB_DEFER_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gasbDeferInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GasbDeferInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTRATTV_VALID_ACTV_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.validActvInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaValidActvInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTRATTV_VALID_ACCT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("validAcctInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ValidAcctInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTRATTV_VALID_ALL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("validAllInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ValidAllInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTRATTV_VALID_PROG_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.validProgInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaValidProgInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTRATTV_BEGIN_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("beginDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset BeginDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTRATTV_VALID_ACTV_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("validActvInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ValidActvInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTRATTV_DESC
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