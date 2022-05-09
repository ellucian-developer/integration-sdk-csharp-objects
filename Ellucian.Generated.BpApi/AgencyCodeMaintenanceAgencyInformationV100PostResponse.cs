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

namespace Ellucian.Generated.BpApi.Ban.AgencyCodeMaintenanceAgencyInformationV100PostResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AgencyCodeMaintenanceAgencyInformationV100PostResponse
    {
        [Newtonsoft.Json.JsonProperty("agcyCodePred", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AgcyCodePred { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVAGCY_CONTACT_EMAIL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contactEmail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ContactEmail { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVAGCY_CONTACT_PHONE_AREA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contactPhoneArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ContactPhoneArea { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("currentNtypDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CurrentNtypDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVAGCY_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVAGCY_ADDR_SEQNO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addrSeqno", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AddrSeqno { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVAGCY_CONTACT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Contact { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVAGCY_STATUS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statusInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatusInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVAGCY_CONTACT_PHONE_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contactPhoneNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ContactPhoneNumber { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : gtvntyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spridenNtypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SpridenNtypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVAGCY_CONTACT_PHONE_EXT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contactPhoneExt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ContactPhoneExt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVAGCY_ADDR_TYPE, Lookup lineage reference object : stvatyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addrType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddrType { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("namePred", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NamePred { get; set; } = default!;

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