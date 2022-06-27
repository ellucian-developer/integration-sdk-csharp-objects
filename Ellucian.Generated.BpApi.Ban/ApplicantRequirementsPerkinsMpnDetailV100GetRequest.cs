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

namespace Ellucian.Generated.BpApi.Ban.ApplicantRequirementsPerkinsMpnDetailV100GetRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ApplicantRequirementsPerkinsMpnDetailV100GetRequest
    {
        /// <summary>
        /// Lineage reference object : RRRAREQ_EST_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rrrareqEstDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? RrrareqEstDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RRRAREQ_TREQ_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rrrareqTreqCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RrrareqTreqCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RRRAREQ_PERK_MPN_EXP_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rrrareqPerkMpnExpDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? RrrareqPerkMpnExpDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayActive", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayActive { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RRRAREQ_FUND_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rrrareqFundCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RrrareqFundCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rrrareqTreqDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RrrareqTreqDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RRRAREQ_TRST_CODE, Lookup lineage reference object : rtvtrst
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rrrareqTrstCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RrrareqTrstCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RRRAREQ_SATISFIED_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rrrareqSatisfiedDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? RrrareqSatisfiedDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblckAidyCode, Lookup lineage reference object : robinst
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckAidyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblckAidyCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblckId
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblckId { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rfrbaseFundTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RfrbaseFundTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RRRAREQ_STAT_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rrrareqStatDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? RrrareqStatDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RRRAREQ_SAT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rrrareqSatInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RrrareqSatInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RRRAREQ_MPN_FIRST_DISB_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rrrareqMpnFirstDisbDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? RrrareqMpnFirstDisbDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RRRAREQ_MPN_SIGNED_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rrrareqMpnSignedDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? RrrareqMpnSignedDate { get; set; } = default!;

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