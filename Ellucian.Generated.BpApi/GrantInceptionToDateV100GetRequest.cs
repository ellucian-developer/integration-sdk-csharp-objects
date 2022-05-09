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

namespace Ellucian.Generated.BpApi.Ban.GrantInceptionToDateV100GetRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GrantInceptionToDateV100GetRequest
    {
        /// <summary>
        /// Lineage reference object : keyblocYearTo
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocYearTo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblocYearTo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocAtypCode, Lookup lineage reference object : ftvatyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocAtypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblocAtypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocMonthTo
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocMonthTo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblocMonthTo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRVGBAL_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Title { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocProgCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocProgCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblocProgCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocAcciCode, Lookup lineage reference object : ftvacci
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocAcciCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblocAcciCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocOrgnCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocOrgnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblocOrgnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : excludeAcctInd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("excludeAcctInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? ExcludeAcctInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : revenueAcctInd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("revenueAcctInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? RevenueAcctInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : hier
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Hier { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocYearFrom
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocYearFrom", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblocYearFrom { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocLocnCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocLocnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblocLocnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocCoasCode, Lookup lineage reference object : ftvcoas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocCoasCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblocCoasCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRVGBAL_INT_ATYP_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intAtypDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IntAtypDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRVGBAL_ADJ_BUD_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adjBudAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AdjBudAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocAcctCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocAcctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblocAcctCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : fundSummary
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundSummary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? FundSummary { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRVGBAL_ACCT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocAcctSummary
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocAcctSummary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblocAcctSummary { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : sponsorAcctInd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sponsorAcctInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? SponsorAcctInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRVGBAL_AVAIL_BAL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("availBal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AvailBal { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocMonthFrom
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocMonthFrom", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblocMonthFrom { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRVGBAL_YTD_ACTV_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ytdActvAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? YtdActvAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocActvCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocActvCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblocActvCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocGrntCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocGrntCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblocGrntCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocGrntYr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocGrntYr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblocGrntYr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRVGBAL_CMT_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cmtAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CmtAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocFundCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocFundCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblocFundCode { get; set; } = default!;

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