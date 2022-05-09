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

namespace Ellucian.Generated.BpApi.Ban.PositionDefinitionPositionV100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PositionDefinitionPositionV100PutRequest
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
        /// Lineage reference object : NBBPOSN_SGRP_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sgrpCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SgrpCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_ACCRUE_SENIORITY_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.accrueSeniorityInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaAccrueSeniorityInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.endDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaEndDate { get; set; } = default!;

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

        /// <summary>
        /// Lineage reference object : NBBPOSN_GRADE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.grade", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaGrade { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_EXEMPT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.exemptInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaExemptInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_PROBATION_UNITS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.probationUnits", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaProbationUnits { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_POSN_REPORTS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("posnReports", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PosnReports { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.displayBeginDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaDisplayBeginDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.typeDesc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaTypeDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_ECLS_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.eclsCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaEclsCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.annualSal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaAnnualSal { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.salgrpDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaSalgrpDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_JBLN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jblnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? JblnCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.jblnDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaJblnDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_ECLS_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("eclsCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EclsCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : posn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("posn", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Posn { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_STEP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.step", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaStep { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.pclsDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaPclsDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaTitle { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.salaryLimit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaSalaryLimit { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.bargDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaBargDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_SGRP_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.sgrpCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaSgrpCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_GRADE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grade", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Grade { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.rptToTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaRptToTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_WKSH_CODE, Lookup lineage reference object : ntvwksh
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.wkshCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaWkshCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_JBLN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.jblnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaJblnCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.jobpDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaJobpDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_BUDGET_TYPE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budgetType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BudgetType { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_EXEMPT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exemptInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ExemptInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.statusDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaStatusDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_TABLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.table", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaTable { get; set; } = default!;

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
        /// Lineage reference object : NBBPOSN_BARG_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.bargCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaBargCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.salaryMidpoint", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaSalaryMidpoint { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_APPT_PCT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apptPct", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double ApptPct { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.wkshCodeDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaWkshCodeDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_PCLS_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.pclsCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaPclsCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_POSN_REPORTS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.posnReports", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaPosnReports { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_TABLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("table", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Table { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.salary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaSalary { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_JOBP_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jobpCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? JobpCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_BUDGET_TYPE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.budgetType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaBudgetType { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.eclsDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaEclsDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_STEP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("step", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Step { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_JOBP_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.jobpCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaJobpCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBBPOSN_APPT_PCT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.apptPct", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CriteriaApptPct { get; set; } = default!;

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