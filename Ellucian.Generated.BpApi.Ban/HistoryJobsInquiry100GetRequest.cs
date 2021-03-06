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

namespace Ellucian.Generated.BpApi.Ban.HistoryJobsInquiry100GetRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class HistoryJobsInquiry100GetRequest
    {
        /// <summary>
        /// Lineage reference object : year
        /// </summary>
        [Newtonsoft.Json.JsonProperty("year", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Year { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHVJOBS_DISP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("disp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Disp { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHVJOBS_LAST_NAME_SEQ
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lastNameSeq", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LastNameSeq { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHVJOBS_POSN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("posn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Posn { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHVJOBS_FIRST_NAME_SEQ
        /// </summary>
        [Newtonsoft.Json.JsonProperty("firstNameSeq", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FirstNameSeq { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : coas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Coas { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : payno
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payno", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Payno { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHVJOBS_ID_SEQ
        /// </summary>
        [Newtonsoft.Json.JsonProperty("idSeq", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IdSeq { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : pictCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pictCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PictCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : trCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHVJOBS_SUFF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("suff", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Suff { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : orgn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orgn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Orgn { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PHVJOBS_EFFECTIVE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effectiveDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EffectiveDate { get; set; } = default!;

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