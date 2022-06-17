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

namespace Ellucian.Generated.BpApi.Ban.BlockScheduleSectionQueryV100GetRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BlockScheduleSectionQueryV100GetRequest
    {
        [Newtonsoft.Json.JsonProperty("queryCrn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? QueryCrn { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssbsectCreditHrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SsbsectCreditHrs { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("xlstGroup", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? XlstGroup { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocTermCode, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocTermCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblocTermCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssbsectSeqNumb", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsbsectSeqNumb { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("multiBlock", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MultiBlock { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvsubj
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssbsectSubjCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsbsectSubjCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocBlckCode, Lookup lineage reference object : stvblck
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocBlckCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblocBlckCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssbsectCrseNumb", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsbsectCrseNumb { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvssts
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssbsectSstsCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsbsectSstsCode { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvschd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssbsectSchdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsbsectSchdCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssbsectSeatsAvail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? SsbsectSeatsAvail { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvcamp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssbsectCampCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsbsectCampCode { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvptrm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssbsectPtrmCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsbsectPtrmCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSRBLCK_APPR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apprInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ApprInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssbsectEnrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? SsbsectEnrl { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssbsectRegFromDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? SsbsectRegFromDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssbsectMaxEnrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? SsbsectMaxEnrl { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssbsectRegToDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? SsbsectRegToDate { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvgmod
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssbsectGmodCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsbsectGmodCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssbsectLinkIdent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsbsectLinkIdent { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssbsectBillHrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SsbsectBillHrs { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssbsectInsmCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsbsectInsmCode { get; set; } = default!;

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