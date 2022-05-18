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

namespace Ellucian.Generated.BpApi.Ban.RoomMealPhoneRateCodeRulesV100PostResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class RoomMealPhoneRateCodeRulesV100PostResponse
    {
        [Newtonsoft.Json.JsonProperty("slarrcd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Slarrcd>? Slarrcd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("slaprcd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Slaprcd>? Slaprcd { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Slarrcd
    {
        /// <summary>
        /// Lineage reference object : SLRLMFE_MAX_CHARGE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("slrlmfeMaxCharge", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double SlrlmfeMaxCharge { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLRLMFE_M_D_T
        /// </summary>
        [Newtonsoft.Json.JsonProperty("slrlmfeMDT", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SlrlmfeMDT { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLRLMFE_MIN_CHARGE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("slrlmfeMinCharge", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double SlrlmfeMinCharge { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLRLMFE_BASE_RATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("slrlmfeBaseRate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double SlrlmfeBaseRate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLRLMFE_DETAIL_CODE, Lookup lineage reference object : tbbdetc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("slrlmfeDetailCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SlrlmfeDetailCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLRLMFE_RATE_CODE, Lookup lineage reference object : stvrrcd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("slrlmfeRateCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SlrlmfeRateCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rrcdDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RrcdDesc { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Slaprcd
    {
        /// <summary>
        /// Lineage reference object : SLRLMFE_MAX_CHARGE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("slrlmfeMaxCharge", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double SlrlmfeMaxCharge { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLRLMFE_M_D_T
        /// </summary>
        [Newtonsoft.Json.JsonProperty("slrlmfeMDT", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SlrlmfeMDT { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLRLMFE_MIN_CHARGE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("slrlmfeMinCharge", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double SlrlmfeMinCharge { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLRLMFE_BASE_RATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("slrlmfeBaseRate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double SlrlmfeBaseRate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLRLMFE_DETAIL_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("slrlmfeDetailCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SlrlmfeDetailCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLRLMFE_RATE_CODE, Lookup lineage reference object : stvprcd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("slrlmfeRateCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SlrlmfeRateCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("prcdDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PrcdDesc { get; set; } = default!;

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