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

namespace Ellucian.Generated.BpApi.Ban.TransactionsInProcessStatusV100GetRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TransactionsInProcessStatusV100GetRequest
    {
        [Newtonsoft.Json.JsonProperty("displayDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayDescription { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGRBAKO_DOC_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("docNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DocNum { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displaySumRsvr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DisplaySumRsvr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGRBAKO_PROG_TRAN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("progTran", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProgTran { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displaySumAdjt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DisplaySumAdjt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocAcctCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocAcctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblocAcctCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayStatus { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGRBAKO_ACCT_TRAN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctTran", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctTran { get; set; } = default!;

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
        /// Lineage reference object : FGRBAKO_YTD_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ytdAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? YtdAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocCmtType
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocCmtType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblocCmtType { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGRBAKO_ORGN_TRAN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orgnTran", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrgnTran { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocFundCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocFundCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblocFundCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocFsyrCode, Lookup lineage reference object : ftvfspd,ftvfsyr,ftvfspd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocFsyrCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object KeyblocFsyrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGRBAKO_FUND_TRAN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundTran", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundTran { get; set; } = default!;

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