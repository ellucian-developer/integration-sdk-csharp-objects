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

namespace Ellucian.Generated.BpApi.Ban.SourceOrBackgroundInstitution100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SourceOrBackgroundInstitution100PutRequest
    {
        /// <summary>
        /// Lineage reference object : SOBSBGI_STREET_LINE2
        /// </summary>
        [Newtonsoft.Json.JsonProperty("streetLine2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StreetLine2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBSBGI_CNTY_CODE, Lookup lineage reference object : stvcnty
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cntyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CntyCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBSBGI_STREET_LINE1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("streetLine1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StreetLine1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBSBGI_CITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? City { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBSBGI_STREET_LINE4
        /// </summary>
        [Newtonsoft.Json.JsonProperty("streetLine4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StreetLine4 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBSBGI_STREET_LINE3
        /// </summary>
        [Newtonsoft.Json.JsonProperty("streetLine3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StreetLine3 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBSBGI_HOUSE_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("houseNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HouseNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORBCNT_CTRY_CODE_PHONE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.ctryCodePhone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCtryCodePhone { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORBCNT_PHONE_AREA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.phoneArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaPhoneArea { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORBCNT_CTRY_CODE_PHONE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ctryCodePhone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CtryCodePhone { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORBCNT_PHONE_EXT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.phoneExt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaPhoneExt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBSBGI_ZIP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("zip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Zip { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORBCNT_PHONE_EXT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phoneExt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneExt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBSBGI_STAT_CODE, Lookup lineage reference object : stvstat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBSBGI_NATN_CODE, Lookup lineage reference object : stvnatn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("natnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NatnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocSbgiCode, Lookup lineage reference object : stvsbgi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocSbgiCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblocSbgiCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORBCNT_NAME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaName { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.ptypDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaPtypDescription { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORBCNT_PTYP_CODE, Lookup lineage reference object : stvptyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.ptypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaPtypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORBCNT_PTYP_CODE, Lookup lineage reference object : stvptyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PtypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORBCNT_PHONE_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phoneNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORBCNT_NAME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORBCNT_PHONE_AREA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phoneArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneArea { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORBCMT_COMMENT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("comment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Comment { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORBCNT_PHONE_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.phoneNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaPhoneNumber { get; set; } = default!;

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