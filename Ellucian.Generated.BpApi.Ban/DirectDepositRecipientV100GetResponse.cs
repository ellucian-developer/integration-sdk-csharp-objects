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

namespace Ellucian.Generated.BpApi.Ban.DirectDepositRecipientV100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DirectDepositRecipientV100GetResponse
    {
        /// <summary>
        /// Lineage reference object : GXRDIRD_ACH_IAT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("achIatInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AchIatInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GXRDIRD_ATYP_CODE_IAT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("atypCodeIat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AtypCodeIat { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GXRDIRD_BANK_ACCT_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bankAcctNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BankAcctNum { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("bankDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BankDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scodCodeDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ScodCodeDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GXRDIRD_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GXRDIRD_ACHT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("achtCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AchtCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GXRDIRD_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GXRDIRD_ADDR_SEQNO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addrSeqno", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AddrSeqno { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GXRDIRD_SCOD_CODE_ISO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scodCodeIso", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ScodCodeIso { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GXRDIRD_ADDR_SEQNO_IAT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addrSeqnoIat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AddrSeqnoIat { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GXRDIRD_ACCT_TYPE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctType { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GXRDIRD_AP_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ApInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GXRDIRD_BANK_ROUT_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bankRoutNum", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BankRoutNum { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GXRDIRD_HR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hrInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HrInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GXRDIRD_ATYP_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("atypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AtypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GXRDIRD_STATUS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Status { get; set; } = default!;

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