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

namespace Ellucian.Generated.BpApi.Ban.BenefitOrDeductionGroupingRule100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BenefitOrDeductionGroupingRule100GetResponse
    {
        [Newtonsoft.Json.JsonProperty("ptrbdsg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Ptrbdsg>? Ptrbdsg { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ptrbdpg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Ptrbdpg>? Ptrbdpg { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ptrbdgm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Ptrbdgm>? Ptrbdgm { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Ptrbdsg
    {
        /// <summary>
        /// Lineage reference object : PTRBDSG_WEB_CVG_UPD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webCvgUpdInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebCvgUpdInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDSG_WEB_CVG_SEL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webCvgSelInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebCvgSelInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDSG_WEB_EMPR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webEmprInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebEmprInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDSG_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDSG_WEB_OPEN_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webOpenInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebOpenInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDSG_WEB_SEL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webSelInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebSelInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDSG_WEB_CVG_INS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webCvgInsInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebCvgInsInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDSG_WEB_UPD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webUpdInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebUpdInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDSG_WEB_CVG_DEL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webCvgDelInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebCvgDelInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDSG_WEB_INS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webInsInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebInsInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDSG_WEB_DEL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webDelInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebDelInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDSG_DESC
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

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Ptrbdpg
    {
        /// <summary>
        /// Lineage reference object : PTRBDPG_WEB_CVG_UPD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webCvgUpdInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebCvgUpdInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDPG_WEB_CVG_SEL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webCvgSelInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebCvgSelInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDPG_WEB_EMPR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webEmprInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebEmprInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDPG_WEB_OPEN_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webOpenInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebOpenInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDPG_WEB_SEL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webSelInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebSelInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDPG_WEB_CVG_INS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webCvgInsInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebCvgInsInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDPG_WEB_UPD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webUpdInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebUpdInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDPG_WEB_CVG_DEL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webCvgDelInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebCvgDelInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDPG_WEB_INS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webInsInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebInsInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDPG_PRIORITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("priority", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Priority { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDPG_WEB_DEL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webDelInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebDelInd { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Ptrbdgm
    {
        /// <summary>
        /// Lineage reference object : PTRBDGM_WEB_CVG_SEL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webCvgSelInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebCvgSelInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDGM_WEB_EMPR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webEmprInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebEmprInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDGM_BDCA_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bdcaCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BdcaCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDGM_WEB_BALC_DEL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webBalcDelInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebBalcDelInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDGM_WEB_OPEN_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webOpenInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebOpenInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDGM_WEB_CVG_INS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webCvgInsInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebCvgInsInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDGM_WEB_UPD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webUpdInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebUpdInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDGM_WEB_CVG_UPD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webCvgUpdInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebCvgUpdInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDGM_WEB_BALC_UPD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webBalcUpdInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebBalcUpdInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDGM_WEB_SEL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webSelInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebSelInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("bdcaDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BdcaDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDGM_WEB_CVG_DEL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webCvgDelInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebCvgDelInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDGM_WEB_INS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webInsInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebInsInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDGM_WEB_BALC_SEL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webBalcSelInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebBalcSelInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDGM_WEB_DEL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webDelInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebDelInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDGM_WEB_BALC_INS_IND
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