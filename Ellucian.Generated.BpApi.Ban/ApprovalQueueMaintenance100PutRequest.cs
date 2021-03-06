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

namespace Ellucian.Generated.BpApi.Ban.ApprovalQueueMaintenance100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ApprovalQueueMaintenance100PutRequest
    {
        /// <summary>
        /// Lineage reference object : FTVAPPQ_NEXT_QUEUE_ID, Lookup lineage reference object : ftvappq
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.nextQueueId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaNextQueueId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVAPPQ_DESCRIPTION
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaDescription { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVAPPQ_DESCRIPTION
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FORAQUS_QUEUE_LEVEL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("queueLevel", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double QueueLevel { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FORAQUS_USER_ID_APPR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userIdAppr", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UserIdAppr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVAPPQ_QUEUE_LIMIT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.queueLimit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaQueueLimit { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVAPPQ_QUEUE_ID, Lookup lineage reference object : ftvappq
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.queueId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaQueueId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FORAQUS_QUEUE_LEVEL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.queueLevel", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CriteriaQueueLevel { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVAPPQ_QUEUE_LIMIT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("queueLimit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? QueueLimit { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FORAQUS_USER_ID_APPR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.userIdAppr", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaUserIdAppr { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("effDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset EffDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVAPPQ_NEXT_QUEUE_ID, Lookup lineage reference object : ftvappq
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nextQueueId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NextQueueId { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("termDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TermDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FORAQUS_QUEUE_LIMIT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("foraqusQueueLimit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ForaqusQueueLimit { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FORAQUS_QUEUE_LIMIT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.foraqusQueueLimit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaForaqusQueueLimit { get; set; } = default!;

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