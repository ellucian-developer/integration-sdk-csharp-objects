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

namespace Ellucian.Generated.BpApi.Ban.ProjectMaintenanceV100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ProjectMaintenanceV100PutRequest
    {
        /// <summary>
        /// Lineage reference object : FTVPROJ_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVPROJ_PROG_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.progCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaProgCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVPROJ_LOCN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("locnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LocnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVPROJ_MEMO_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.memoInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaMemoInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVPROJ_TERM_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.termDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaTermDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVPROJ_ORGN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orgnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrgnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVPROJ_MEMO_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("memoInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MemoInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVPROJ_EFF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset EffDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVPROJ_ACCI_CODE, Lookup lineage reference object : ftvacci
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.acciCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaAcciCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVPROJ_FUND_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVPROJ_PROG_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("progCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProgCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVPROJ_COAS_CODE, Lookup lineage reference object : ftvcoas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.coasCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaCoasCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVPROJ_ACTV_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("actvCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ActvCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVPROJ_EFF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.effDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CriteriaEffDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : projDesc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("projDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? ProjDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVPROJ_FUND_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.fundCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaFundCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVPROJ_LOCN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.locnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaLocnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVPROJ_ACCT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.acctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaAcctCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVPROJ_ACCI_CODE, Lookup lineage reference object : ftvacci
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acciCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcciCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVPROJ_ACTV_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.actvCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaActvCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVPROJ_ACCT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ftmprojProjCode, Lookup lineage reference object : ftvproj
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ftmprojProjCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? FtmprojProjCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVPROJ_ORGN_CODE_PROJ
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.orgnCodeProj", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaOrgnCodeProj { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVPROJ_ORGN_CODE_PROJ
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orgnCodeProj", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrgnCodeProj { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVPROJ_TERM_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TermDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVPROJ_ORGN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.orgnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaOrgnCode { get; set; } = default!;

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