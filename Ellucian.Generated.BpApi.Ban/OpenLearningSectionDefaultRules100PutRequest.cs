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

namespace Ellucian.Generated.BpApi.Ban.OpenLearningSectionDefaultRules100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OpenLearningSectionDefaultRules100PutRequest
    {
        /// <summary>
        /// Lineage reference object : SORRSTS_USAGE_CUTOFF_PCT_FROM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("usageCutoffPctFrom", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UsageCutoffPctFrom { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBODTE_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBODTE_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaUserId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORRSTS_USAGE_CUTOFF_PCT_FROM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.usageCutoffPctFrom", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaUsageCutoffPctFrom { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBODTE_CAMP_CODE, Lookup lineage reference object : stvcamp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.campCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCampCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBODTE_REG_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("regEndDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset RegEndDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.campCodeDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCampCodeDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBODTE_CENSUS_DATE_TWO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("censusDateTwo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CensusDateTwo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBODTE_CENSUS_DATE_TWO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.censusDateTwo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaCensusDateTwo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBODTE_COLL_CODE, Lookup lineage reference object : stvcoll
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.collCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCollCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBODTE_DEPT_CODE, Lookup lineage reference object : stvdept
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.deptCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaDeptCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORRSTS_RSTS_CODE, Lookup lineage reference object : stvrsts
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.rstsCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaRstsCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORRFND_FEE_REFUND_PCT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.feeRefundPct", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaFeeRefundPct { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORRFND_REFUND_PCT_COMPLETE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.refundPctComplete", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CriteriaRefundPctComplete { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORRFND_REFUND_PCT_COMPLETE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refundPctComplete", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double RefundPctComplete { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBODTE_REG_START_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.regStartDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CriteriaRegStartDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBODTE_SCHD_CODE, Lookup lineage reference object : stvschd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SchdCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORRSTS_RSTS_CODE, Lookup lineage reference object : stvrsts
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rstsCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RstsCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBODTE_CAMP_CODE, Lookup lineage reference object : stvcamp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("campCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CampCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.collCodeDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCollCodeDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.schdCodeDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaSchdCodeDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBODTE_REG_START_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("regStartDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset RegStartDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBODTE_OVERRIDE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.overrideInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaOverrideInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBODTE_OVERRIDE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("overrideInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OverrideInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORRFND_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.sorrfndActivityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaSorrfndActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORRFND_EXTENSION_REFUND_PCT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.extensionRefundPct", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaExtensionRefundPct { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORRFND_TUITION_REFUND_PCT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tuitionRefundPct", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TuitionRefundPct { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBODTE_CENSUS_DATE_ONE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("censusDateOne", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CensusDateOne { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBODTE_CENSUS_DATE_ONE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.censusDateOne", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CriteriaCensusDateOne { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblckTermCode, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckTermCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblckTermCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBODTE_INSM_CODE, Lookup lineage reference object : gtvinsm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("insmCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InsmCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORRFND_TUITION_REFUND_PCT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.tuitionRefundPct", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaTuitionRefundPct { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORRSTS_USAGE_CUTOFF_PCT_TO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("usageCutoffPctTo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UsageCutoffPctTo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBODTE_SCHD_CODE, Lookup lineage reference object : stvschd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.schdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaSchdCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBODTE_REG_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.regEndDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CriteriaRegEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORRSTS_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.sorrstsUserId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaSorrstsUserId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORRSTS_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.sorrstsActivityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaSorrstsActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocTermCodedef, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocTermCodeDef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblocTermCodeDef { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.insmCodeDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaInsmCodeDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORRSTS_USAGE_CUTOFF_PCT_TO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.usageCutoffPctTo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaUsageCutoffPctTo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORRFND_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.sorrfndUserId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaSorrfndUserId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBODTE_COLL_CODE, Lookup lineage reference object : stvcoll
        /// </summary>
        [Newtonsoft.Json.JsonProperty("collCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CollCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORRFND_EXTENSION_REFUND_PCT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extensionRefundPct", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExtensionRefundPct { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBODTE_DEPT_CODE, Lookup lineage reference object : stvdept
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deptCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DeptCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORRFND_FEE_REFUND_PCT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("feeRefundPct", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FeeRefundPct { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBODTE_INSM_CODE, Lookup lineage reference object : gtvinsm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.insmCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaInsmCode { get; set; } = default!;

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