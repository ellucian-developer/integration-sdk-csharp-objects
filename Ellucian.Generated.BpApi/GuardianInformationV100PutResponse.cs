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

namespace Ellucian.Generated.BpApi.Ban.GuardianInformationV100PutResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GuardianInformationV100PutResponse
    {
        /// <summary>
        /// Lineage reference object : SORFOLK_SURNAME_PREFIX
        /// </summary>
        [Newtonsoft.Json.JsonProperty("surnamePrefix", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SurnamePrefix { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvasrc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spraddrAsrcCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SpraddrAsrcCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("spraddrToDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? SpraddrToDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORFOLK_PARENT_LAST
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parentLast", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ParentLast { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("addrMsg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddrMsg { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvatypDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvatypDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("spraddrHouseNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SpraddrHouseNumber { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("spraddrZip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SpraddrZip { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("spraddrCity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SpraddrCity { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORFOLK_PARENT_EMPLOYER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parentEmployer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ParentEmployer { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvreltDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvreltDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORFOLK_PARENT_NAME_PREFIX
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parentNamePrefix", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ParentNamePrefix { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvcntyDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvcntyDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("phoneExists", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneExists { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvcnty
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spraddrCntyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SpraddrCntyCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("spraddrFromDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? SpraddrFromDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORFOLK_DECEASED_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deceasedInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DeceasedInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORFOLK_PARENT_NAME_SUFFIX
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parentNameSuffix", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ParentNameSuffix { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("phoneExt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneExt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORFOLK_RELT_CODE, Lookup lineage reference object : stvrelt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reltCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReltCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORFOLK_PARENT_DEGREE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parentDegree", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ParentDegree { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvstatDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvstatDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORFOLK_PARENT_MI
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parentMi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ParentMi { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORFOLK_PARENT_JOB_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parentJobTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ParentJobTitle { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("teleCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TeleCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("phoneNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneNumber { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("phoneCountryCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneCountryCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("spraddrStreetLine4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SpraddrStreetLine4 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("spraddrStreetLine3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SpraddrStreetLine3 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("spraddrSeqno", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SpraddrSeqno { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("spraddrStreetLine2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SpraddrStreetLine2 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("spraddrStreetLine1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SpraddrStreetLine1 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("phoneArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneArea { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvnatn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spraddrNatnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SpraddrNatnCode { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvstat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spraddrStatCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SpraddrStatCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORFOLK_PARENT_FIRST
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parentFirst", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ParentFirst { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORFOLK_ATYP_CODE, Lookup lineage reference object : stvatyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("atypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AtypCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvnatnDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvnatnDesc { get; set; } = default!;

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