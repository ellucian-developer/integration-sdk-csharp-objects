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

namespace Ellucian.Generated.BpApi.Ban.UsSpecificInstitutionFinancialAidOptionsDirectLoanMpnRulesV100GetRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UsSpecificInstitutionFinancialAidOptionsDirectLoanMpnRulesV100GetRequest
    {
        /// <summary>
        /// Lineage reference object : RLRDMPS_INFO_ACCESS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("infoAccessInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InfoAccessInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RLRDMPS_TRK_LTR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trkLtrInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TrkLtrInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RLRDMPS_REQ_STATUS_WEB_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reqStatusWebDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ReqStatusWebDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RLRDMPS_MPN_REQ_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mpnReqDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MpnReqDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RLRDMPO_DISPLAY_PN_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("displayPnInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayPnInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RLRDMPS_REQ_INSTR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reqInstrInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ReqInstrInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblckAidyCode, Lookup lineage reference object : robinst
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckAidyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblckAidyCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RLRDMPS_MPN_REQ_INSTRUCTIONS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mpnReqInstructions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MpnReqInstructions { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RLRDMPS_REQ_STATUS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reqStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ReqStatus { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RLRDMPS_SAT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("satInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SatInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RLRDMPO_MPN_TYPE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mpnType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MpnType { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RLRDMPS_MPN_REQ_URL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mpnReqUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MpnReqUrl { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RLRDMPO_CREATE_REQ_OPTION
        /// </summary>
        [Newtonsoft.Json.JsonProperty("createReqOption", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CreateReqOption { get; set; } = default!;

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