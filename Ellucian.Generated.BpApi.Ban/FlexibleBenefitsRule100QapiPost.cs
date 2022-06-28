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

namespace Ellucian.Generated.BpApi.Ban.FlexibleBenefitsRule100QapiPost
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class FlexibleBenefitsRule100QapiPost
    {
        /// <summary>
        /// Lineage reference object : PTRFBEN_BDCA_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bdcaCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BdcaCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRFBEN_PLAN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("planCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PlanCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRFBEN_FSA_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fsaInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FsaInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRFBEN_FSA_GRACE_PERIOD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fsaGracePeriodInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FsaGracePeriodInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRFBEN_AVAIL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("availInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AvailInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRFBEN_DEDN_FREQ
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dednFreq", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DednFreq { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRFBEN_PREM_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("premAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PremAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRFBEN_FLEX_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("flexAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FlexAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRFBEN_EMPL_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("emplAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? EmplAmt { get; set; } = default!;

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