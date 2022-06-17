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

namespace Ellucian.Generated.BpApi.Ban._20212022NeedAnalysisV100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class _20212022NeedAnalysisV100PutRequest
    {
        /// <summary>
        /// Lineage reference object : RCRAPP1_LAST_NAME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lastName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RCRAPP1_CITZ_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("citzInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CitzInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RCRAPP1_CITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? City { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblckInfcCode, Lookup lineage reference object : rtvinfc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckInfcCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblckInfcCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RCRAPP1_DEGREE_BY_JULY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("degreeByJuly", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DegreeByJuly { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RCRAPP1_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Title { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RCRAPP1_PHONE_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phoneNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RCRAPP1_SSN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssn", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Ssn { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displaySResDateMo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplaySResDateMo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblckStudentId
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckStudentId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblckStudentId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RCRAPP1_MI
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Mi { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RCRAPP1_ADDR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Addr { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displaySResDateYr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DisplaySResDateYr { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rcrapp3SMarMthYr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Rcrapp3SMarMthYr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RCRAPP1_ZIP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("zip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Zip { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rcrapp4EmailAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Rcrapp4EmailAddress { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RCRAPP1_STAT_CODE, Lookup lineage reference object : stvstat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rcrapp4DrugOffenseConvic", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Rcrapp4DrugOffenseConvic { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RCRAPP1_STAT_CODE_RES, Lookup lineage reference object : stvstat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statCodeRes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatCodeRes { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblckSeqNo
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckSeqNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblckSeqNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RCRAPP1_BIRTH_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("birthDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? BirthDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RCRAPP1_STAT_CODE_LIC, Lookup lineage reference object : stvstat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statCodeLic", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatCodeLic { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblckPellInd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckPellInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblckPellInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RCRAPP1_FIRST_NAME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("firstName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RCRAPP1_MRTL_STATUS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mrtlStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MrtlStatus { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("rcrapp4LegalResInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Rcrapp4LegalResInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RCRAPP1_PHONE_AREA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phoneArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneArea { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RCRAPP1_DRIVER_LIC_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("driverLicNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DriverLicNo { get; set; } = default!;

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