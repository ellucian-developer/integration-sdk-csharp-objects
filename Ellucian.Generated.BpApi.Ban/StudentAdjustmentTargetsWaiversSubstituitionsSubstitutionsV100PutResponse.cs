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

namespace Ellucian.Generated.BpApi.Ban.StudentAdjustmentTargetsWaiversSubstituitionsSubstitutionsV100PutResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class StudentAdjustmentTargetsWaiversSubstituitionsSubstitutionsV100PutResponse
    {
        [Newtonsoft.Json.JsonProperty("smrsspv", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Smrsspv>? Smrsspv { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("smrssub", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Smrssub>? Smrssub { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Smrsspv
    {
        [Newtonsoft.Json.JsonProperty("programDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProgramDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("maint", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Maint { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMRSSPV_PROGRAM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("program", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Program { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Smrssub
    {
        /// <summary>
        /// Lineage reference object : SMRSSUB_AREA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("area", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Area { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMRSSUB_SUBJ_CODE_REQ, Lookup lineage reference object : stvsubj
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subjCodeReq", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SubjCodeReq { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMRSSUB_ATTR_CODE_SUB, Lookup lineage reference object : stvattr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attrCodeSub", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AttrCodeSub { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMRSSUB_ACTN_CODE, Lookup lineage reference object : stvactn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("actnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ActnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMRSSUB_ATTR_CODE_REQ, Lookup lineage reference object : stvattr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attrCodeReq", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AttrCodeReq { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMRSSUB_CREDITS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("credits", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Credits { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMRSSUB_CRSE_NUMB_REQ
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crseNumbReq", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CrseNumbReq { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("maint", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Maint { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMRSSUB_CRSE_NUMB_SUB
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crseNumbSub", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CrseNumbSub { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMRSSUB_SUBJ_CODE_SUB, Lookup lineage reference object : stvsubj
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subjCodeSub", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SubjCodeSub { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMRSSUB_GROUP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Group { get; set; } = default!;

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