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

namespace Ellucian.Generated.BpApi.Ban.CommodityMaintenanceV100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CommodityMaintenanceV100PutRequest
    {
        /// <summary>
        /// Lineage reference object : FTVCOMM_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVCOMM_TGRP_CODE, Lookup lineage reference object : ftvtrat,ftvtgrp,ftrtgtr,ftvtgrp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tgrpCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TgrpCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVCOMM_TAX_OVERRIDE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taxOverrideInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TaxOverrideInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTRCOMM_COAS_CODE, Lookup lineage reference object : ftvcoas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coasCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CoasCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVCOMM_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.desc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVCOMM_TERM_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.termDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaTermDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVCOMM_EFF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset EffDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVCOMM_AMST_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amstInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AmstInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTRCOMM_COAS_CODE, Lookup lineage reference object : ftvcoas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.coasCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCoasCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVCOMM_STOCK_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stockInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StockInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVCOMM_EFF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.effDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CriteriaEffDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVCOMM_EST_LIFE_YEARS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("estLifeYears", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? EstLifeYears { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTRCOMM_ACCT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.acctCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaAcctCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVCOMM_COMM_CODE_PRED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.commCodePred", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCommCodePred { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVCOMM_UOMS_CODE, Lookup lineage reference object : ftvuoms
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.uomsCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaUomsCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVCOMM_TAX_OVERRIDE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.taxOverrideInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaTaxOverrideInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTRCOMM_ACCT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AcctCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVCOMM_AMST_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.amstInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaAmstInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVCOMM_EST_LIFE_YEARS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.estLifeYears", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaEstLifeYears { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : displayCommCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("displayCommCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? DisplayCommCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVCOMM_TGRP_CODE, Lookup lineage reference object : ftvtrat,ftvtgrp,ftrtgtr,ftvtgrp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.tgrpCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaTgrpCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVCOMM_COMM_CODE_PRED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commCodePred", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CommCodePred { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVCOMM_TERM_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TermDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVCOMM_STOCK_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.stockInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaStockInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVCOMM_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Desc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVCOMM_UOMS_CODE, Lookup lineage reference object : ftvuoms
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uomsCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UomsCode { get; set; } = default!;

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