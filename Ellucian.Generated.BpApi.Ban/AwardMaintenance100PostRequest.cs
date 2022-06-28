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

namespace Ellucian.Generated.BpApi.Ban.AwardMaintenance100PostRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AwardMaintenance100PostRequest
    {
        /// <summary>
        /// Lineage reference object : RPRAWRD_FED_LIMIT_OVRDE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fedLimitOvrdeInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FedLimitOvrdeInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRAWRD_ACCEPT_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acceptAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AcceptAmt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayMemautAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DisplayMemautAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRAWRD_TREQ_OVRDE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("treqOvrdeInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TreqOvrdeInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRAWRD_INFO_ACCESS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("infoAccessInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InfoAccessInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRAWRD_SYS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sysInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SysInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRAWRD_PAID_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("paidAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PaidAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRAWRD_UNMET_NEED_OVRDE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unmetNeedOvrdeInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UnmetNeedOvrdeInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("fundDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundDescription { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRAWRD_OVERRIDE_FUND_RULE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("overrideFundRule", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OverrideFundRule { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblckAidyCode, Lookup lineage reference object : robinst
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckAidyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblckAidyCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRAWRD_REPLACE_TFC_OVRDE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("replaceTfcOvrdeInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ReplaceTfcOvrdeInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRAWRD_AWST_CODE, Lookup lineage reference object : rtvawst
        /// </summary>
        [Newtonsoft.Json.JsonProperty("awstCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AwstCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayRescheduleInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayRescheduleInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRAWRD_FUND_CODE, Lookup lineage reference object : rfrbase,rfraspc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRAWRD_FUND_LIMIT_OVRDE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundLimitOvrdeInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundLimitOvrdeInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Id { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRAWRD_LOCK_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lockInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LockInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRAWRD_OFFER_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offerAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OfferAmt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayDeccanAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DisplayDeccanAmt { get; set; } = default!;

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