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

namespace Ellucian.Generated.BpApi.Ban.BankCodeRuleV100PostRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BankCodeRuleV100PostRequest
    {
        /// <summary>
        /// Lineage reference object : GXVBANK_BANK_CODE, Lookup lineage reference object : gxvbank
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bankCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BankCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GXVBANK_EFF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset EffDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GXVBANK_CURR_CODE, Lookup lineage reference object : gtvcurr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CurrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GXVBANK_ACCT_CODE_CASH
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCodeCash", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCodeCash { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GXVBANK_FUND_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GXVBANK_ACCT_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctNum", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AcctNum { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GXVBANK_STATUS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statusInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatusInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GXVBANK_COAS_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coasCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CoasCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GXVBANK_ACCT_CODE_INTERFUND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCodeInterfund", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCodeInterfund { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GXVBANK_ACCT_NAME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AcctName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GXVBANK_TERM_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TermDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayBankId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DisplayBankId { get; set; } = default!;

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