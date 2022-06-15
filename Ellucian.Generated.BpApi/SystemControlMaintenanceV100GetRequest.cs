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

namespace Ellucian.Generated.BpApi.Ban.SystemControlMaintenanceV100GetRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SystemControlMaintenanceV100GetRequest
    {
        /// <summary>
        /// Lineage reference object : FOBSYSC_ACCT_CODE_COAS_DUE_TO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCodeCoasDueTo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AcctCodeCoasDueTo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBSYSC_NCHG_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nchgDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? NchgDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBSYSC_RUCL_SECURITY_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ruclSecurityInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RuclSecurityInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBSYSC_WBUD_TRACK_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wbudTrackInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WbudTrackInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBSYSC_MULTIPLE_FB_ACCT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("multipleFbAcctInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MultipleFbAcctInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBSYSC_EFF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EffDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBSYSC_EDIT_DEFER_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("editDeferInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EditDeferInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBSYSC_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBSYSC_FUND_ORG_SECURITY_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundOrgSecurityInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundOrgSecurityInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBSYSC_CONSOL_POST_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("consolPostInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ConsolPostInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBSYSC_STATUS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statusInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatusInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBSYSC_ACCT_CODE_COAS_DUE_FRM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCodeCoasDueFrm", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AcctCodeCoasDueFrm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBSYSC_FEDERAL_EMPLOYER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("federalEmployerId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FederalEmployerId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBSYSC_WBUD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wbudInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WbudInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBSYSC_TERM_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TermDate { get; set; } = default!;

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