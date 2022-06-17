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

namespace Ellucian.Generated.BpApi.Ban.OrganizationCodeMaintenanceV100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OrganizationCodeMaintenanceV100GetResponse
    {
        /// <summary>
        /// Lineage reference object : FTVORGN_HIERARCHY_TABLE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hierarchyTableInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HierarchyTableInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ttlLocn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TtlLocn { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVORGN_ACTV_CODE_DEF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("actvCodeDef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ActvCodeDef { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ttlActv", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TtlActv { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVORGN_DATA_ENTRY_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dataEntryInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DataEntryInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVORGN_COAS_CODE, Lookup lineage reference object : ftvcoas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coasCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoasCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVORGN_ORGN_CODE_NSF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orgnCodeNsf", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrgnCodeNsf { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ttlFund", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TtlFund { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVORGN_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : spriden,ftvfmgr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("displayFmgrCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayFmgrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVORGN_LOCN_CODE_DEF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("locnCodeDef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LocnCodeDef { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVORGN_ORGN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orgnCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrgnCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("formFmgrName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FormFmgrName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVORGN_EFF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset EffDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVORGN_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayNchgDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DisplayNchgDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVORGN_ORGN_CODE_PRED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orgnCodePred", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrgnCodePred { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("predTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PredTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVORGN_STATUS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statusInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatusInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVORGN_FUND_CODE_DEF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundCodeDef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundCodeDef { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ttlProg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TtlProg { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVORGN_TERM_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TermDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVORGN_PROG_CODE_DEF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("progCodeDef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProgCodeDef { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ttlBudOrgn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TtlBudOrgn { get; set; } = default!;

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