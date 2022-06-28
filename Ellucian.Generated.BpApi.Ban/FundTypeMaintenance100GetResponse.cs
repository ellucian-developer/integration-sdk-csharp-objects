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

namespace Ellucian.Generated.BpApi.Ban.FundTypeMaintenance100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class FundTypeMaintenance100GetResponse
    {
        /// <summary>
        /// Lineage reference object : FTVFTYP_BUDGET_ROLL_PERCENT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budgetRollPercent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BudgetRollPercent { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_CF_TYPE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cfType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CfType { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_LOCN_CODE_CAP_DEF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("locnCodeCapDef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LocnCodeCapDef { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("encumbranceTypeTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EncumbranceTypeTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_BAVL_SEVERITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bavlSeverity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BavlSeverity { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("controlDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ControlDescription { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("organizationDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrganizationDescription { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_EFF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset EffDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_ENC_MULT_YR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("encMultYrInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EncMultYrInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_STATUS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statusInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatusInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_ORGN_CODE_CAP_DEF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orgnCodeCapDef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrgnCodeCapDef { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("encBudgetOverrideInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EncBudgetOverrideInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_DEF_OVERRIDE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("defOverrideInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DefOverrideInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("capFundTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CapFundTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_FTYP_CODE_PRED, Lookup lineage reference object : ftvftyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ftypCodePred", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtypCodePred { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_COMMIT_TYPE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commitType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CommitType { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_BAVL_KEY_ORG
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bavlKeyOrg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BavlKeyOrg { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_RUCL_CODE_ROLL_ENC, Lookup lineage reference object : ftvrucl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ruclCodeRollEnc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RuclCodeRollEnc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_ACCT_CODE_LOSS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCodeLoss", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCodeLoss { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("severityDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SeverityDescription { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("internalFtypTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InternalFtypTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_BUDGET_DISPOSITION
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budgetDisposition", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BudgetDisposition { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_RUCL_CODE_BUDG_CF, Lookup lineage reference object : ftvrucl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ruclCodeBudgCf", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RuclCodeBudgCf { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("budgetTypeTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BudgetTypeTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_DEPR_POST_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deprPostCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DeprPostCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_BUDGET_ROLL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budgetRoll", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BudgetRoll { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_TERM_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TermDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_FTYP_CODE, Lookup lineage reference object : ftvftyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ftypCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FtypCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("accountDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AccountDescription { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_INTERNAL_FTYP_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("internalFtypCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InternalFtypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_FUND_CODE_CAP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundCodeCap", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundCodeCap { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_ACTV_CODE_CAP_DEF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("actvCodeCapDef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ActvCodeCapDef { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_COAS_CODE, Lookup lineage reference object : ftvcoas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coasCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoasCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_BAVL_KEY_FUND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bavlKeyFund", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BavlKeyFund { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_BUDG_CLASSIFICATION
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budgClassification", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BudgClassification { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_DEPR_EXP_EQ_DEF_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deprExpEqDefInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DeprExpEqDefInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_PROG_CODE_CAP_DEF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("progCodeCapDef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProgCodeCapDef { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_BAVL_KEY_ACCT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bavlKeyAcct", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BavlKeyAcct { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_BAVL_KEY_PROG
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bavlKeyProg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BavlKeyProg { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("predFundTypeTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PredFundTypeTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_BAVL_PERIOD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bavlPeriod", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BavlPeriod { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("fundDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundDescription { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_BUDG_CF_PERCENT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budgCfPercent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BudgCfPercent { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("capAccountTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CapAccountTitle { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("programDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProgramDescription { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayNchgDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DisplayNchgDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_ACCT_CODE_CAP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCodeCap", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCodeCap { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVFTYP_ACCT_CODE_GAIN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCodeGain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCodeGain { get; set; } = default!;

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