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

namespace Ellucian.Generated.BpApi.Ban.UserProfileMaintenance100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UserProfileMaintenance100PutRequest
    {
        /// <summary>
        /// Lineage reference object : FOBPROF_REQUESTOR_PHONE_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("requestorPhoneNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RequestorPhoneNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_REQUESTOR_PHONE_EXT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("requestorPhoneExt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RequestorPhoneExt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_REQUESTOR_FAX_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("requestorFaxNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RequestorFaxNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_COAS_CODE, Lookup lineage reference object : ftvcoas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coasCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoasCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_RCVD_TOLERANCE_QTY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rcvdToleranceQty", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RcvdToleranceQty { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyBlockUserId, Lookup lineage reference object : all_users
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_WBUD_MSTR_FUND_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wbudMstrFundInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WbudMstrFundInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_REQUESTOR_EMAIL_ADDR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("requestorEmailAddr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RequestorEmailAddr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_RCVD_TOLERANCE_AMT_PCT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rcvdToleranceAmtPct", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RcvdToleranceAmtPct { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_CTRY_CODE_REQ_PHONE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ctryCodeReqPhone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CtryCodeReqPhone { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_REQUESTOR_FAX_AREA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("requestorFaxArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RequestorFaxArea { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_BUD_ID, Lookup lineage reference object : ftvobud
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BudId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_REQUESTOR_FAX_EXT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("requestorFaxExt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RequestorFaxExt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_WBUD_MSTR_ORGN_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wbudMstrOrgnInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WbudMstrOrgnInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_REQUESTOR_PHONE_AREA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("requestorPhoneArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RequestorPhoneArea { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_REQ_MATCH_OVRRD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reqMatchOvrrdInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ReqMatchOvrrdInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_RCVD_TOLERANCE_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rcvdToleranceAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RcvdToleranceAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_REQUESTER_ORGN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("requesterOrgnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RequesterOrgnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_CTRY_CODE_REQ_FAX
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ctryCodeReqFax", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CtryCodeReqFax { get; set; } = default!;

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