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

namespace Ellucian.Generated.BpApi.Ban.GrantMaintenanceBillingV100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GrantMaintenanceBillingV100GetResponse
    {
        [Newtonsoft.Json.JsonProperty("frbgrnt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Frbgrnt>? Frbgrnt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("frbgbil", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Frbgbil>? Frbgbil { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Frbgrnt
    {
        /// <summary>
        /// Lineage reference object : FRBGRNT_STATUS_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statusDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? StatusDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("zipCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ZipCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_SUB_CATEGORY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subCategory", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SubCategory { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_SPONSOR_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sponsorId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SponsorId { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("cstrCodeRateName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CstrCodeRateName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_CSTA_CODE_CHARGE, Lookup lineage reference object : frbcsta,frvcsta
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cstaCodeCharge", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CstaCodeCharge { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("grantDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GrantDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_RCPT_SHARE_TOTAL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rcptShareTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RcptShareTotal { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("relatedGrntDescr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RelatedGrntDescr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_CSTD_CODE_DISTR, Lookup lineage reference object : frbcstd,frvcstd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cstdCodeDistr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CstdCodeDistr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_CUM_FUNDING_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cumFundingAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CumFundingAmt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("orgnCodeDescr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrgnCodeDescr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_CURRENT_FUNDING_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currentFundingAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CurrentFundingAmt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("addressLine1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddressLine1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_GRNT_CODE_RELATED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grntCodeRelated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GrntCodeRelated { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("addressLine2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddressLine2 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("addressLine3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddressLine3 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? State { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_AGENCY_ADDR_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agencyAddrCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AgencyAddrCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("piIdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PiIdCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_PROJECT_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("projectEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ProjectEndDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("cstaCodeChargeName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CstaCodeChargeName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_ALTERNATE_STATUS_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alternateStatusDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AlternateStatusDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("areaCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AreaCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_BASI_CODE_CS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("basiCodeCs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BasiCodeCs { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("phoneNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_AGENCY_ADDR_SEQ_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agencyAddrSeqNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AgencyAddrSeqNum { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_CSTR_CODE_RATE, Lookup lineage reference object : frrcstr,frvcstr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cstrCodeRate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CstrCodeRate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("piIdName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PiIdName { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("basiCodeCsName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BasiCodeCsName { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayPassThruInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayPassThruInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("agencyCode2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AgencyCode2 { get; set; } = default!;

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
        /// Lineage reference object : FRBGRNT_INDA_CODE_CHARGE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("indaCodeCharge", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IndaCodeCharge { get; set; } = default!;

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

        [Newtonsoft.Json.JsonProperty("inddCodeDistrName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InddCodeDistrName { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("extension", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Extension { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? City { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_AGENCY_TELE_SEQNO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agencyTeleSeqno", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AgencyTeleSeqno { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("cfdaCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CfdaCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("basiCodeIcName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BasiCodeIcName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_COAS_CODE, Lookup lineage reference object : ftvcoas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coasCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoasCode { get; set; } = default!;

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
        /// Lineage reference object : FRBGRNT_PROP_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("propCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PropCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("categoryDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CategoryDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_PROJECT_START_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("projectStartDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ProjectStartDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("indrCodeRateName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IndrCodeRateName { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("phoneExists", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneExists { get; set; } = default!;

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

        [Newtonsoft.Json.JsonProperty("subCatDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SubCatDesc { get; set; } = default!;

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
        /// Lineage reference object : FRBGRNT_AGENCY_PHONE_TYPE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agencyPhoneType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AgencyPhoneType { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_EXPEND_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expendEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ExpendEndDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("agencyName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AgencyName { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("indaCodeChargeName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IndaCodeChargeName { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("cstdCodeDistrName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CstdCodeDistrName { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("statusDescr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatusDescr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_COAS_CODE_IC_CS, Lookup lineage reference object : ftvcoas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coasCodeIcCs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CoasCodeIcCs { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("agencyName2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AgencyName2 { get; set; } = default!;

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

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Frbgbil
    {
        /// <summary>
        /// Lineage reference object : FRBGBIL_PMSC_CODE, Lookup lineage reference object : frvpmsc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pmscCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PmscCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("defferedAcctName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DefferedAcctName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_BUD_TOTAL_EXCEED_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budTotalExceedInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BudTotalExceedInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_BFRM_CODE_1034_EXT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bfrmCode1034Ext", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BfrmCode1034Ext { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_PAYMENT_ACCT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("paymentAcctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PaymentAcctCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("beclName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BeclName { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("pmscName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PmscName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_LAST_INV_SEQ_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lastInvSeqNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LastInvSeqNo { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("paymentFundName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PaymentFundName { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("clearingAcctName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ClearingAcctName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_ADDR_TYPE, Lookup lineage reference object : stvatyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addrType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddrType { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_BILLING_MIN_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("billingMinAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BillingMinAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_BUD_LINE_EXCEED_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budLineExceedInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BudLineExceedInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_BILLING_START_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("billingStartDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? BillingStartDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_BUD_CHECK_SOURCE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budCheckSourceInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BudCheckSourceInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_CLEARING_ACCT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("clearingAcctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ClearingAcctCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_ADDR_SEQNO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addrSeqno", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AddrSeqno { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_BECL_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("beclCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BeclCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_DEFERRED_ACCT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deferredAcctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DeferredAcctCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("paymentAcctName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PaymentAcctName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_BILLING_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("billingEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? BillingEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_BILLING_MAX_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("billingMaxAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BillingMaxAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_BUDGET_LIMIT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budgetLimitInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BudgetLimitInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_CUMULATIVE_BILLED_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cumulativeBilledAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CumulativeBilledAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_PAYMENT_FUND_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("paymentFundCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PaymentFundCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGBIL_MIN_NOT_REACHED_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minNotReachedInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MinNotReachedInd { get; set; } = default!;

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