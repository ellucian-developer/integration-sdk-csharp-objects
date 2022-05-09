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

namespace Ellucian.Generated.BpApi.Ban.MealAssignmentV100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class MealAssignmentV100GetResponse
    {
        /// <summary>
        /// Lineage reference object : SLRMASG_MRCD_CODE, Lookup lineage reference object : slrlmfe,tbbdetc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mrcdCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MrcdCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLRMASG_AR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("arInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ArInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLRMASG_MSCD_CODE, Lookup lineage reference object : stvmscd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mscdCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MscdCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLRMASG_MSCD_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mscdDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset MscdDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLRMASG_ONL_OR_BAT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("onlOrBat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OnlOrBat { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLRMASG_ASSESS_NEEDED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("assessNeeded", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AssessNeeded { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("workasgEndDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset WorkasgEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLRMASG_TOTAL_TERMS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("totalTerms", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double TotalTerms { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLRMASG_TOTAL_DAYS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("totalDays", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double TotalDays { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLRMASG_TOTAL_MONTHS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("totalMonths", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double TotalMonths { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLRMASG_ROLL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rollInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RollInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("workasgBeginDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset WorkasgBeginDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SLRMASG_TERM_CODE, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TermCode { get; set; } = default!;

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