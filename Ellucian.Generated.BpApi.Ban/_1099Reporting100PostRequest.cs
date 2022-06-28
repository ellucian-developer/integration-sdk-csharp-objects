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

namespace Ellucian.Generated.BpApi.Ban._1099Reporting100PostRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class _1099Reporting100PostRequest
    {
        /// <summary>
        /// Lineage reference object : FAB1099_BANK_CODE, Lookup lineage reference object : gxvbank
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bankCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BankCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAB1099_ST_WHOLD_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fab1099StWholdAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Fab1099StWholdAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAB1099_CHECK_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("checkNum", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CheckNum { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAB1099_CARD_NOT_PRESENT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cardNotPresent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CardNotPresent { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAB1099_COAS_CODE, Lookup lineage reference object : ftvcoas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coasCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CoasCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAB1099_FED_WHOLD_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fab1099FedWholdAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Fab1099FedWholdAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAB1099_CHECK_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("checkDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CheckDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ftvvendVendOwner, Lookup lineage reference object : ftvvend
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ftvvendVendOwner", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvvendVendOwner { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : ftvityp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fab1099ItypCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Fab1099ItypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : faa1099VendCode, Lookup lineage reference object : ftvvend
        /// </summary>
        [Newtonsoft.Json.JsonProperty("faa1099VendCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Faa1099VendCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAB1099_ST_PAID_OVER_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fab1099StPaidOverAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Fab1099StPaidOverAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : taxId
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taxID", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TaxID { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAB1099_INVH_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fab1099InvhCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Fab1099InvhCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAB1099_RPT_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rptAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RptAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAB1099_INST_TIN, Lookup lineage reference object : fob1099,for1099
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fab1099InstTin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Fab1099InstTin { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FAB1099_FED_PAID_OVER_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fab1099FedPaidOverAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Fab1099FedPaidOverAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : faa1099RptYr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("faa1099RptYr", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Faa1099RptYr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : instTin, Lookup lineage reference object : fob1099,for1099
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instTin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InstTin { get; set; } = default!;

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