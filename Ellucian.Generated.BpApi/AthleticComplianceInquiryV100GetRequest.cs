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

namespace Ellucian.Generated.BpApi.Ban.AthleticComplianceInquiryV100GetRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AthleticComplianceInquiryV100GetRequest
    {
        /// <summary>
        /// Lineage reference object : SGVISPT_ELIG_CODE, Lookup lineage reference object : stvelig
        /// </summary>
        [Newtonsoft.Json.JsonProperty("eligCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EligCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGVISPT_ATHL_AID_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("athlAidInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AthlAidInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGVISPT_COMP_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("compUserId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CompUserId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGVISPT_FULL_NAME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fullName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FullName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGVISPT_SPST_CODE, Lookup lineage reference object : stvspst
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spstCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SpstCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGVISPT_COMP_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("compActivityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CompActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGVISPT_SAEL_CODE, Lookup lineage reference object : stvsael
        /// </summary>
        [Newtonsoft.Json.JsonProperty("saelCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SaelCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGVISPT_SEASON_USED_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seasonUsedInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SeasonUsedInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGVISPT_CURRENT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currentInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CurrentInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGVISPT_STST_CODE, Lookup lineage reference object : stvstst
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ststCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StstCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGVISPT_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Id { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGVISPT_ASTD_CODE, Lookup lineage reference object : stvastd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("astdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AstdCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGVISPT_ACTC_CODE, Lookup lineage reference object : stvactc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("actcCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ActcCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGVISPT_TERM_CODE, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermCode { get; set; } = default!;

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