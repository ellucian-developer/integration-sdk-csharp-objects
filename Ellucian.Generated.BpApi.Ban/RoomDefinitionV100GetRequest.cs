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

namespace Ellucian.Generated.BpApi.Ban.RoomDefinitionV100GetRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class RoomDefinitionV100GetRequest
    {
        /// <summary>
        /// Lineage reference object : SLBRDEF_BCAT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bcatCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BcatCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLBRDEF_PHONE_EXTENSION
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phoneExtension", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneExtension { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLBRDEF_KEY_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLBRDEF_CTRY_CODE_PHONE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ctryCodePhone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CtryCodePhone { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLBRDEF_CAPACITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("capacity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Capacity { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLBRDEF_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : gtvpars
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partitionCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PartitionCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLBRDEF_MAXIMUM_CAPACITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maximumCapacity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MaximumCapacity { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : stvtermTermCode, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stvtermTermCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? StvtermTermCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLBRDEF_ROOM_TYPE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("roomType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RoomType { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : slardefBldgCode, Lookup lineage reference object : stvbldg
        /// </summary>
        [Newtonsoft.Json.JsonProperty("slardefBldgCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? SlardefBldgCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLBRDEF_AREA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("area", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Area { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLBRDEF_UTILITY_RATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("utilityRate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UtilityRate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLBRDEF_TERM_CODE_EFF, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCodeEff", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TermCodeEff { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLBRDEF_RMST_CODE, Lookup lineage reference object : stvrmst
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rmstCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RmstCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLBRDEF_SEX
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sex", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Sex { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLBRDEF_PRCD_CODE, Lookup lineage reference object : stvprcd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prcdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PrcdCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLBRDEF_PRIORITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("priority", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Priority { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLBRDEF_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : room
        /// </summary>
        [Newtonsoft.Json.JsonProperty("room", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Room { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLBRDEF_RRCD_CODE, Lookup lineage reference object : stvrrcd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rrcdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RrcdCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLBRDEF_PHONE_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phoneNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLBRDEF_UTILITY_RATE_PERIOD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("utilityRatePeriod", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UtilityRatePeriod { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLBRDEF_PHONE_AREA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phoneArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneArea { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLBRDEF_COLL_CODE, Lookup lineage reference object : stvcoll
        /// </summary>
        [Newtonsoft.Json.JsonProperty("collCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CollCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLBRDEF_DEPT_CODE, Lookup lineage reference object : stvdept
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deptCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DeptCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLBRDEF_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Desc { get; set; } = default!;

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