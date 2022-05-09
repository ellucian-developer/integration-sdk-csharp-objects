//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
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

namespace Ellucian.Generated.BpApi.Ban.StudentRegistrationPermitOverrideV100PostResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class StudentRegistrationPermitOverrideV100PostResponse
    {
        [Newtonsoft.Json.JsonProperty("sfrsrpo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Sfrsrpo>? Sfrsrpo { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("sfvstum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Sfvstum>? Sfvstum { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Sfrsrpo
    {
        /// <summary>
        /// Lineage reference object : SFRSRPO_CRSE_NUMB
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crseNumb", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CrseNumb { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSRPO_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rovrDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RovrDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSRPO_SUBJ_CODE, Lookup lineage reference object : stvsubj
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subjCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SubjCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSRPO_SEQ_NUMB
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seqNumb", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SeqNumb { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSRPO_ROVR_CODE, Lookup lineage reference object : stvrovr,sfrrovr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rovrCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RovrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSRPO_USER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? User { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRSRPO_CRN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Crn { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Sfvstum
    {
        [Newtonsoft.Json.JsonProperty("squeryLinkIdent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SqueryLinkIdent { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("squeryCrseNumb", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SqueryCrseNumb { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("squerySstsCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SquerySstsCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("squeryCampCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SqueryCampCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFVSTUM_ERROR_FLAG
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errorFlag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ErrorFlag { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("squeryXlstGroup", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SqueryXlstGroup { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("daysCode1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DaysCode1 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("daysCode2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DaysCode2 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("daysCode3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DaysCode3 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("daysCode4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DaysCode4 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("daysCode5", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DaysCode5 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("daysCode6", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DaysCode6 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("daysCode7", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DaysCode7 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFVSTUM_RSTS_CODE, Lookup lineage reference object : stvrsts
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rstsCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RstsCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("squerySubjCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SquerySubjCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("squeryCrn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SqueryCrn { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFVSTUM_BEGIN_TIME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("beginTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BeginTime { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("squeryPtrmCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SqueryPtrmCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("squerySeqNumb", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SquerySeqNumb { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("squeryWaitCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SqueryWaitCount { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stumBlockInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StumBlockInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("squerySeatsAvail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SquerySeatsAvail { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("squeryStudyPath", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SqueryStudyPath { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFVSTUM_END_TIME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EndTime { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("squerySchdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SquerySchdCode { get; set; } = default!;

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