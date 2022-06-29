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

namespace Ellucian.Generated.BpApi.Ban.PositionBudgetPositionBudget100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PositionBudgetPositionBudget100PutRequest
    {
        /// <summary>
        /// Lineage reference object : NBBPOSN_PREMIUM_ROLL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("premiumRollInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PremiumRollInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_AUTH_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.authNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaAuthNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_BPRO_CODE, Lookup lineage reference object : ntvbpro
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.bproCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaBproCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.endDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_ROLL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.rollInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaRollInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_BPRO_CODE, Lookup lineage reference object : ntvbpro
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bproCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BproCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : posn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("posn", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Posn { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_BEGIN_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.beginDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CriteriaBeginDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_BEGIN_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("beginDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset BeginDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : fiscCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fiscCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FiscCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_ROLL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rollInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RollInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_STATUS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaStatus { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_AUTH_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AuthNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_COAS_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.coasCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCoasCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_TYPE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaType { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_PREMIUM_ROLL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.premiumRollInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaPremiumRollInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_STATUS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Status { get; set; } = default!;

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