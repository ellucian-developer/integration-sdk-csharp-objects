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

namespace Ellucian.Generated.BpApi.Ban.PurchaseBlanketOrderInquiryV100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PurchaseBlanketOrderInquiryV100GetResponse
    {
        /// <summary>
        /// Lineage reference object : FPBPOHD_CURR_CODE, Lookup lineage reference object : gtvcurr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CurrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_DISB_AGENT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("disbAgentInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisbAgentInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_TGRP_CODE, Lookup lineage reference object : ftvtrat,ftvtgrp,ftrtgtr,ftvtgrp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tgrpCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TgrpCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rtextInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RtextInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendZip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendZip { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_PHONE_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phoneNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneNum { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_PCLS_CODE, Lookup lineage reference object : ftvpcls
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pclsCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PclsCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_ORGN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orgnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrgnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_DOC_REF_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("docRefCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DocRefCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendPhoneNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendPhoneNum { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_COPIED_FROM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("copiedFrom", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CopiedFrom { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("hdrNote", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HdrNote { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendFaxArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendFaxArea { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("carrierName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CarrierName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_APPR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apprInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ApprInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_DISC_CODE, Lookup lineage reference object : ftvdisc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("discCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DiscCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ftvshipPhoneArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvshipPhoneArea { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_ATTENTION_TO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attentionTo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AttentionTo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_COMPLETE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("completeInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CompleteInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_ORIGIN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("originCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OriginCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_NSF_ON_OFF_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nsfOnOffInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NsfOnOffInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ftvshipState", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvshipState { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_BLANKET_TERM_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("blanketTermDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? BlanketTermDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendFaxNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendFaxNum { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendName { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayBuyrName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayBuyrName { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : ftvvend
        /// </summary>
        [Newtonsoft.Json.JsonProperty("displayVendCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayVendCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("fobsDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FobsDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_FAX_AREA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("faxArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FaxArea { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_EDIT_DEFER_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("editDeferInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EditDeferInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_VEND_EMAIL_ADDR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vendEmailAddr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendEmailAddr { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ftvshipPhoneExt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvshipPhoneExt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendAddrLine3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendAddrLine3 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_ATYP_SEQ_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("atypSeqNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AtypSeqNum { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendAddrLine2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendAddrLine2 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("carrierCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CarrierCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ftvshipCity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvshipCity { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_NAME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Name { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_PHONE_AREA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phoneArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneArea { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendAddrLine1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendAddrLine1 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendNatnDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendNatnDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("coasTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CoasTitle { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayPoCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayPoCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_CANCEL_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cancelDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CancelDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("matchDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MatchDescription { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ftvshipZipCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvshipZipCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendFaxExt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendFaxExt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendCity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendCity { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_DELIVERY_COMMENT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deliveryComment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DeliveryComment { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_COAS_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coasCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CoasCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ftvshipBuilding", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvshipBuilding { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_RUSH_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rushInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RushInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvnatnNation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvnatnNation { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_FAX_EXT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("faxExt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FaxExt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ftvcrsnDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvcrsnDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("optionNote", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OptionNote { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ftvshipFloor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvshipFloor { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("currDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CurrDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ftvshipPhoneNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvshipPhoneNum { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ftvshipAddrLine2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvshipAddrLine2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_PHONE_EXT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phoneExt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneExt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ftvshipAddrLine1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvshipAddrLine1 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ftvshipAddrLine3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvshipAddrLine3 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("classCodeTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ClassCodeTitle { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("orgTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrgTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_VENDOR_CONTACT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vendorContact", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendorContact { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ftvshipContact", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvshipContact { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendPhoneExt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendPhoneExt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_FOB_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fobCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FobCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_SHIP_CODE, Lookup lineage reference object : ftvship
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shipCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ShipCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("discDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DiscDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendPhoneArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendPhoneArea { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_BUYR_CODE, Lookup lineage reference object : ftvbuyr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buyrCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BuyrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_CLOSED_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("closedDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ClosedDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("tgrpTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TgrpTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_EMAIL_ADDR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("emailAddr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EmailAddr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_FAX_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("faxNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FaxNumber { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayBlanketCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayBlanketCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_PO_PRINTED_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poPrintedDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? PoPrintedDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBPOHD_ATYP_CODE, Lookup lineage reference object : ftvatyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("atypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AtypCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendStateCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendStateCode { get; set; } = default!;

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