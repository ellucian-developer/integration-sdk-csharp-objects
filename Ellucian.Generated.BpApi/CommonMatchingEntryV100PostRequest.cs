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

namespace Ellucian.Generated.BpApi.Ban.CommonMatchingEntryV100PostRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CommonMatchingEntryV100PostRequest
    {
        /// <summary>
        /// Lineage reference object : GOTCMME_STREET_LINE2
        /// </summary>
        [Newtonsoft.Json.JsonProperty("streetLine2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StreetLine2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GOTCMME_CNTY_CODE, Lookup lineage reference object : stvcnty
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cntyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CntyCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("lastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LastName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GOTCMME_STREET_LINE1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("streetLine1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StreetLine1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GOTCMME_ADID_CODE, Lookup lineage reference object : gtvadid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adidCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AdidCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GOTCMME_CITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? City { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GOTCMME_STREET_LINE3
        /// </summary>
        [Newtonsoft.Json.JsonProperty("streetLine3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StreetLine3 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GOTCMME_SSN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Ssn { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GOTCMME_EMAIL_ADDRESS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("emailAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EmailAddress { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GOTCMME_EMAL_CODE, Lookup lineage reference object : gtvemal
        /// </summary>
        [Newtonsoft.Json.JsonProperty("emalCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EmalCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GOTCMME_MI
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Mi { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GOTCMME_ZIP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("zip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Zip { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GOTCMME_BIRTH_DAY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("birthDay", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BirthDay { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GOTCMME_PHONE_EXT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phoneExt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneExt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GOTCMME_STAT_CODE, Lookup lineage reference object : stvstat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GOTCMME_NATN_CODE, Lookup lineage reference object : stvnatn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("natnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NatnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GOTCMME_SEX
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sex", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Sex { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GOTCMME_TELE_CODE, Lookup lineage reference object : stvtele
        /// </summary>
        [Newtonsoft.Json.JsonProperty("teleCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TeleCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GOTCMME_BIRTH_MON
        /// </summary>
        [Newtonsoft.Json.JsonProperty("birthMon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BirthMon { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GOTCMME_FIRST_NAME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("firstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FirstName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblockSourceCode, Lookup lineage reference object : gtvcmsc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblockSourceCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblockSourceCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GOTCMME_PHONE_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phoneNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GOTCMME_BIRTH_YEAR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("birthYear", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BirthYear { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GOTCMME_PHONE_AREA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phoneArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneArea { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GOTCMME_ATYP_CODE, Lookup lineage reference object : stvatyp
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