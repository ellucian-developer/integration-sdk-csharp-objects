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

namespace Ellucian.Generated.BpApi.Ban.OrganizationBudgetStatusV100GetRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OrganizationBudgetStatusV100GetRequest
    {
        /// <summary>
        /// Lineage reference object : keyblocLocnCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocLocnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblocLocnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocCoasCode, Lookup lineage reference object : ftvcoas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocCoasCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string KeyblocCoasCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocAtypCode, Lookup lineage reference object : ftvatyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocAtypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblocAtypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocAcctCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocAcctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblocAcctCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocProgCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocProgCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblocProgCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocAcciCode, Lookup lineage reference object : ftvacci
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocAcciCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblocAcciCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocOrgnCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocOrgnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblocOrgnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocCmtType
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocCmtType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblocCmtType { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocActvCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocActvCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblocActvCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVACCT_ACCT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ftvacctAcctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvacctAcctCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : inclRev
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inclRev", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InclRev { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocFundCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocFundCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblocFundCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocFsyrCode, Lookup lineage reference object : ftvfsyr,ftvfspd,ftvfspd,ftvfspd,ftvfspd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocFsyrCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string KeyblocFsyrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : queryAcct
        /// </summary>
        [Newtonsoft.Json.JsonProperty("queryAcct", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? QueryAcct { get; set; } = default!;

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