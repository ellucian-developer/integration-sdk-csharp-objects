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

namespace Ellucian.Generated.BpApi.Ban.UserProfileMaintenanceV100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UserProfileMaintenanceV100GetResponse
    {
        /// <summary>
        /// Lineage reference object : FOBPROF_REQUESTOR_SHIP_CODE, Lookup lineage reference object : ftvship
        /// </summary>
        [Newtonsoft.Json.JsonProperty("requestorShipCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RequestorShipCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_REQUESTOR_PHONE_EXT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("requestorPhoneExt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RequestorPhoneExt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_COAS_CODE, Lookup lineage reference object : ftvcoas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coasCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoasCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_EDI_OVERRIDE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ediOverrideInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EdiOverrideInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_INV_MATCH_OVRRD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invMatchOvrrdInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InvMatchOvrrdInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_RCVD_OVERRIDE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rcvdOverrideInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RcvdOverrideInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_WBUD_MSTR_FUND_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wbudMstrFundInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WbudMstrFundInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("spridenId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SpridenId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_RCVD_TOLERANCE_PCT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rcvdTolerancePct", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RcvdTolerancePct { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ftvshipBuilding", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvshipBuilding { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_NSF_OVERRIDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nsfOverride", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NsfOverride { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_MAX_TOLERANCE_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maxToleranceAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MaxToleranceAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_EXP_END_POST_AUTH_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expEndPostAuthInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ExpEndPostAuthInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_WBUD_MSTR_ORGN_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wbudMstrOrgnInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WbudMstrOrgnInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_WHRLD_ACCESS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("whrldAccessInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WhrldAccessInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_PMT_HOLD_OVRD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pmtHoldOvrdInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PmtHoldOvrdInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_REQUESTER_ORGN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("requesterOrgnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RequesterOrgnCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ftvshipFloor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvshipFloor { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_TOLERANCE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tolerance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Tolerance { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ftvshipAddrLine2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvshipAddrLine2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_WBUD_ACCESS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wbudAccessInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WbudAccessInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ftvshipAddrLine1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvshipAddrLine1 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("orgnDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrgnDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_MASTER_FUND_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("masterFundInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MasterFundInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_REQUESTOR_PHONE_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("requestorPhoneNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RequestorPhoneNumber { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ftvshipAddrLine3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvshipAddrLine3 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_REQUESTOR_FAX_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("requestorFaxNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RequestorFaxNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_MASTER_ORGN_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("masterOrgnInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MasterOrgnInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_ACCRUAL_POST_AUTH_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accrualPostAuthInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AccrualPostAuthInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_RCVD_TOLERANCE_QTY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rcvdToleranceQty", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RcvdToleranceQty { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("fullName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FullName { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ftvshipContact", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvshipContact { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_WEB_ACCESS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webAccessInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebAccessInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_USER_NAME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UserName { get; set; } = default!;

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
        /// Lineage reference object : FOBPROF_CARD_OVERRIDE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cardOverrideInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CardOverrideInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_TOL_OVERRIDE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tolOverrideInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TolOverrideInd { get; set; } = default!;

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
        /// Lineage reference object : FOBPROF_PO_MATCH_OVRRD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poMatchOvrrdInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PoMatchOvrrdInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_REQUESTOR_PHONE_AREA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("requestorPhoneArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RequestorPhoneArea { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_ACH_OVERRIDE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("achOverrideInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AchOverrideInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_RCVD_TOLERANCE_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rcvdToleranceAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RcvdToleranceAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_REQ_MATCH_OVRRD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reqMatchOvrrdInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ReqMatchOvrrdInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_PO_HOLD_OVRD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poHoldOvrdInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PoHoldOvrdInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FOBPROF_USER_INV_PRIV
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userInvPriv", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserInvPriv { get; set; } = default!;

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