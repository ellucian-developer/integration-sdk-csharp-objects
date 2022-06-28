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

namespace Ellucian.Generated.BpApi.Ban.PersonComments100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PersonComments100GetResponse
    {
        /// <summary>
        /// Lineage reference object : SPRCMNT_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("contactDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ContactDescription { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("origDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrigDescription { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRCMNT_CONTACT_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contactDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ContactDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRCMNT_CONTACT_TO_TIME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contactToTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ContactToTime { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRCMNT_CMTT_CODE, Lookup lineage reference object : stvcmtt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cmttCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CmttCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRCMNT_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRCMNT_ORIG_CODE, Lookup lineage reference object : stvorig
        /// </summary>
        [Newtonsoft.Json.JsonProperty("origCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrigCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRCMNT_TEXT_NAR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("textNar", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TextNar { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRCMNT_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("cmttDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CmttDescription { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRCMNT_CONFIDENTIAL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("confidentialInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ConfidentialInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRCMNT_CTYP_CODE, Lookup lineage reference object : stvctyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ctypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CtypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRCMNT_TEXT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("text", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Text { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRCMNT_CONTACT_FROM_TIME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contactFromTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ContactFromTime { get; set; } = default!;

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