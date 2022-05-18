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

namespace Ellucian.Generated.BpApi.Ban.FinancialAidRecordMaintenanceV100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class FinancialAidRecordMaintenanceV100GetResponse
    {
        [Newtonsoft.Json.JsonProperty("summary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Summary>? Summary { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rorstat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Rorstat>? Rorstat { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rprawrd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Rprawrd>? Rprawrd { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Summary
    {
        /// <summary>
        /// Lineage reference object : dispsumImBudgetAmt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dispsumImBudgetAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? DispsumImBudgetAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : dispsumResourceAmt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dispsumResourceAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? DispsumResourceAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : dispsumBudgetGroup
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dispsumBudgetGroup", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? DispsumBudgetGroup { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : dispsumCrossoverPellAward
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dispsumCrossoverPellAward", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? DispsumCrossoverPellAward { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : dispsumFmGrossNeed
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dispsumFmGrossNeed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? DispsumFmGrossNeed { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : dispsumOfferAmt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dispsumOfferAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? DispsumOfferAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : dispsumFmUnmetNeed
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dispsumFmUnmetNeed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? DispsumFmUnmetNeed { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : dispsumCrossoverAidyCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dispsumCrossoverAidyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? DispsumCrossoverAidyCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : dispsumImEfc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dispsumImEfc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? DispsumImEfc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : dispsumPellBudgetAmt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dispsumPellBudgetAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? DispsumPellBudgetAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : dispsumBudgetGroupInd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dispsumBudgetGroupInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? DispsumBudgetGroupInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : dispsumFmBudgetAmt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dispsumFmBudgetAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? DispsumFmBudgetAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : dispsumPellEfc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dispsumPellEfc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? DispsumPellEfc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : dispsumBbayAwardedInd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dispsumBbayAwardedInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? DispsumBbayAwardedInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : dispsumAprdCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dispsumAprdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? DispsumAprdCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : dispsumImGrossNeed
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dispsumImGrossNeed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? DispsumImGrossNeed { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : dispsumAprdCodePell
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dispsumAprdCodePell", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? DispsumAprdCodePell { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : dispsumFmEfc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dispsumFmEfc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? DispsumFmEfc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : dispsumImUnmetNeed
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dispsumImUnmetNeed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? DispsumImUnmetNeed { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Rorstat
    {
        /// <summary>
        /// Lineage reference object : RORSTAT_HIGH_PELL_LEU_FLAG
        /// </summary>
        [Newtonsoft.Json.JsonProperty("highPellLeuFlag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HighPellLeuFlag { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_DEP_NO_PAR_DATA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("depNoParData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DepNoParData { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_FORMER_HEAL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("formerHealInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FormerHealInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_PGRP_CODE_LOCK_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pgrpCodeLockInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PgrpCodeLockInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_ADDL_STFD_ELIG_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addlStfdEligInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddlStfdEligInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_PREP_OR_TEACH_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prepOrTeachInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PrepOrTeachInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_SS_INFO_ACCESS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssInfoAccessInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsInfoAccessInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_AWD_LTR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("awdLtrInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AwdLtrInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_POST_BA_PELL_OVRD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("postBaPellOvrd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PostBaPellOvrd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayInfoAccessInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayInfoAccessInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_OVRDE_SAYR_SEQ_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ovrdeSayrSeqNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OvrdeSayrSeqNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_BORROWER_BASED_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("borrowerBasedCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BorrowerBasedCde { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("dispRorstatOvrdeSayrCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DispRorstatOvrdeSayrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_OVRDE_SAYR_CODE, Lookup lineage reference object : ROBSAYR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ovrdeSayrCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OvrdeSayrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_PELL_ORIG_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pellOrigInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PellOrigInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_OVRDE_SAYR_ALGO_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ovrdeSayrAlgoCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OvrdeSayrAlgoCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayDependStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayDependStatus { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_PGRP_CODE, Lookup lineage reference object : rtvpgrp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pgrpCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PgrpCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_ADDL_PELL_ELIG_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addlPellEligInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddlPellEligInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_PCKG_COMP_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pckgCompDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? PckgCompDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayRtvpgrpDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayRtvpgrpDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_PGRP_LOCK_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pgrpLockInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PgrpLockInd { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Rprawrd
    {
        /// <summary>
        /// Lineage reference object : RPRAWRD_AWST_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("awstCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AwstCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRAWRD_ACCEPT_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acceptAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AcceptAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRAWRD_FUND_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayMemautAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DisplayMemautAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRAWRD_INFO_ACCESS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("infoAccessInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InfoAccessInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRAWRD_SYS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sysInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SysInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRAWRD_PAID_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("paidAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PaidAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRAWRD_LOCK_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lockInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LockInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayDeccanAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DisplayDeccanAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RPRAWRD_OFFER_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offerAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OfferAmt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("fundDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundDescription { get; set; } = default!;

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