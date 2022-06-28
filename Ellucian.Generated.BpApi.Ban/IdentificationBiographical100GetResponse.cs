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

namespace Ellucian.Generated.BpApi.Ban.IdentificationBiographical100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class IdentificationBiographical100GetResponse
    {
        [Newtonsoft.Json.JsonProperty("mrtlDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MrtlDescription { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_DEAD_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deadDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DeadDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_MRTL_CODE, Lookup lineage reference object : stvmrtl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mrtlCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MrtlCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("lgcyDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LgcyDescription { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_RELG_CODE, Lookup lineage reference object : stvrelg
        /// </summary>
        [Newtonsoft.Json.JsonProperty("relgCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RelgCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_ETHN_CODE, Lookup lineage reference object : stvethn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ethnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EthnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_VERA_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("veraInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VeraInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("greenDataBar1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GreenDataBar1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_SSN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Ssn { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("citzDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CitzDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_ACTIVE_DUTY_SEPR_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activeDutySeprDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActiveDutySeprDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_GNDR_CODE, Lookup lineage reference object : gtvgndr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gndrCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GndrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_DEAD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deadInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DeadInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_ETHN_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ethnCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EthnCde { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("persSex", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PersSex { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_CONFIRMED_RE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("confirmedReDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ConfirmedReDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("persAge", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PersAge { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_LGCY_CODE, Lookup lineage reference object : stvlgcy
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lgcyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LgcyCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_ARMED_SERV_MED_VET_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("armedServMedVetInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ArmedServMedVetInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_CONFID_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("confidInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ConfidInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_BIRTH_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("birthDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? BirthDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("pprnDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PprnDescription { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_CITZ_CODE, Lookup lineage reference object : stvcitz
        /// </summary>
        [Newtonsoft.Json.JsonProperty("citzCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CitzCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_VETC_FILE_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vetcFileNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VetcFileNumber { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ethnDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EthnDescription { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("gndrDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GndrDescription { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("relgDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RelgDescription { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_CONFIRMED_RE_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("confirmedReCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ConfirmedReCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_SDVET_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sdvetInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SdvetInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_PPRN_CODE, Lookup lineage reference object : gtvpprn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pprnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PprnCode { get; set; } = default!;

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