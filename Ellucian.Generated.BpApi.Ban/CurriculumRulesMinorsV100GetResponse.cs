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

namespace Ellucian.Generated.BpApi.Ban.CurriculumRulesMinorsV100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CurriculumRulesMinorsV100GetResponse
    {
        [Newtonsoft.Json.JsonProperty("sorcmnr_ctrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Sorcmnr_ctrl>? Sorcmnr_ctrl { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("sorcmnr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Sorcmnr>? Sorcmnr { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Sorcmnr_ctrl
    {
        /// <summary>
        /// Lineage reference object : cmnrMultipleMsg
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cmnrMultipleMsg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CmnrMultipleMsg { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : minrFrtermDisp, Lookup lineage reference object : sorcmnr,stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minrFrtermDisp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MinrFrtermDisp { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : minrTotermDisp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minrTotermDisp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MinrTotermDisp { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Sorcmnr
    {
        /// <summary>
        /// Lineage reference object : SORCMNR_MAJR_CODE_MINR, Lookup lineage reference object : stvmajr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("majrCodeMinr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MajrCodeMinr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCMNR_REC_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RecInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCMNR_ADM_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("admInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AdmInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCMNR_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCMNR_CMNR_RULE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cmnrRule", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CmnrRule { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCMNR_DAU_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dauInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DauInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCMNR_DISP_WEB_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dispWebInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DispWebInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCMNR_HIS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hisInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HisInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCMNR_EDI_QLFR, Lookup lineage reference object : sorxref
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ediQlfr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EdiQlfr { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("minrDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MinrDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCMNR_EDI_VALUE, Lookup lineage reference object : sorxref
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ediValue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EdiValue { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCMNR_STU_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stuInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StuInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCMNR_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Desc { get; set; } = default!;

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