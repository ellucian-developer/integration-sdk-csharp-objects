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

namespace Ellucian.Generated.BpApi.Ban.FacultyAssignmentV100PostResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class FacultyAssignmentV100PostResponse
    {
        [Newtonsoft.Json.JsonProperty("sirasgn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Sirasgn>? Sirasgn { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("sirnist", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Sirnist>? Sirnist { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("workload", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Workload>? Workload { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("sirflrt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Sirflrt>? Sirflrt { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Sirasgn
    {
        /// <summary>
        /// Lineage reference object : SIRASGN_PERCENT_RESPONSE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("percentResponse", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double PercentResponse { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("addInst", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddInst { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("compensationAppliedCbox", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CompensationAppliedCbox { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRASGN_WORKLOAD_ADJUST
        /// </summary>
        [Newtonsoft.Json.JsonProperty("workloadAdjust", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? WorkloadAdjust { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("sessHrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SessHrs { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("generatedCredits", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? GeneratedCredits { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRASGN_SUFF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("suff", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Suff { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRASGN_CRN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crn", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Crn { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRASGN_OVER_RIDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("overRide", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OverRide { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("assignFte", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AssignFte { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("subjCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SubjCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRASGN_FCNT_CODE, Lookup lineage reference object : stvfcnt,siricnt,siricnt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fcntCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FcntCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("workload", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Workload { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("calcWorkload", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CalcWorkload { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("compensationExtractedCbox", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CompensationExtractedCbox { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRASGN_POSN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("posn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Posn { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("totalContact", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalContact { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("crseNumb", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CrseNumb { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("seqNumb", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SeqNumb { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("weeklyContact", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? WeeklyContact { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRASGN_CATEGORY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Category { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("instCred", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? InstCred { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRASGN_ASTY_CODE, Lookup lineage reference object : stvasty
        /// </summary>
        [Newtonsoft.Json.JsonProperty("astyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AstyCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRASGN_PERCENT_SESS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("percentSess", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double PercentSess { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRASGN_PRIMARY_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("primaryInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PrimaryInd { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Sirnist
    {
        [Newtonsoft.Json.JsonProperty("nistDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NistDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("compensationAppliedCbox", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CompensationAppliedCbox { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRNIST_TOPS_CODE, Lookup lineage reference object : stvtops
        /// </summary>
        [Newtonsoft.Json.JsonProperty("topsCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TopsCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRNIST_NIST_CODE, Lookup lineage reference object : stvnist
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nistCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NistCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRNIST_FCNT_CODE, Lookup lineage reference object : stvfcnt,siricnt,siricnt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fcntCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FcntCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRNIST_NIST_WORKLOAD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nistWorkload", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NistWorkload { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("compensationExtractedCbox", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CompensationExtractedCbox { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRNIST_POSN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("posn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Posn { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRNIST_SUFF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("suff", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Suff { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRNIST_WEEKLY_HRS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("weeklyHrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? WeeklyHrs { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("fte", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Fte { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRNIST_COLL_CODE, Lookup lineage reference object : stvcoll
        /// </summary>
        [Newtonsoft.Json.JsonProperty("collCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CollCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRNIST_ASTY_CODE, Lookup lineage reference object : stvasty
        /// </summary>
        [Newtonsoft.Json.JsonProperty("astyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AstyCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRNIST_DEPT_CODE, Lookup lineage reference object : stvdept
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deptCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DeptCode { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Workload
    {
        [Newtonsoft.Json.JsonProperty("total", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Total { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("wkldDesc1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WkldDesc1 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("creditHr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CreditHr { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("fte", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Fte { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("instWorkload", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? InstWorkload { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("termContact", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TermContact { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIBINST_WKLD_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sibinstWkldCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SibinstWkldCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("generatedHrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? GeneratedHrs { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("nonInstWorkload", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NonInstWorkload { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("weeklyContactHrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? WeeklyContactHrs { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Sirflrt
    {
        /// <summary>
        /// Lineage reference object : SIRFLRT_CONTACT_HR_LOW_WEEK
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contactHrLowWeek", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ContactHrLowWeek { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRFLRT_TOT_WORKLOAD_LOW
        /// </summary>
        [Newtonsoft.Json.JsonProperty("totWorkloadLow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotWorkloadLow { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRFLRT_FTE_HIGH
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fteHigh", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FteHigh { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("nistInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NistInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRFLRT_WKLD_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wkldCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WkldCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRFLRT_CONTACT_HR_LOW
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contactHrLow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ContactHrLow { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("instInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InstInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRFLRT_CONTACT_HR_HIGH
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contactHrHigh", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ContactHrHigh { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRFLRT_CREDIT_HR_LOW_GEN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creditHrLowGen", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CreditHrLowGen { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRFLRT_CREDIT_HR_HIGH
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creditHrHigh", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CreditHrHigh { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("fteInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FteInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRFLRT_CREDIT_HR_LOW
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creditHrLow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CreditHrLow { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRFLRT_CONTACT_HR_HIGH_WEEK
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contactHrHighWeek", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ContactHrHighWeek { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("totwlInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TotwlInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRFLRT_FTE_LOW
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fteLow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FteLow { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRFLRT_INST_WORKLOAD_LOW
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instWorkloadLow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? InstWorkloadLow { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("genInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GenInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("weekInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WeekInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("totalInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TotalInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("wkldDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WkldDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRFLRT_INST_WORKLOAD_HIGH
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instWorkloadHigh", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? InstWorkloadHigh { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRFLRT_NIST_WORKLOAD_LOW
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nistWorkloadLow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NistWorkloadLow { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRFLRT_NIST_WORKLOAD_HIGH
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nistWorkloadHigh", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NistWorkloadHigh { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRFLRT_TOT_WORKLOAD_HIGH
        /// </summary>
        [Newtonsoft.Json.JsonProperty("totWorkloadHigh", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotWorkloadHigh { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SIRFLRT_CREDIT_HR_HIGH_GEN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creditHrHighGen", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CreditHrHighGen { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("credInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CredInd { get; set; } = default!;

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