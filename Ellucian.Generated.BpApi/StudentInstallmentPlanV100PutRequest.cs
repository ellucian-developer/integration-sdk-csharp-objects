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

namespace Ellucian.Generated.BpApi.Ban.StudentInstallmentPlanV100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class StudentInstallmentPlanV100PutRequest
    {
        /// <summary>
        /// Lineage reference object : TBRISTL_SERV_CHARGE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.servCharge", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaServCharge { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_NUMBER_OF_PAYMENTS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("numberOfPayments", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double NumberOfPayments { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_FIRST_INSTALL_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.firstInstallDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CriteriaFirstInstallDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_REF_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.refNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaRefNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_INSTALLMENT_PLAN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.installmentPlan", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaInstallmentPlan { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_PAY_PERIOD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.payPeriod", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CriteriaPayPeriod { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_PLAN_AMOUNT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.planAmount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CriteriaPlanAmount { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_AUTO_CALC_PLAN_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.autoCalcPlanInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaAutoCalcPlanInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_NUMBER_OF_PAYMENTS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.numberOfPayments", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CriteriaNumberOfPayments { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_AUTO_CALC_ACTIVE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("autoCalcActiveInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AutoCalcActiveInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_AUTO_CALC_ACTIVE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.autoCalcActiveInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaAutoCalcActiveInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_TERM_CODE, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.termCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaTermCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.desc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_INT_RATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.intRate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaIntRate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_PLAN_DETAIL_CODE, Lookup lineage reference object : tbbdetc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.planDetailCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaPlanDetailCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_PAY_PERIOD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payPeriod", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double PayPeriod { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_PRIN_DETAIL_CODE, Lookup lineage reference object : tbbdetc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.prinDetailCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaPrinDetailCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_FIRST_INSTALL_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("firstInstallDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset FirstInstallDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_INT_DETAIL_CODE, Lookup lineage reference object : tbbdetc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.intDetailCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaIntDetailCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_SERV_DETAIL_CODE, Lookup lineage reference object : tbbdetc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.servDetailCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaServDetailCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Id { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_SVC_CHG_PCT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.svcChgPct", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaSvcChgPct { get; set; } = default!;

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