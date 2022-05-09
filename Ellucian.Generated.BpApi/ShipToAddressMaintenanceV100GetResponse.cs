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

namespace Ellucian.Generated.BpApi.Ban.ShipToAddressMaintenanceV100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ShipToAddressMaintenanceV100GetResponse
    {
        [Newtonsoft.Json.JsonProperty("progTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProgTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_ZIP_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("zipCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ZipCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("fundTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_TGRP_CODE, Lookup lineage reference object : ftvtrat,ftvtgrp,ftrtgtr,ftvtgrp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tgrpCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TgrpCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_CITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? City { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_ORGN_CODE_WARE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orgnCodeWare", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrgnCodeWare { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_CARRIER_ROUTE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("carrierRoute", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CarrierRoute { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_PHONE_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phoneNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneNum { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("acctTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_BUILDING
        /// </summary>
        [Newtonsoft.Json.JsonProperty("building", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Building { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_EFF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset EffDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_PROG_CODE_WARE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("progCodeWare", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProgCodeWare { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_CONTACT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Contact { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_STATE, Lookup lineage reference object : stvstat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? State { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_FLOOR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("floor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Floor { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_CORRECTION_DIGIT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("correctionDigit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CorrectionDigit { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_ROUTE_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("routeCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RouteCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_DELIVERY_POINT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deliveryPoint", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DeliveryPoint { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_PHONE_EXT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phoneExt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneExt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("taxGroupTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TaxGroupTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_NATN_CODE, Lookup lineage reference object : stvnatn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("natnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NatnCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("locnTypeTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LocnTypeTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_ACCT_CODE_INVTRY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCodeInvtry", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCodeInvtry { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_FUND_CODE_INVTRY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundCodeInvtry", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundCodeInvtry { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_PROFIT_CENTER_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("profitCenterInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProfitCenterInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("orgnTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrgnTitle { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayNchgDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DisplayNchgDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_ADDR_LINE3
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addrLine3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddrLine3 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_ADDR_LINE2
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addrLine2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddrLine2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_ADDR_LINE1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addrLine1", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AddrLine1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_LOCN_TYPE_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("locnTypeCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LocnTypeCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_PHONE_AREA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phoneArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneArea { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayNation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayNation { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_TERM_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TermDate { get; set; } = default!;

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