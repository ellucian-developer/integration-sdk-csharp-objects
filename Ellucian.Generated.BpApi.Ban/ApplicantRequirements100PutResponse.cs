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

namespace Ellucian.Generated.BpApi.Ban.ApplicantRequirements100PutResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ApplicantRequirements100PutResponse
    {
        [Newtonsoft.Json.JsonProperty("rrrareq", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Rrrareq>? Rrrareq { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rorstat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Rorstat>? Rorstat { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Rrrareq
    {
        /// <summary>
        /// Lineage reference object : RRRAREQ_EST_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("estDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EstDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RRRAREQ_STAT_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset StatDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RRRAREQ_PERIOD, Lookup lineage reference object : robprds
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Period { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RRRAREQ_TRST_CODE, Lookup lineage reference object : rtvtrst
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trstCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TrstCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayDisbInd1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayDisbInd1 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rtvtreqPerkMpnFlag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RtvtreqPerkMpnFlag { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RRRAREQ_INFO_ACCESS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("infoAccessInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InfoAccessInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RRRAREQ_SBGI_TYPE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sbgiTypeInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SbgiTypeInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RRRAREQ_SYS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sysInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SysInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayTrkLtrInd1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayTrkLtrInd1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RRRAREQ_SBGI_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sbgiCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SbgiCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RRRAREQ_SAT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("satInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SatInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RRRAREQ_FUND_CODE, Lookup lineage reference object : rfrbase,rfraspc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayMemoInd1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayMemoInd1 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayPckgInd1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayPckgInd1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RRRAREQ_TREQ_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("treqCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TreqCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("sbgiDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SbgiDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayTreqDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayTreqDesc { get; set; } = default!;

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
        /// <summary>
        /// Lineage reference object : RORSTAT_DISB_REQ_COMP_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("disbReqCompDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DisbReqCompDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_TGRP_CODE_LOCK_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tgrpCodeLockInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TgrpCodeLockInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("holdHoldInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HoldHoldInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_PCKG_REQ_COMP_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pckgReqCompDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? PckgReqCompDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rtvtgrpDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RtvtgrpDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_TGRP_CODE, Lookup lineage reference object : rtvtgrp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tgrpCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TgrpCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_ALL_REQ_COMP_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allReqCompDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? AllReqCompDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_TRK_LTR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trkLtrInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TrkLtrInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("addtlReqtsInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddtlReqtsInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("unsatTermReqtsInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UnsatTermReqtsInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("unsatPromReqtsInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UnsatPromReqtsInd { get; set; } = default!;

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