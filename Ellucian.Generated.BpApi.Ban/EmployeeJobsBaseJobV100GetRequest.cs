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

namespace Ellucian.Generated.BpApi.Ban.EmployeeJobsBaseJobV100GetRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class EmployeeJobsBaseJobV100GetRequest
    {
        /// <summary>
        /// Lineage reference object : NBRBJOB_SALARY_ENCUMBRANCE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("salaryEncumbrance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SalaryEncumbrance { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRBJOB_PROBATION_UNITS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("probationUnits", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ProbationUnits { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRBJOB_IPEDS_REPT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ipedsReptInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IpedsReptInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRBJOB_CONTRACT_TYPE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contractType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContractType { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRBJOB_STEP_INCR_MON
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stepIncrMon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StepIncrMon { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRBJOB_CONTRACT_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contractEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ContractEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRBJOB_COAS_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coasCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CoasCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRBJOB_FUTURE_FRINGE_ENC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("futureFringeEnc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FutureFringeEnc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : posn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("posn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Posn { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRBJOB_CIVIL_SERVICE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("civilServiceInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CivilServiceInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRBJOB_BEGIN_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("beginDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset BeginDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRBJOB_PROBATION_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("probationEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ProbationEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : queryDate
        /// </summary>
        [Newtonsoft.Json.JsonProperty("queryDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset QueryDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : suff
        /// </summary>
        [Newtonsoft.Json.JsonProperty("suff", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Suff { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRBJOB_CONTRACT_BEGIN_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contractBeginDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ContractBeginDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRBJOB_STEP_INCR_DAY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stepIncrDay", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StepIncrDay { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRBJOB_ELIGIBLE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("eligibleDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EligibleDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRBJOB_TOTAL_CONTRACT_HRS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("totalContractHrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalContractHrs { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Id { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRBJOB_ACCRUE_LEAVE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accrueLeaveInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AccrueLeaveInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRBJOB_FUTURE_SALARY_ENC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("futureSalaryEnc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FutureSalaryEnc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRBJOB_PROBATION_BEGIN_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("probationBeginDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ProbationBeginDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRBJOB_TOTAL_ENCUMBRANCE_HRS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("totalEncumbranceHrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalEncumbranceHrs { get; set; } = default!;

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