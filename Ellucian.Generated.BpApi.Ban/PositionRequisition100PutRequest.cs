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

namespace Ellucian.Generated.BpApi.Ban.PositionRequisition100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PositionRequisition100PutRequest
    {
        /// <summary>
        /// Lineage reference object : PABREQU_REQS_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reqsCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReqsCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PABREQU_HIRE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hireDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? HireDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PABREQU_RELOC_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("relocInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RelocInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PABREQU_APPL_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ApplDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("apprId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ApprId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : reqNo
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reqNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ReqNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PABREQU_COAS_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coasCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CoasCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PABREQU_ORGN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orgnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrgnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PABREQU_POSN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("posn", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Posn { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PABREQU_APPR_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apprDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ApprDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PABREQU_VACY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vacyDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? VacyDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PABREQU_CLOSE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("closeDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CloseDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PABREQU_POST_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("postDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? PostDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("recrId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RecrId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PABREQU_OPEN_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? OpenDate { get; set; } = default!;

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