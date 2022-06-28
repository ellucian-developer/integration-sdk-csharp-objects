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

namespace Ellucian.Generated.BpApi.Ban.AccountCodeMaintenance100QapiPost
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AccountCodeMaintenance100QapiPost
    {
        /// <summary>
        /// Lineage reference object : FTVACCT_COAS_CODE, Lookup lineage reference object : ftvcoas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coasCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CoasCode { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : ftvityp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("incomeTypeCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IncomeTypeCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVACCT_STATUS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statusInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatusInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVACCT_ACCT_CLASS_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctClassCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctClassCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVACCT_ACCT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVACCT_ACCT_CODE_ASSET
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCodeAsset", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCodeAsset { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVACCT_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Title { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVACCT_ACCT_CODE_DEPR_ACCUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCodeDeprAccum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCodeDeprAccum { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVACCT_EFF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EffDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVACCT_ACCT_CODE_DEPR_EXP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCodeDeprExp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCodeDeprExp { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVACCT_TERM_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TermDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVACCT_ACCT_CODE_POOL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCodePool", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCodePool { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVACCT_ACCT_CODE_FRINGE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCodeFringe", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCodeFringe { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVACCT_ACCT_CODE_PRED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCodePred", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCodePred { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVACCT_FRINGE_PCT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fringePct", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FringePct { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVACCT_DATA_ENTRY_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dataEntryInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DataEntryInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVACCT_NORMAL_BAL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("normalBal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NormalBal { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVACCT_ATYP_CODE, Lookup lineage reference object : ftvatyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("atypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AtypCode { get; set; } = default!;

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