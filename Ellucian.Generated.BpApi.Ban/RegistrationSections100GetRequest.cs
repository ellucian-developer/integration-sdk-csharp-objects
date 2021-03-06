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

namespace Ellucian.Generated.BpApi.Ban.RegistrationSections100GetRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class RegistrationSections100GetRequest
    {
        /// <summary>
        /// Lineage reference object : SFVSECM_END_TIME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.endTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaEndTime { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.blockInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaBlockInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFVSECM_BEGIN_TIME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.beginTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaBeginTime { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.querySeqNumb", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaQuerySeqNumb { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFVSECM_WAIT_COUNT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.waitCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaWaitCount { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvschd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.querySchdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaQuerySchdCode { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvptrm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.queryPtrmCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaQueryPtrmCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFVSECM_SEATS_AVAIL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.seatsAvail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaSeatsAvail { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvssts
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.querySstsCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaQuerySstsCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.queryCrn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaQueryCrn { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.queryCrseNumb", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaQueryCrseNumb { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.queryLinkIdent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaQueryLinkIdent { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvcamp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.queryCampCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaQueryCampCode { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvsubj
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.querySubjCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaQuerySubjCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.queryXlstGroup", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaQueryXlstGroup { get; set; } = default!;

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