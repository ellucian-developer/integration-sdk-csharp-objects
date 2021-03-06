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

namespace Ellucian.Generated.BpApi.Ban.BatchPostingTypeCodes100GetRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BatchPostingTypeCodes100GetRequest
    {
        /// <summary>
        /// Lineage reference object : RTVPTYP_DATE_REQ_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dateReqInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DateReqInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVPTYP_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVPTYP_COMMENT_RJCT_TYPE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commentRjctTypeInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CommentRjctTypeInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVPTYP_MISC_CDE_2_REQ_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("miscCde2ReqInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MiscCde2ReqInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVPTYP_MISC_CDE_REQ_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("miscCdeReqInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MiscCdeReqInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVPTYP_COMMENT_RJCT_CDE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commentRjctCdeInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CommentRjctCdeInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVPTYP_STATUS_REQ_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statusReqInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StatusReqInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVPTYP_TERM_REQ_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termReqInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TermReqInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVPTYP_PERIOD_REQ_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("periodReqInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PeriodReqInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVPTYP_POST_CODE_REQ_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("postCodeReqInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PostCodeReqInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVPTYP_AMT_REQ_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amtReqInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AmtReqInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RTVPTYP_DESC
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