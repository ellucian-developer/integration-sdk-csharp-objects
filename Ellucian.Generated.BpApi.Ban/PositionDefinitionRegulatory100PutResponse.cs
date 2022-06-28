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

namespace Ellucian.Generated.BpApi.Ban.PositionDefinitionRegulatory100PutResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PositionDefinitionRegulatory100PutResponse
    {
        /// <summary>
        /// Lineage reference object : NBBPOSN_PROBATION_UNITS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("probationUnits", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ProbationUnits { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_BARG_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bargCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BargCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_ECIP_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ecipCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EcipCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_SGRP_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sgrpCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SgrpCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_ACCRUE_SENIORITY_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accrueSeniorityInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AccrueSeniorityInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_PCLS_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pclsCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PclsCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("salary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Salary { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("jobpDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? JobpDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_CALIF_TYPE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("califType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CalifType { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_POSN_REPORTS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("posnReports", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PosnReports { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_JBLN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jblnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? JblnCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ecipDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EcipDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("bargDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BargDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("pclsDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PclsDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("salgrpDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SalgrpDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("salaryMidpoint", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SalaryMidpoint { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_ECLS_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("eclsCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EclsCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_PNOC_CODE, Lookup lineage reference object : ntvpnoc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pnocCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PnocCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("annualSal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AnnualSal { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("jblnDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? JblnDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("salaryLimit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SalaryLimit { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rptToTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RptToTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_GRADE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grade", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Grade { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("cipcDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CipcDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_CHANGE_DATE_TIME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("changeDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ChangeDateTime { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_BUDGET_TYPE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budgetType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BudgetType { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("dottDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DottDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_EXEMPT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exemptInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ExemptInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("typeDesc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TypeDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("pfocDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PfocDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_WKSH_CODE, Lookup lineage reference object : ntvwksh
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wkshCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WkshCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Title { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_ESOC_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("esocCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EsocCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_CIPC_CODE, Lookup lineage reference object : stvcipc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cipcCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CipcCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_APPT_PCT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apptPct", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double ApptPct { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_TABLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("table", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Table { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("pgrpDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PgrpDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayBeginDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DisplayBeginDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("statusDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatusDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_DOTT_CODE, Lookup lineage reference object : ntvdott
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dottCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DottCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_PFOC_CODE, Lookup lineage reference object : ntvpfoc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pfocCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PfocCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("wkshCodeDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WkshCodeDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("pnocDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PnocDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("esocDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EsocDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_JOBP_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jobpCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? JobpCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("eclsDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EclsDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_COMMENT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("comment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Comment { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_PGRP_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pgrpCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PgrpCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_STEP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("step", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Step { get; set; } = default!;

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