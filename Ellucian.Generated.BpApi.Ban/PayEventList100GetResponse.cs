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

namespace Ellucian.Generated.BpApi.Ban.PayEventList100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PayEventList100GetResponse
    {
        /// <summary>
        /// Lineage reference object : PHRHIST_ADJ_BY_SEQ_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adjBySeqNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AdjBySeqNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRHIST_ADJS_SEQ_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adjsSeqNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AdjsSeqNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRHIST_TYPE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("typeInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TypeInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("typeDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TypeDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRHIST_GROSS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gross", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Gross { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRHIST_SEQ_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seqNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SeqNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRHIST_YEAR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("year", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Year { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRHIST_ADJS_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adjsDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? AdjsDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRHIST_ADJ_BY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adjByDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? AdjByDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRHIST_DISP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("disp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Disp { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRHIST_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRHIST_PAYNO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payno", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Payno { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRHIST_POSTING_OVERRIDE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("postingOverrideDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? PostingOverrideDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRHIST_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRHIST_PICT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pictCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PictCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("commentInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CommentInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRHIST_NET
        /// </summary>
        [Newtonsoft.Json.JsonProperty("net", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Net { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHRHIST_EVENT_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("eventDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EventDate { get; set; } = default!;

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