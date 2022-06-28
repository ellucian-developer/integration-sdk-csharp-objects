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

namespace Ellucian.Generated.BpApi.Ban.ShipToCodes100GetRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ShipToCodes100GetRequest
    {
        /// <summary>
        /// Lineage reference object : FTVSHIP_BUILDING
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ftvshipBuilding", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvshipBuilding { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_PHONE_EXT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ftvshipPhoneExt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvshipPhoneExt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_PHONE_AREA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ftvshipPhoneArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvshipPhoneArea { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ftvshipCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvshipCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_TERM_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ftvshipTermDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FtvshipTermDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_CONTACT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ftvshipContact", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvshipContact { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_CTRY_CODE_PHONE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ftvshipCtryCodePhone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvshipCtryCodePhone { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_FLOOR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ftvshipFloor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvshipFloor { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_EFF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ftvshipEffDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FtvshipEffDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FTVSHIP_PHONE_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ftvshipPhoneNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FtvshipPhoneNum { get; set; } = default!;

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