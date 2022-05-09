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

namespace Ellucian.Generated.BpApi.Ban.InstallmentPlansV100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class InstallmentPlansV100GetResponse
    {
        [Newtonsoft.Json.JsonProperty("prinDetailDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PrinDetailDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_NUMBER_OF_PAYMENTS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("numberOfPayments", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double NumberOfPayments { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("planDetailDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PlanDetailDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_INT_RATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intRate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? IntRate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("servDetailDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ServDetailDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("intDetailDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IntDetailDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_SERV_DETAIL_CODE, Lookup lineage reference object : tbbdetc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("servDetailCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ServDetailCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("paymentDueInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PaymentDueInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_PRIN_DETAIL_CODE, Lookup lineage reference object : tbbdetc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prinDetailCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PrinDetailCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_PLAN_DETAIL_CODE, Lookup lineage reference object : tbbdetc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("planDetailCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlanDetailCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("atypDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AtypDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_INT_DETAIL_CODE, Lookup lineage reference object : tbbdetc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intDetailCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IntDetailCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_SERV_CHARGE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("servCharge", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ServCharge { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_PAY_PERIOD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payPeriod", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double PayPeriod { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_REF_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RefNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_FIRST_INSTALL_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("firstInstallDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset FirstInstallDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_INSTALLMENT_PLAN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("installmentPlan", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InstallmentPlan { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("atypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AtypCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("atypSeqno", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AtypSeqno { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_PLAN_AMOUNT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("planAmount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double PlanAmount { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_DESC
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