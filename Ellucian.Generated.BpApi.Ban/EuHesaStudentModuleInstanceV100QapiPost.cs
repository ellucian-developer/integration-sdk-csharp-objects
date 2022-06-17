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

namespace Ellucian.Generated.BpApi.Ban.EuHesaStudentModuleInstanceV100QapiPost
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class EuHesaStudentModuleInstanceV100QapiPost
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Id { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBSTMI_STU_COURSE_SESSION_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stuCourseSessionId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StuCourseSessionId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBSTMI_MODULE_INSTANCE_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("moduleInstanceId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ModuleInstanceId { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("modId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ModId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBSTMI_MODULE_START_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("moduleStartDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ModuleStartDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBSTMI_SSDT_CODE_MODCOUNT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeModcount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeModcount { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeModcountSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeModcountSt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBSTMI_SSDT_CODE_APEL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeApel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeApel { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeApelSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeApelSt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBSTMI_SSDT_CODE_CONTINUING
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeContinuing", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeContinuing { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeContinuingSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeContinuingSt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBSTMI_SSDT_CODE_INACTIVEMOD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeInactivemod", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeInactivemod { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeInactivemodSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeInactivemodSt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBSTMI_LANGUAGE_PERCENTAGE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("languagePercentage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LanguagePercentage { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBSTMI_MIFEEAMOUNT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mifeeamount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Mifeeamount { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBSTMI_MODULE_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("moduleEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ModuleEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBSTMI_SSDT_CODE_MODOUTCOME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeModoutcome", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeModoutcome { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeModoutcomeSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeModoutcomeSt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBSTMI_SSDT_CODE_MODRESULT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeModresult", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeModresult { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeModresultSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeModresultSt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBSTMI_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBSTMI_ACTIVITY_DATE
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