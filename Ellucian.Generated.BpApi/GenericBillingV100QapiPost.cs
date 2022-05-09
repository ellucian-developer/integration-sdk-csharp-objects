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

namespace Ellucian.Generated.BpApi.Ban.GenericBillingV100QapiPost
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GenericBillingV100QapiPost
    {
        [Newtonsoft.Json.JsonProperty("displayGrantCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayGrantCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayBfrmCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayBfrmCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayBillInv", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayBillInv { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayBillAdj", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayBillAdj { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRRGENB_GRNT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grntCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GrntCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRRGENB_BILL_INV_SEQ_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("billInvSeqNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BillInvSeqNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRRGENB_BILL_INV_ADJ_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("billInvAdjNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BillInvAdjNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRRGENB_UPDATE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("updateInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UpdateInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRRGENB_FINAL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finalInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FinalInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRRGENB_BILL_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("billAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BillAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRRGENB_COMPLETE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("completeInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CompleteInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRRGENB_BUDGET_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budgetAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BudgetAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRRGENB_BFRM_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bfrmCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BfrmCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRRGENB_WITHHOLDING_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("withholdingAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? WithholdingAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRRGENB_GROUP_SEQ_NO, Lookup lineage reference object : frrbfrm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("groupSeqNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? GroupSeqNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRRGENB_PERIOD_FROM_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("periodFromDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? PeriodFromDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRRGENB_PERIOD_TO_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("periodToDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? PeriodToDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRRGENB_DATE_SUBMITTED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dateSubmitted", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateSubmitted { get; set; } = default!;

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