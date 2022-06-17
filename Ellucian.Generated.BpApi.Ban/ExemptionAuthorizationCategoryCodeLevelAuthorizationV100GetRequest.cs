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

namespace Ellucian.Generated.BpApi.Ban.ExemptionAuthorizationCategoryCodeLevelAuthorizationV100GetRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ExemptionAuthorizationCategoryCodeLevelAuthorizationV100GetRequest
    {
        /// <summary>
        /// Lineage reference object : exemptionCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exemptionCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? ExemptionCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRECAT_MIN_AMOUNT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MinAmount { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ttvdcatDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TtvdcatDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocTermCode, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocTermCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblocTermCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRECAT_I_E_SOURCE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("iESourceInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IESourceInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRECAT_DCAT_CODE, Lookup lineage reference object : ttvdcat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dcatCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DcatCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRECAT_DCAT_PRIORITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dcatPriority", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double DcatPriority { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRECAT_MAX_AMOUNT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maxAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MaxAmount { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRECAT_PERCENT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("percent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Percent { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBEXPT_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Desc { get; set; } = default!;

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