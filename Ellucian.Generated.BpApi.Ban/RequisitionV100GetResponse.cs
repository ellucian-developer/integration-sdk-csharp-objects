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

namespace Ellucian.Generated.BpApi.Ban.RequisitionV100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class RequisitionV100GetResponse
    {
        [Newtonsoft.Json.JsonProperty("vendorFaxNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendorFaxNum { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendorStreetLine2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendorStreetLine2 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendorStreetLine1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendorStreetLine1 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayShipPhoneArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayShipPhoneArea { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBREQH_CURR_CODE, Lookup lineage reference object : gtvcurr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CurrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBREQH_TGRP_CODE, Lookup lineage reference object : ftvtrat,ftvtgrp,ftrtgtr,ftvtgrp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tgrpCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TgrpCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendorNatnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendorNatnCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayOrgnTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayOrgnTitle { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displaySingleAcctgInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplaySingleAcctgInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendorSpridenId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendorSpridenId { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendorStreetLine3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendorStreetLine3 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendorCity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendorCity { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBREQH_PHONE_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phoneNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneNum { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayShipFloor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayShipFloor { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBREQH_ORGN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orgnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrgnCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayReqhSuspInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayReqhSuspInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBREQH_TEXT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("textInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TextInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendorStatCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendorStatCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBREQH_REQH_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reqhDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ReqhDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBREQH_DISC_CODE, Lookup lineage reference object : ftvdisc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("discCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DiscCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBREQH_ATTENTION_TO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attentionTo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AttentionTo { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayCoasTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayCoasTitle { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayShipState", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayShipState { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBREQH_FAX_AREA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("faxArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FaxArea { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBREQH_VEND_EMAIL_ADDR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vendEmailAddr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendEmailAddr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBREQH_ATYP_SEQ_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("atypSeqNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AtypSeqNum { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayAccountingTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DisplayAccountingTotal { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBREQH_NAME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBREQH_PHONE_AREA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phoneArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneArea { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendorSpridenName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendorSpridenName { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayShipPhoneExt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayShipPhoneExt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendorFaxExt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendorFaxExt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayShipBuilding", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayShipBuilding { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayShipCity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayShipCity { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBREQH_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Code { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBREQH_REQD_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reqdDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ReqdDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBREQH_DELIVERY_COMMENT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deliveryComment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DeliveryComment { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBREQH_COAS_CODE, Lookup lineage reference object : ftvcoas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coasCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CoasCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayShipNation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayShipNation { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendorTgrpDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendorTgrpDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendorCurrDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendorCurrDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendorPhoneExt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendorPhoneExt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendorPhoneNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendorPhoneNum { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBREQH_FAX_EXT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("faxExt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FaxExt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBREQH_TRANS_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset TransDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendorDiscDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendorDiscDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayShipPhoneNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayShipPhoneNum { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBREQH_PHONE_EXT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phoneExt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneExt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayShipZipCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayShipZipCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayShipAddrLine3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayShipAddrLine3 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayCommodityTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DisplayCommodityTotal { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBREQH_VENDOR_CONTACT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vendorContact", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendorContact { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBREQH_SHIP_CODE, Lookup lineage reference object : ftvship
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shipCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ShipCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendorFaxArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendorFaxArea { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendorPhoneArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendorPhoneArea { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBREQH_EMAIL_ADDR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("emailAddr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EmailAddr { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayShipAddrLine2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayShipAddrLine2 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayShipAddrLine1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayShipAddrLine1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBREQH_FAX_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("faxNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FaxNumber { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendorHold", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendorHold { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendorZip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendorZip { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayShipContact", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayShipContact { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPBREQH_ATYP_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("atypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AtypCode { get; set; } = default!;

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