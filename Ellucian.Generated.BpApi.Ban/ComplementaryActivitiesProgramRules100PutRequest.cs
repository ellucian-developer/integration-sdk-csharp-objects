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

namespace Ellucian.Generated.BpApi.Ban.ComplementaryActivitiesProgramRules100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ComplementaryActivitiesProgramRules100PutRequest
    {
        /// <summary>
        /// Lineage reference object : sobcarpTermCodeStart
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCodeStart", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TermCodeStart { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBCARP_REQ_CREDITS_PROGRAM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reqCreditsProgram", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ReqCreditsProgram { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCAAR_REQ_HOURS_ACTIVITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reqHoursActivity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ReqHoursActivity { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : program
        /// </summary>
        [Newtonsoft.Json.JsonProperty("program", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Program { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBCARP_CREDIT_EQUIVALENT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creditEquivalent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CreditEquivalent { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCACR_REQ_CREDITS_CATEGORY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.reqCreditsCategory", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaReqCreditsCategory { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCACR_REQ_HOURS_CATEGORY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reqHoursCategory", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ReqHoursCategory { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCACR_REQ_CREDITS_CATEGORY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reqCreditsCategory", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ReqCreditsCategory { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCACR_REQ_HOURS_CATEGORY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.reqHoursCategory", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CriteriaReqHoursCategory { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCACR_ACCG_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.accgCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaAccgCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCAAR_REQ_CREDITS_ACTIVITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reqCreditsActivity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ReqCreditsActivity { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBCARP_REQ_HOURS_PROGRAM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reqHoursProgram", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ReqHoursProgram { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : termCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermCode { get; set; } = default!;

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