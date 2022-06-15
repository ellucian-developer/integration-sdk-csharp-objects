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

namespace Ellucian.Generated.BpApi.Ban.ContractPersonAuthorizationV100PostResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ContractPersonAuthorizationV100PostResponse
    {
        [Newtonsoft.Json.JsonProperty("tbbpidm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Tbbpidm>? Tbbpidm { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("tbbcstu2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Tbbcstu2>? Tbbcstu2 { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Tbbpidm
    {
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Message { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Tbbcstu2
    {
        [Newtonsoft.Json.JsonProperty("studypathName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StudypathName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBCSTU_STUDENT_CONT_ROLL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbbcstuStudentContRollInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbbcstuStudentContRollInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBCSTU_AUTH_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbbcstuAuthInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbbcstuAuthInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBCSTU_STSP_KEY_SEQUENCE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbbcstuStspKeySequence", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TbbcstuStspKeySequence { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBCSTU_DEL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbbcstuDelInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbbcstuDelInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBCSTU_MAX_STUDENT_AMOUNT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbbcstuMaxStudentAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TbbcstuMaxStudentAmount { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("additionalText2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AdditionalText2 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stuName2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StuName2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBCSTU_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbbcstuActivityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TbbcstuActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBCSTU_TERM_CODE_EXPIRATION, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbbcstuTermCodeExpiration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbbcstuTermCodeExpiration { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stuId2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StuId2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBCSTU_AUTH_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbbcstuAuthNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbbcstuAuthNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBCSTU_SPONSOR_REF_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbbcstuSponsorRefNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbbcstuSponsorRefNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBCSTU_CONTRACT_PRIORITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbbcstuContractPriority", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double TbbcstuContractPriority { get; set; } = default!;

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