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

namespace Ellucian.Generated.BpApi.Ban.ComplementaryActivitiesSubmissionAdministrationV100QapiPost
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ComplementaryActivitiesSubmissionAdministrationV100QapiPost
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Id { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCASA_PROGRAM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("program", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Program { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCASA_TERM_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCASA_CATEGORY_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("categoryCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CategoryCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCASA_ACTIVITY_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ActivityCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCASA_SEQUENCE_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sequenceNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SequenceNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCASA_SUBMIT_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("submitDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? SubmitDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCASA_SUBMIT_HRS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("submitHrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SubmitHrs { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCASA_STU_COMMENT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stuComment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StuComment { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCASA_DOC_SUBMIT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("docSubmitInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DocSubmitInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCASA_CASV_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("casvCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CasvCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCASA_APPROVAL_COMMENT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("approvalComment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ApprovalComment { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCASA_APPROVED_HRS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("approvedHrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ApprovedHrs { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCASA_APPROVED_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("approvedDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ApprovedDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCASA_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORCASA_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

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