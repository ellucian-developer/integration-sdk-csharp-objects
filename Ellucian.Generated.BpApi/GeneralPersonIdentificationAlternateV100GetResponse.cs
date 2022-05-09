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

namespace Ellucian.Generated.BpApi.Ban.GeneralPersonIdentificationAlternateV100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GeneralPersonIdentificationAlternateV100GetResponse
    {
        /// <summary>
        /// Lineage reference object : SPRIDEN_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spridenActivityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? SpridenActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRIDEN_CREATE_USER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spridenCreateUser", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SpridenCreateUser { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRIDEN_ORIGIN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spridenOrigin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SpridenOrigin { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRIDEN_MI
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spridenMi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SpridenMi { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("previousNtypDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PreviousNtypDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRIDEN_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spridenId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SpridenId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRIDEN_FIRST_NAME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spridenFirstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SpridenFirstName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRIDEN_CHANGE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spridenChangeInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SpridenChangeInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRIDEN_USER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spridenUser", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SpridenUser { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRIDEN_LAST_NAME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spridenLastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SpridenLastName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRIDEN_NTYP_CODE, Lookup lineage reference object : gtvntyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spridenNtypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SpridenNtypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRIDEN_SURNAME_PREFIX
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spridenSurnamePrefix", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SpridenSurnamePrefix { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRIDEN_CREATE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spridenCreateDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? SpridenCreateDate { get; set; } = default!;

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