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

namespace Ellucian.Generated.BpApi.Ban._20212022NeedAnalysisResultPrimaryCalculationsV100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class _20212022NeedAnalysisResultPrimaryCalculationsV100PutRequest
    {
        /// <summary>
        /// Lineage reference object : RCRAPP2_C_PAR_1_CTRB_OFFL_EST
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cPar1CtrbOfflEst", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CPar1CtrbOfflEst { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rorstatPgiLockInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RorstatPgiLockInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RCRAPP2_IM_1_SC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("im1Sc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Im1Sc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblckInfcCode, Lookup lineage reference object : rtvinfc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckInfcCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblckInfcCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rorstatCmPcLockInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RorstatCmPcLockInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RCRAPP2_ELIGIBILITY_MSG
        /// </summary>
        [Newtonsoft.Json.JsonProperty("eligibilityMsg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EligibilityMsg { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rcrapp4SsRegFlag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Rcrapp4SsRegFlag { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rcrapp3SocSec", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Rcrapp3SocSec { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rcrapp4SsaCitizenInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Rcrapp4SsaCitizenInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rcrapp3MothSsnMatch", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Rcrapp3MothSsnMatch { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rcrapp1Ins", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Rcrapp1Ins { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RCRAPP2_C_1_ANLY_TYPE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("c1AnlyType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? C1AnlyType { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblckStudentId
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckStudentId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblckStudentId { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("cmScLockInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CmScLockInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RCRAPP2_IM_1_PC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("im1Pc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Im1Pc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rcrapp3OfflUnofflInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Rcrapp3OfflUnofflInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RCRAPP2_C_1_CTRB_OFFL_EST
        /// </summary>
        [Newtonsoft.Json.JsonProperty("c1CtrbOfflEst", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? C1CtrbOfflEst { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rcrapp4SsMatch", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Rcrapp4SsMatch { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rorstatInstScLockInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RorstatInstScLockInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rcrapp4SecInsMatchInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Rcrapp4SecInsMatchInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rorstatNsldsOvrdInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RorstatNsldsOvrdInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rcrapp4DodParDeathDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Rcrapp4DodParDeathDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RCRAPP2_IM_1_ANLY_TYPE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("im1AnlyType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Im1AnlyType { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RCRAPP2_PELL_PGI_OFFL_EST
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pellPgiOfflEst", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PellPgiOfflEst { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RCRAPP2_PELL_PGI
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pellPgi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PellPgi { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rcrapp4DodMatchFlag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Rcrapp4DodMatchFlag { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rcrapp3FathSsnMatch", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Rcrapp3FathSsnMatch { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblckSeqNo
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckSeqNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblckSeqNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RCRAPP2_C_1_CTRB_FOR_STDT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("c1CtrbForStdt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? C1CtrbForStdt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rcrapp4VaMatchFlag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Rcrapp4VaMatchFlag { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RCRAPP2_C_PAR_1_CTRB_FOR_STDT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cPar1CtrbForStdt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CPar1CtrbForStdt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RCRAPP2_IM_1_PAR_ANLY_TYPE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("im1ParAnlyType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Im1ParAnlyType { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rorstatInstPcLockInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RorstatInstPcLockInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RCRAPP2_C_PAR_1_ANLY_TYPE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cPar1AnlyType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CPar1AnlyType { get; set; } = default!;

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