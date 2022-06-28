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

namespace Ellucian.Generated.BpApi.Ban.LifeEventChangeRules100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class LifeEventChangeRules100GetResponse
    {
        [Newtonsoft.Json.JsonProperty("ptrlfsd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Ptrlfsd>? Ptrlfsd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ptrlfch", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Ptrlfch>? Ptrlfch { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ptrlfbd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Ptrlfbd>? Ptrlfbd { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Ptrlfsd
    {
        [Newtonsoft.Json.JsonProperty("bdocDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BdocDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRLFSD_BDOC_CODE, Lookup lineage reference object : PTVBDOC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bdocCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BdocCode { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Ptrlfch
    {
        /// <summary>
        /// Lineage reference object : PTRLFCH_WEB_CVG_UPD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webCvgUpdInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebCvgUpdInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRLFCH_WEB_CVG_SEL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webCvgSelInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebCvgSelInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRLFCH_WEB_EMPR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webEmprInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebEmprInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("bdpgDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BdpgDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRLFCH_WEB_CVG_INS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webCvgInsInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebCvgInsInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRLFCH_BDPG_CODE, Lookup lineage reference object : PTVBDPG
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bdpgCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BdpgCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRLFCH_PRIORITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("priority", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Priority { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Ptrlfbd
    {
        /// <summary>
        /// Lineage reference object : PTRLFBD_WEB_CVG_UPD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webCvgUpdInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebCvgUpdInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRLFBD_WEB_CVG_SEL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webCvgSelInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebCvgSelInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRLFBD_WEB_EMPR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webEmprInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebEmprInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRLFBD_BDCA_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bdcaCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BdcaCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRLFBD_WEB_BALC_UPD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webBalcUpdInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebBalcUpdInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRLFBD_WEB_CVG_INS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webCvgInsInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebCvgInsInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("bdcaDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BdcaDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRLFBD_ENRL_BEGIN_DATE_METHOD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enrlBeginDateMethod", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EnrlBeginDateMethod { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRLFBD_WEB_BALC_SEL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webBalcSelInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebBalcSelInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRLFBD_WEB_BALC_INS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webBalcInsInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebBalcInsInd { get; set; } = default!;

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