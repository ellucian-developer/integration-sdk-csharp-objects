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

namespace Ellucian.Generated.BpApi.Ban.SiteCodesV100GetRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SiteCodesV100GetRequest
    {
        /// <summary>
        /// Lineage reference object : STVSITE_STREET_ADDR2
        /// </summary>
        [Newtonsoft.Json.JsonProperty("streetAddr2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StreetAddr2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVSITE_STREET_ADDR3
        /// </summary>
        [Newtonsoft.Json.JsonProperty("streetAddr3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StreetAddr3 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVSITE_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVSITE_STREET_ADDR1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("streetAddr1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StreetAddr1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVSITE_NATN_CODE, Lookup lineage reference object : stvnatn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("natnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NatnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVSITE_CITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string City { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVSITE_HOUSE_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("houseNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HouseNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVSITE_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVSITE_STATE, Lookup lineage reference object : stvstat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? State { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVSITE_ZIPC, Lookup lineage reference object : gtvzipc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("zipc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Zipc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVSITE_STREET_ADDR4
        /// </summary>
        [Newtonsoft.Json.JsonProperty("streetAddr4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StreetAddr4 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVSITE_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Desc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVSITE_FOREIGN_COUNTRY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("foreignCountry", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ForeignCountry { get; set; } = default!;

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