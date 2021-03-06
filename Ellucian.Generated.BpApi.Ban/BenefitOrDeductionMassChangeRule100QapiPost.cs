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

namespace Ellucian.Generated.BpApi.Ban.BenefitOrDeductionMassChangeRule100QapiPost
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BenefitOrDeductionMassChangeRule100QapiPost
    {
        [Newtonsoft.Json.JsonProperty("bcat_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Bcat_code { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDMC_BDCA_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bdcaCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BdcaCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDMC_BDCL_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bdclCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BdclCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDMC_EFFECTIVE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effectiveDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EffectiveDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDMC_ACTION
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Action { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDMC_REF_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RefNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDMC_SELECT_STATUS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("selectStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SelectStatus { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDMC_CHANGE_STATUS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("changeStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ChangeStatus { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDMC_OPT_CODE1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("optCode1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OptCode1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDMC_OPT_CODE2
        /// </summary>
        [Newtonsoft.Json.JsonProperty("optCode2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OptCode2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDMC_OPT_CODE3
        /// </summary>
        [Newtonsoft.Json.JsonProperty("optCode3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OptCode3 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDMC_OPT_CODE4
        /// </summary>
        [Newtonsoft.Json.JsonProperty("optCode4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OptCode4 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDMC_OPT_CODE5
        /// </summary>
        [Newtonsoft.Json.JsonProperty("optCode5", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OptCode5 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("amount1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Amount1 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("amount2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Amount2 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("amount3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Amount3 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("amount4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Amount4 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDMC_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDMC_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

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