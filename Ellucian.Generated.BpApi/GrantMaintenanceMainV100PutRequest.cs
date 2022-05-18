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

namespace Ellucian.Generated.BpApi.Ban.GrantMaintenanceMainV100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GrantMaintenanceMainV100PutRequest
    {
        /// <summary>
        /// Lineage reference object : FRBGRNT_STATUS_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statusDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? StatusDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_SUB_CATEGORY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subCategory", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SubCategory { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_PROP_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.propCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaPropCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaUserId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_SPONSOR_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sponsorId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SponsorId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_GRANT_TYPE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.grantType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaGrantType { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_TERM_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.termDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaTermDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_CSTA_CODE_CHARGE, Lookup lineage reference object : frbcsta,frvcsta
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cstaCodeCharge", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CstaCodeCharge { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_LONG_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.longTitle", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaLongTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_RCPT_SHARE_TOTAL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rcptShareTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RcptShareTotal { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_CSTD_CODE_DISTR, Lookup lineage reference object : frbcstd,frvcstd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cstdCodeDistr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CstdCodeDistr { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.cfdaCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCfdaCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_CUM_FUNDING_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cumFundingAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CumFundingAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_CURRENT_FUNDING_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currentFundingAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CurrentFundingAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_GRNT_CODE_RELATED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grntCodeRelated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GrntCodeRelated { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_COAS_CODE, Lookup lineage reference object : ftvcoas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.coasCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaCoasCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_AGENCY_ADDR_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agencyAddrCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AgencyAddrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_SUB_CATEGORY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.subCategory", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaSubCategory { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("piIdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PiIdCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_COAS_CODE, Lookup lineage reference object : ftvcoas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("frbgrntCoasCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FrbgrntCoasCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_PROJECT_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("projectEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ProjectEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_RCPT_SHARE_TOTAL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.rcptShareTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaRcptShareTotal { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_ALTERNATE_STATUS_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alternateStatusDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AlternateStatusDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.title", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_ALTERNATE_STATUS_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.alternateStatusDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaAlternateStatusDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.piIdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaPiIdCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_BASI_CODE_CS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("basiCodeCs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BasiCodeCs { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_SPONSOR_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.sponsorId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaSponsorId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_AGENCY_ADDR_SEQ_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agencyAddrSeqNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AgencyAddrSeqNum { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_CURRENT_FUNDING_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.currentFundingAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaCurrentFundingAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_CSTR_CODE_RATE, Lookup lineage reference object : frrcstr,frvcstr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cstrCodeRate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CstrCodeRate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_STATUS_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.statusCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaStatusCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_GRANT_TYPE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grantType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GrantType { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_TERM_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TermDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_LONG_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("longTitle", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LongTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_STATUS_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statusCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatusCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_INDA_CODE_CHARGE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("indaCodeCharge", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IndaCodeCharge { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_AGENCY_TELE_SEQNO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agencyTeleSeqno", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AgencyTeleSeqno { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("cfdaCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CfdaCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("houseNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HouseNumber { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("agencyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AgencyCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_MAX_FUNDING_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maxFundingAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MaxFundingAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_CATEGORY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.category", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCategory { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ctryCodePhone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CtryCodePhone { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_PROP_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("propCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PropCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : displayFrbgrntCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("displayFrbgrntCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? DisplayFrbgrntCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : displayPropCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("displayPropCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? DisplayPropCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_PROJECT_START_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("projectStartDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ProjectStartDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.displayPassThruInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaDisplayPassThruInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_EFF_CERT_REQUIRED_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.effCertRequiredInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaEffCertRequiredInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_ORGN_CODE_RESP_OFFICE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.orgnCodeRespOffice", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaOrgnCodeRespOffice { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_BASI_CODE_IC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("basiCodeIc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BasiCodeIc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_AGENCY_EMAIL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agencyEmail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AgencyEmail { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_AGENCY_CONTACT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agencyContact", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AgencyContact { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_INDD_CODE_DISTR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inddCodeDistr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InddCodeDistr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_IDC_ENC_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("idcEncInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IdcEncInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_INDR_CODE_RATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("indrCodeRate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IndrCodeRate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_EXPEND_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expendEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ExpendEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_PROJECT_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.projectEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaProjectEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_PROJECT_START_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.projectStartDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CriteriaProjectStartDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_GRNT_CODE_RELATED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.grntCodeRelated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaGrntCodeRelated { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_MAX_FUNDING_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.maxFundingAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaMaxFundingAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_COAS_CODE_IC_CS, Lookup lineage reference object : ftvcoas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coasCodeIcCs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CoasCodeIcCs { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.agencyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaAgencyCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_EXPEND_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.expendEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaExpendEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_STATUS_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.statusDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaStatusDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_CUM_FUNDING_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.cumFundingAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaCumFundingAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_ORGN_CODE_RESP_OFFICE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orgnCodeRespOffice", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrgnCodeRespOffice { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_EFF_CERT_REQUIRED_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effCertRequiredInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EffCertRequiredInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_CATEGORY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Category { get; set; } = default!;

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