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

namespace Ellucian.Generated.BpApi.Ban.AwardMaintenanceAwardScheduleV100QapiPost
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AwardMaintenanceAwardScheduleV100QapiPost
    {
        [Newtonsoft.Json.JsonProperty("keyblckAidyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblckAidyCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Id { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRATRM_FUND_CODE, Lookup lineage reference object : rfrbase,rfraspc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRATRM_AWST_CODE, Lookup lineage reference object : rtvawst
        /// </summary>
        [Newtonsoft.Json.JsonProperty("awstCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AwstCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRATRM_PERIOD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Period { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRATRM_OFFER_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offerAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OfferAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRATRM_ACCEPT_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acceptAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AcceptAmt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayDeccanAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayDeccanAmt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayMemautAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayMemautAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRATRM_PAID_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("paidAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PaidAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRATRM_LOCK_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lockInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LockInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRATRM_PCKG_LOAD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pckgLoadInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PckgLoadInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRATRM_PELL_AWRD_LOAD_OPT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pellAwrdLoadOpt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PellAwrdLoadOpt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRATRM_BBAY_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bbayCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BbayCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRATRM_MAJR_OVERRIDE_CODE, Lookup lineage reference object : RPRMAJR,STVMAJR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("majrOverrideCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MajrOverrideCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRATRM_OVERRIDE_DISB_RULE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("overrideDisbRule", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OverrideDisbRule { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRATRM_NSLDS_OVRD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nsldsOvrdInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NsldsOvrdInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayRprawrdAwstCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayRprawrdAwstCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayLockInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayLockInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRATRM_DISB_FINAL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("disbFinalInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisbFinalInd { get; set; } = default!;

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