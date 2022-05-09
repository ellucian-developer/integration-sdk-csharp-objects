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

namespace Ellucian.Generated.BpApi.Ban.FinancialAidRecordMaintenanceV100QapiPost
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class FinancialAidRecordMaintenanceV100QapiPost
    {
        [Newtonsoft.Json.JsonProperty("keyblckAidyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblckAidyCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Id { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRAWRD_FUND_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("fundDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundDescription { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRAWRD_AWST_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("awstCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AwstCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRAWRD_LOCK_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lockInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LockInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRAWRD_SYS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sysInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SysInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRAWRD_OFFER_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offerAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OfferAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRAWRD_ACCEPT_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acceptAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AcceptAmt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayDeccanAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DisplayDeccanAmt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayMemautAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DisplayMemautAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRAWRD_PAID_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("paidAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PaidAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRAWRD_INFO_ACCESS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("infoAccessInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InfoAccessInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("pgrpCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PgrpCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayRtvpgrpDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayRtvpgrpDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("prepOrTeachInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PrepOrTeachInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("pellOrigInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PellOrigInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("pgrpCodeLockInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PgrpCodeLockInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("highPellLeuFlag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HighPellLeuFlag { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("addlPellEligInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddlPellEligInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("pckgCompDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PckgCompDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("borrowerBasedCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BorrowerBasedCde { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("postBaPellOvrd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PostBaPellOvrd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("pgrpLockInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PgrpLockInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ovrdeSayrCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OvrdeSayrCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("formerHealInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FormerHealInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("addlStfdEligInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddlStfdEligInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("awdLtrInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AwdLtrInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("depNoParData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DepNoParData { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayDependStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayDependStatus { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayInfoAccessInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayInfoAccessInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssInfoAccessInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsInfoAccessInd { get; set; } = default!;

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