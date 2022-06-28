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

namespace Ellucian.Generated.BpApi.Ban.VendorMaintenanceAddress100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class VendorMaintenanceAddress100PutRequest
    {
        /// <summary>
        /// Lineage reference object : SPRADDR_STREET_LINE2
        /// </summary>
        [Newtonsoft.Json.JsonProperty("streetLine2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StreetLine2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_CNTY_CODE, Lookup lineage reference object : stvcnty
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cntyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CntyCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_FROM_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.fromDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaFromDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_ATYP_CODE, Lookup lineage reference object : stvatyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.atypCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaAtypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_STREET_LINE1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("streetLine1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StreetLine1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_TO_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.toDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaToDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_STATUS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.statusInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaStatusInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_CORRECTION_DIGIT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("asrcCorrDigit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AsrcCorrDigit { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_CITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? City { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_STREET_LINE4
        /// </summary>
        [Newtonsoft.Json.JsonProperty("streetLine4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StreetLine4 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_STREET_LINE3
        /// </summary>
        [Newtonsoft.Json.JsonProperty("streetLine3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StreetLine3 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_HOUSE_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("houseNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HouseNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_DELIVERY_POINT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("asrcDelPoint", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AsrcDelPoint { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_NATN_CODE, Lookup lineage reference object : stvnatn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.natnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaNatnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_CITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.city", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCity { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_GST_TAX_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("asrcGstTaxId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AsrcGstTaxId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ftvvendVendCode, Lookup lineage reference object : ftvvend
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ftvvendVendCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FtvvendVendCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_STATUS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statusInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatusInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("faxExt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FaxExt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_CARRIER_ROUTE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("asrcCarrRoute", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AsrcCarrRoute { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_ZIP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("zip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Zip { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_STREET_LINE1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.streetLine1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaStreetLine1 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("phoneExt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneExt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_STAT_CODE, Lookup lineage reference object : stvstat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_STREET_LINE4
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.streetLine4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaStreetLine4 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_NATN_CODE, Lookup lineage reference object : stvnatn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("natnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NatnCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("phoneCtry", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneCtry { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_STREET_LINE2
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.streetLine2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaStreetLine2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_STREET_LINE3
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.streetLine3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaStreetLine3 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_ASRC_CODE, Lookup lineage reference object : stvasrc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.asrcCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaAsrcCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_HOUSE_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.houseNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaHouseNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_ASRC_CODE, Lookup lineage reference object : stvasrc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("asrcCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AsrcCode { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvtele
        /// </summary>
        [Newtonsoft.Json.JsonProperty("teleCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TeleCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_STAT_CODE, Lookup lineage reference object : stvstat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.statCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaStatCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_ZIP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.zip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaZip { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("faxArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FaxArea { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("phoneNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneNumber { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("faxNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FaxNum { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_CNTY_CODE, Lookup lineage reference object : stvcnty
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.cntyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCntyCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_SEQNO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.seqno", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaSeqno { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("phoneArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneArea { get; set; } = default!;

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