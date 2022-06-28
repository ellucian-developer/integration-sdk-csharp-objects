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

namespace Ellucian.Generated.BpApi.Ban.GlobalInstitutionFinancialAidOptionsInstitutionDemographics100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GlobalInstitutionFinancialAidOptionsInstitutionDemographics100GetResponse
    {
        [Newtonsoft.Json.JsonProperty("robinst", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Robinst>? Robinst { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rorcamp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Rorcamp>? Rorcamp { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Robinst
    {
        /// <summary>
        /// Lineage reference object : ROBINST_RESCHED_DISB_DATE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reschedDisbDateInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ReschedDisbDateInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_TGRP_CODE, Lookup lineage reference object : rtvtgrp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tgrpCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TgrpCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayEnrRulesDefault", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayEnrRulesDefault { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_ENRR_REMED_DEFAULT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enrrRemedDefault", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EnrrRemedDefault { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_PERIOD_ENABLED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("periodEnabled", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PeriodEnabled { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_UPD_LOCKED_AWARD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("updLockedAwardInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UpdLockedAwardInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_DFLT_MSG_EXP_DAYS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dfltMsgExpDays", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DfltMsgExpDays { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_TRST_CODE_EST, Lookup lineage reference object : rtvtrst
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trstCodeEst", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TrstCodeEst { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayXesHeader", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayXesHeader { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_ENRR_REPEAT_NO_DEFAULT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enrrRepeatNoDefault", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double EnrrRepeatNoDefault { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_STATUS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statusInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatusInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_XES_ALGO_CODE_AIDY, Lookup lineage reference object : rtvalgo,roralgo
        /// </summary>
        [Newtonsoft.Json.JsonProperty("xesAlgoCodeAidy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? XesAlgoCodeAidy { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_AIDY_START_YEAR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aidyStartYear", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double AidyStartYear { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_APPL_DATE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applDateInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApplDateInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_INFO_ACCESS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("infoAccessInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InfoAccessInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_BANINAS_INSTALLED_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("baninasInstalledInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BaninasInstalledInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_REMEDIAL_ALGO_CODE, Lookup lineage reference object : rtvalgo,roralgo
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remedialAlgoCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RemedialAlgoCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_METHOD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("methodInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MethodInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_SAPR_CODE, Lookup lineage reference object : rtvsapr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("saprCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SaprCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_CALC_PC_FM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("calcPcFm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CalcPcFm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_XES_AIDY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("xesAidy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? XesAidy { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_AIDY_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aidyDesc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AidyDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_CURRENT_TERM_CODE, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currentTermCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CurrentTermCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_INFC_CODE, Lookup lineage reference object : rtvinfc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("infcCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InfcCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_AVAIL_OFFER_ONLY_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("availOfferOnlyInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AvailOfferOnlyInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_REMEDIAL_LIMIT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remedialLimit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double RemedialLimit { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_PIVOT_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pivotDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset PivotDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_CTRY_CODE_PHONE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ctryCodePhone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CtryCodePhone { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayYrInCollege", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayYrInCollege { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_FINAID_DIR_NAME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finaidDirName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FinaidDirName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_ARCHIVE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("archiveDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ArchiveDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_APRD_ALGO_CODE_DEF, Lookup lineage reference object : rtvalgo,roralgo
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aprdAlgoCodeDef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AprdAlgoCodeDef { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_ENRR_REMED_NO_DEFAULT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enrrRemedNoDefault", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double EnrrRemedNoDefault { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_SAPR_CODE_EXCEPT, Lookup lineage reference object : rtvsapr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("saprCodeExcept", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SaprCodeExcept { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_TREQ_CODE_APPL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("treqCodeAppl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TreqCodeAppl { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_PBGP_CODE, Lookup lineage reference object : RTVPBGP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pbgpCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PbgpCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_CREATE_ROBUSDF_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("createRobusdfInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CreateRobusdfInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_CURRENT_PERIOD, Lookup lineage reference object : robprds
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currentPeriod", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CurrentPeriod { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_RETENTION_EXPIRED_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("retentionExpiredInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RetentionExpiredInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_APRD_CODE_DEF, Lookup lineage reference object : rtvaprd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aprdCodeDef", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AprdCodeDef { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_AIDY_END_YEAR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aidyEndYear", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double AidyEndYear { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_FM_IM_FLG
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fmImFlg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FmImFlg { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_ENRR_IN_PGRM_DEFAULT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enrrInPgrmDefault", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EnrrInPgrmDefault { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_FINAID_DIR_PHONE_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finaidDirPhoneNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FinaidDirPhoneNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_TERM_CODE_SAP, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCodeSap", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermCodeSap { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_APPL_DATE_SOURCE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applDateSource", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ApplDateSource { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_XES_PRDS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("xesPrds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? XesPrds { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_RETENTION_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("retentionDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? RetentionDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_BUDG_DUR_FM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budgDurFm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BudgDurFm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_YR_IN_COLL_ALGO_CODE, Lookup lineage reference object : rtvalgo,roralgo
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yrInColAlgoCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? YrInColAlgoCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_CREATE_ROBNYUD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("createRobnyudInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CreateRobnyudInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_XES_ALGO_CODE_PRDS, Lookup lineage reference object : rtvalgo,roralgo
        /// </summary>
        [Newtonsoft.Json.JsonProperty("xesAlgoCodePrds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? XesAlgoCodePrds { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_BGRP_CODE, Lookup lineage reference object : rtvbgrp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bgrpCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BgrpCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_FINAID_DIR_PHONE_AREA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finaidDirPhoneArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FinaidDirPhoneArea { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_FM_CODE_INSTALLED_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fmCodeInstalledInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FmCodeInstalledInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_AIDY_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aidyEndDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset AidyEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_ENRR_ESL_DEFAULT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enrrEslDefault", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EnrrEslDefault { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_ENRR_REPEAT_DEFAULT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enrrRepeatDefault", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EnrrRepeatDefault { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_PERIOD_BUDGET_ENABLED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("periodBudgetEnabled", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PeriodBudgetEnabled { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_INTL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intlInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IntlInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_PGRP_CODE, Lookup lineage reference object : rtvpgrp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pgrpCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PgrpCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ROBINST_AIDY_START_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aidyStartDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset AidyStartDate { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Rorcamp
    {
        /// <summary>
        /// Lineage reference object : RORCAMP_MAIL_LINE3_INST_FAA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mailLine3InstFaa", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MailLine3InstFaa { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_STAT_CODE_INST_FAA, Lookup lineage reference object : stvstat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statCodeInstFaa", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatCodeInstFaa { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_FAA_PHONE_AREA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("faaPhoneArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FaaPhoneArea { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_ZIP_INST_FAA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("zipInstFaa", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ZipInstFaa { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_HOUSE_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("houseNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HouseNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_MAIL_CITY_INST_FAA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mailCityInstFaa", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MailCityInstFaa { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayCampDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayCampDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_FAA_FAX_CTRY_CODE, Lookup lineage reference object : stvstat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("faaFaxCtryCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FaaFaxCtryCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_CTRY_CODE_PHONE, Lookup lineage reference object : stvstat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ctryCodePhone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CtryCodePhone { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_MAIL_LINE2_INST_FAA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mailLine2InstFaa", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MailLine2InstFaa { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_MAIL_LINE4_INST_FAA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mailLine4InstFaa", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MailLine4InstFaa { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_FAA_EMAIL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("faaEmail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FaaEmail { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_MAIL_LINE1_INST_FAA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mailLine1InstFaa", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MailLine1InstFaa { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_INST_TYPE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InstType { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_INST_FIN_CONTROL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instFinControl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InstFinControl { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_FAA_FAX_AREA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("faaFaxArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FaaFaxArea { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_FAA_ADMIN_NAME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("faaAdminName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FaaAdminName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_FAA_PHONE_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("faaPhoneNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FaaPhoneNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_CAMP_CODE, Lookup lineage reference object : stvcamp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("campCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CampCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_FAA_PHONE_EXT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("faaPhoneExt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FaaPhoneExt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_FAA_FAX_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("faaFaxNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FaaFaxNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_FAA_FAX_EXT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("faaFaxExt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FaaFaxExt { get; set; } = default!;

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