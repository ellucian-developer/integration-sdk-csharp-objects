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

namespace Ellucian.Generated.BpApi.Ban.CourseRegistrationStatusCodes100GetRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CourseRegistrationStatusCodes100GetRequest
    {
        /// <summary>
        /// Lineage reference object : STVRSTS_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVRSTS_GRADABLE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gradableInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GradableInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVRSTS_INCL_ASSESS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inclAssess", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InclAssess { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVRSTS_WAIT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waitInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WaitInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVRSTS_SB_PRINT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sbPrintInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SbPrintInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVRSTS_SYSTEM_REQ_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("systemReqInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SystemReqInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVRSTS_INCL_SECT_ENRL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inclSectEnrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InclSectEnrl { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVRSTS_WITHDRAW_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("withdrawInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WithdrawInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVRSTS_WEB_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVRSTS_ATTEMPT_HR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attemptHrInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AttemptHrInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVRSTS_ENTERABLE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enterableInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EnterableInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVRSTS_VOICE_TYPE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voiceType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VoiceType { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVRSTS_INCL_TMST_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inclTmstInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InclTmstInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVRSTS_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVRSTS_AUTO_GRADE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("autoGrade", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AutoGrade { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVRSTS_EXTENSION_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extensionInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ExtensionInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVRSTS_ACTION_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("actionDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ActionDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : STVRSTS_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Desc { get; set; } = default!;

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