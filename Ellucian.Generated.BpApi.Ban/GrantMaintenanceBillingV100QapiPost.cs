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

namespace Ellucian.Generated.BpApi.Ban.GrantMaintenanceBillingV100QapiPost
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GrantMaintenanceBillingV100QapiPost
    {
        [Newtonsoft.Json.JsonProperty("displayFrbgrntCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayFrbgrntCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayPropCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayPropCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_PMSC_CODE, Lookup lineage reference object : frvpmsc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pmscCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PmscCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_LAST_INV_SEQ_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lastInvSeqNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LastInvSeqNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_BECL_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("beclCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BeclCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_BFRM_CODE_1034_EXT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bfrmCode1034Ext", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BfrmCode1034Ext { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_BUDGET_LIMIT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budgetLimitInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BudgetLimitInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_BUD_LINE_EXCEED_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budLineExceedInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BudLineExceedInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_PAYMENT_FUND_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("paymentFundCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PaymentFundCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_MIN_NOT_REACHED_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minNotReachedInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MinNotReachedInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_PAYMENT_ACCT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("paymentAcctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PaymentAcctCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_BUD_TOTAL_EXCEED_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budTotalExceedInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BudTotalExceedInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_CLEARING_ACCT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("clearingAcctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ClearingAcctCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_BUD_CHECK_SOURCE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budCheckSourceInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BudCheckSourceInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_ADDR_TYPE, Lookup lineage reference object : stvatyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addrType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddrType { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_BILLING_START_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("billingStartDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? BillingStartDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_ADDR_SEQNO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addrSeqno", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AddrSeqno { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_BILLING_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("billingEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? BillingEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_BILLING_MIN_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("billingMinAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BillingMinAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_BILLING_MAX_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("billingMaxAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BillingMaxAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_CUMULATIVE_BILLED_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cumulativeBilledAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CumulativeBilledAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_DEFERRED_ACCT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deferredAcctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DeferredAcctCode { get; set; } = default!;

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