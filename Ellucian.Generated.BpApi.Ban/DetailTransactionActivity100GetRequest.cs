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

namespace Ellucian.Generated.BpApi.Ban.DetailTransactionActivity100GetRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DetailTransactionActivity100GetRequest
    {
        /// <summary>
        /// Lineage reference object : keyblckFundCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckFundCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblckFundCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblckLocnCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckLocnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblckLocnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblckCoasCode, Lookup lineage reference object : ftvcoas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckCoasCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblckCoasCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblckProgCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckProgCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblckProgCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblckFsyrCode, Lookup lineage reference object : ftvfspd,ftvfsyr,ftvfspd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckFsyrCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblckFsyrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblckAcciCode, Lookup lineage reference object : ftvacci
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckAcciCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblckAcciCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGVTRND_FIELD_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fieldDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FieldDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGVTRND_DOC_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("docCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DocCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblckActvCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckActvCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblckActvCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayProgCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayProgCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGVTRND_ORGN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orgnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrgnCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayAcctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayAcctCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGVTRND_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblckPeriod
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckPeriod", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblckPeriod { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGVTRND_FUND_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FundCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblckCmtType
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckCmtType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblckCmtType { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGVTRND_TRANS_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TransDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblckAcctCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckAcctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblckAcctCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGVTRND_TRANS_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TransAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGVTRND_TRANS_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset TransDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGVTRND_RUCL_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ruclCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RuclCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblckOrgnCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckOrgnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblckOrgnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGVTRND_DR_CR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("drCrInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DrCrInd { get; set; } = default!;

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