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

namespace Ellucian.Generated.BpApi.Ban.PersonExperienceV100PutResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PersonExperienceV100PutResponse
    {
        [Newtonsoft.Json.JsonProperty("pprexpe", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Pprexpe>? Pprexpe { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("pprrefe", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Pprrefe>? Pprrefe { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Pprexpe
    {
        /// <summary>
        /// Lineage reference object : PPREXPE_SUPER_NAME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("superName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SuperName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PPREXPE_EMTY_CODE, Lookup lineage reference object : ptremty
        /// </summary>
        [Newtonsoft.Json.JsonProperty("emtyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EmtyCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PPREXPE_STAT_CODE, Lookup lineage reference object : stvstat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PPREXPE_NATN_CODE, Lookup lineage reference object : stvnatn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("natnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NatnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PPREXPE_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PPREXPE_REASON_LEFT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reasonLeft", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ReasonLeft { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("emtyDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EmtyDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PPREXPE_HIRE_ACT_VERIF_REC_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hireActVerifRecInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HireActVerifRecInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PPREXPE_CONTACT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contactInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ContactInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PPREXPE_CURR_HOURLY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currHourly", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CurrHourly { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PPREXPE_HIRE_ACT_START_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hireactStartDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? HireactStartDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PPREXPE_SUPER_PHONE_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("superPhoneNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SuperPhoneNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PPREXPE_SUPER_PHONE_EXT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("superPhoneExt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SuperPhoneExt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PPREXPE_CURR_SALARY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currSalary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CurrSalary { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PPREXPE_POSN_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("posnTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PosnTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PPREXPE_POSN_DUTIES
        /// </summary>
        [Newtonsoft.Json.JsonProperty("posnDuties", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PosnDuties { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PPREXPE_SUPER_COMMENT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("superComment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SuperComment { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PPREXPE_EMPR_NAME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("emprName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EmprName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PPREXPE_EMPS_SUPERVISE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("empsSupervise", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? EmpsSupervise { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PPREXPE_START_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? StartDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PPREXPE_SUPER_PHONE_AREA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("superPhoneArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SuperPhoneArea { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Pprrefe
    {
        /// <summary>
        /// Lineage reference object : PPRREFE_PHONE_EXT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phoneExt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneExt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PPRREFE_PHONE_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phoneNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PPRREFE_NAME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Name { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PPRREFE_PHONE_AREA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phoneArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneArea { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PPRREFE_COMMENT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("comment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Comment { get; set; } = default!;

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