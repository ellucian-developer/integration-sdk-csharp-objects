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

namespace Ellucian.Generated.BpApi.Ban.RequirementsTrackingCodes100GetRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class RequirementsTrackingCodes100GetRequest
    {
        /// <summary>
        /// Lineage reference object : RTVTREQ_INSTRUCTIONS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instructions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Instructions { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVTREQ_TERM_ELIGIBLE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termEligibleInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermEligibleInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVTREQ_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVTREQ_SATISFY_ALL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("satisfyAllInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SatisfyAllInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVTREQ_PERK_MPN_FLAG
        /// </summary>
        [Newtonsoft.Json.JsonProperty("perkMpnFlag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PerkMpnFlag { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVTREQ_LTR_EXCLUDE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ltrExcludeInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LtrExcludeInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVTREQ_INFO_ACCESS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("infoAccessInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InfoAccessInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVTREQ_UPDATE_PRIOR_YEAR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("updatePriorYearInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UpdatePriorYearInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVTREQ_PCKG_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pckgInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PckgInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVTREQ_URL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Url { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVTREQ_MEMO_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("memoInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MemoInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVTREQ_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVTREQ_ONCE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("onceInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OnceInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVTREQ_ACCESS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accessInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AccessInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVTREQ_DISB_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("disbInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisbInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVTREQ_ACTIVE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activeInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ActiveInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVTREQ_SHORT_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shortDesc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ShortDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVTREQ_USE_FED_FUND_ID_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("useFedFundIdInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UseFedFundIdInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVTREQ_VR_MSG_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vrMsgNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? VrMsgNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVTREQ_LONG_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("longDesc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LongDesc { get; set; } = default!;

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