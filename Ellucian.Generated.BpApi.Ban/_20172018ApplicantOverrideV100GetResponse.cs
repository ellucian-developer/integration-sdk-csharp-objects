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

namespace Ellucian.Generated.BpApi.Ban._20172018ApplicantOverrideV100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class _20172018ApplicantOverrideV100GetResponse
    {
        [Newtonsoft.Json.JsonProperty("rorstat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Rorstat>? Rorstat { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rnrovrd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Rnrovrd>? Rnrovrd { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Rorstat
    {
        [Newtonsoft.Json.JsonProperty("displayImLock", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayImLock { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rcrapp1InfcCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Rcrapp1InfcCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rcrapp1VerificationMsg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Rcrapp1VerificationMsg { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rcrapp1SeqNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Rcrapp1SeqNo { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayVerifyMsgDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayVerifyMsgDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displaySeqNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DisplaySeqNo { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : rtvinfc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("displayInfcCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayInfcCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayLockCurrentInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayLockCurrentInd { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Rnrovrd
    {
        /// <summary>
        /// Lineage reference object : RNROVRD_IRA_KEOGH_PCT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("iraKeoghPct", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? IraKeoghPct { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_AGI
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Agi { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_USE_ANT_YR_INCOME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parUseAntYrIncome", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ParUseAntYrIncome { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_COST_LIV_INDEX
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parCostLivIndex", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ParCostLivIndex { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_USE_ANT_INC_EFM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("useAntIncEfm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UseAntIncEfm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_AGI
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parAgi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ParAgi { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_STU_NUM_IN_COLL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stuNumInColl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? StuNumInColl { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_FAMILY_ASSETS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("familyAssets", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FamilyAssets { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_ACT_FICA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parActFica", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ParActFica { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_CAP_EQT_FACTOR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parCapEqtFactor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ParCapEqtFactor { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_F_SSN_NO_DOB_REJ_OVRD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fSsnNoDobRejOvrd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FSsnNoDobRejOvrd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_HSA_PRE_TAX
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parHsaPreTax", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ParHsaPreTax { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_MED_DENT_EXP_IM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parMedDentExpIm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ParMedDentExpIm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_HOME_VAL_PROJ
        /// </summary>
        [Newtonsoft.Json.JsonProperty("homeValProj", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HomeValProj { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_SKIP_AGE_EXCL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skipAgeExcl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SkipAgeExcl { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_OTH_INC_ALLOW_IM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parOthIncAllowIm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ParOthIncAllowIm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_ALLOW_IM_PC_LOWR_FM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allowImPcLowrFm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AllowImPcLowrFm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_ALLOW_IM_SC_LOWR_FM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allowImScLowrFm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AllowImScLowrFm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_SSN_NO_DOB_REJ_OVRD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssnNoDobRejOvrd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsnNoDobRejOvrd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_M_SSN_NO_DOB_REJ_OVRD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mSsnNoDobRejOvrd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MSsnNoDobRejOvrd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_MED_DENT_EXP_IM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("medDentExpIm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MedDentExpIm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_OTH_INC_ALLOW_IM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("othIncAllowIm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OthIncAllowIm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_OTH_ASSET_IM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("othAssetIm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OthAssetIm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_EXCL_TUIT_DED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parExclTuitDed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ParExclTuitDed { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_CAP_EQT_FACTOR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("capEqtFactor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CapEqtFactor { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_LIMIT_PC_BY_BDGT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limitPcByBdgt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LimitPcByBdgt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_NUM_IN_COLL_EFM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("numInCollEfm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NumInCollEfm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_AGI_OPT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parAgiOpt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ParAgiOpt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_ACT_FICA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("actFica", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ActFica { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_TUIT_EXP_IM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parTuitExpIm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ParTuitExpIm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_CHG_DEPEND_IM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chgDependIm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ChgDependIm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_INV_PROJ
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invProj", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InvProj { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_ADD_BK_HOPE_OPT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parAddBkHopeOpt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ParAddBkHopeOpt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_FSA_HEALTH_CARE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parFsaHealthCare", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ParFsaHealthCare { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_STU_BUDGET
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stuBudget", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? StuBudget { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_CALC_US_TAX_IM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("calcUsTaxIm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CalcUsTaxIm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_NUM_IN_COLL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parNumInColl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ParNumInColl { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PRIOR_YR_PC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("priorYrPc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PriorYrPc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_S_HOME_VAL_PROJ
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sHomeValProj", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SHomeValProj { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_ANTICIPATED_US_TAX
        /// </summary>
        [Newtonsoft.Json.JsonProperty("anticipatedUsTax", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AnticipatedUsTax { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_ANTICIPATED_US_TAX
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parAnticipatedUsTax", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ParAnticipatedUsTax { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_USE_ANT_YR_INCOME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("useAntYrIncome", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UseAntYrIncome { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_NUM_IN_HSLD_EFM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parNumInHsldEfm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ParNumInHsldEfm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_ADD_BK_HOPE_OPT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addBkHopeOpt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddBkHopeOpt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_HOME_VAL_CAP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("homeValCap", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? HomeValCap { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_CAP_INTL_STU_IPA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("capIntlStuIpa", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CapIntlStuIpa { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_HSG_MULT_OVRD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hsgMultOvrd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? HsgMultOvrd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_NON_CUST_PC_OPT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nonCustPcOpt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NonCustPcOpt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_NUM_IN_COLL_EFM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parNumInCollEfm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ParNumInCollEfm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_ST_LOC_TAX_RATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parStLocTaxRate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ParStLocTaxRate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_USE_P_ST_TAX_ALWNCE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("usePStTaxAlwnce", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UsePStTaxAlwnce { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_CALC_PC_FM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("calcPcFm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CalcPcFm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_USE_ANT_INC_EFM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parUseAntIncEfm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ParUseAntIncEfm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_NON_CUST_OPT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nonCustOpt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NonCustOpt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_MIN_SC_FROM_INC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minScFromInc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MinScFromInc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_MIN_PC_FROM_ASSETS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minPcFromAssets", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MinPcFromAssets { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_UNTAX_INC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parUntaxInc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ParUntaxInc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_CHG_DEPEND_FM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chgDependFm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ChgDependFm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_ST_LOC_TAX_RATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stLocTaxRate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? StLocTaxRate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_ASSET_ALLOW_IM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("assetAllowIm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AssetAllowIm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_F_SSN_NO_NAME_REJ_OVRD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fSsnNoNameRejOvrd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FSsnNoNameRejOvrd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_OTH_ASSET_IM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parOthAssetIm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ParOthAssetIm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_P_INDEX_PC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pIndexPc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PIndexPc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_ASSET_ASSESS_PCT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("assetAssessPct", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AssetAssessPct { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_MIN_SC_FROM_ASSETS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minScFromAssets", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MinScFromAssets { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_BUDG_DUR_IM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budgDurIm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BudgDurIm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PRIOR_YR_SC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("priorYrSc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PriorYrSc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_HSG_MULT_OVRD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parHsgMultOvrd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ParHsgMultOvrd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_ACT_ST_LOC_TAX
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parActStLocTax", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ParActStLocTax { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_ASSET_ASSESS_PCT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parAssetAssessPct", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ParAssetAssessPct { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_EXCL_FWS_FR_INC_EXC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exclFwsFrIncExc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ExclFwsFrIncExc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_S_INV_PROJ
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sInvProj", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SInvProj { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_FSA_DEPENDENT_CARE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parFsaDependentCare", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ParFsaDependentCare { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_ZERO_LOSS_OTH
        /// </summary>
        [Newtonsoft.Json.JsonProperty("zeroLossOth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ZeroLossOth { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_CALC_PC_IM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("calcPcIm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CalcPcIm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_ASSET_ALLOW_IM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parAssetAllowIm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ParAssetAllowIm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_EMP_ALLOW
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parEmpAllow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ParEmpAllow { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_UNTAX_INC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("untaxInc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UntaxInc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_CALC_US_TAX_IM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parCalcUsTaxIm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ParCalcUsTaxIm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_M_SSN_NO_NAME_REJ_OVRD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mSsnNoNameRejOvrd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MSsnNoNameRejOvrd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_NUM_IN_HSLD_EFM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("numInHsldEfm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NumInHsldEfm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_STU_EMP_ALLOW
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stuEmpAllow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? StuEmpAllow { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_US_TAX_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("usTaxAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UsTaxAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_ZERO_LOSS_BUS_FARM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("zeroLossBusFarm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ZeroLossBusFarm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_ACT_ST_LOC_TAX
        /// </summary>
        [Newtonsoft.Json.JsonProperty("actStLocTax", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ActStLocTax { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_MIN_SC_FROM_INC_CALC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minScFromIncCalc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MinScFromIncCalc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_US_TAX_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parUsTaxAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ParUsTaxAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_CALC_TCA_W_CC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("calcTcaWCc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CalcTcaWCc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_MIN_PC_FROM_INC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minPcFromInc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MinPcFromInc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_SSN_NO_NAME_REJ_OVRD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssnNoNameRejOvrd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsnNoNameRejOvrd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_BUDG_DUR_FM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budgDurFm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BudgDurFm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_S_INDEX_SC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sIndexSc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SIndexSc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_HOME_VAL_CAP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parHomeValCap", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ParHomeValCap { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_IPA_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parIpaAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ParIpaAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_INC_ASSESS_RATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("incAssessRate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? IncAssessRate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PC_NON_CUST_PAR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pcNonCustPar", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PcNonCustPar { get; set; } = default!;

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