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

namespace Ellucian.Generated.BpApi.Ban.ProgramRequirements100PutResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ProgramRequirements100PutResponse
    {
        /// <summary>
        /// Lineage reference object : SMBPGEN_REQ_CREDITS_I_TRAD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reqCreditsITrad", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ReqCreditsITrad { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMBPGEN_REQ_CREDITS_OVERALL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reqCreditsOverall", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ReqCreditsOverall { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMBPGEN_MAX_CREDITS_I_NONTRAD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maxCreditsINontrad", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MaxCreditsINontrad { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMBPGEN_LAST_EARNED_COURSES
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lastEarnedCourses", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LastEarnedCourses { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMBPGEN_MAX_CREDITS_TRANSFER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maxCreditsTransfer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MaxCreditsTransfer { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMBPGEN_MIN_PROGRAM_GPA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minProgramGpa", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MinProgramGpa { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMBPGEN_CONNECTOR_INST
        /// </summary>
        [Newtonsoft.Json.JsonProperty("connectorInst", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ConnectorInst { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMBPGEN_LAST_INST_COURSES
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lastInstCourses", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LastInstCourses { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMBPGEN_CAPTIVE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("captiveInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CaptiveInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("prereq", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Prereq { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMBPGEN_REGISTRATION_MODEL_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("registrationModelCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RegistrationModelCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMBPGEN_CONNECTOR_OVERALL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("connectorOverall", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ConnectorOverall { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMBPGEN_PREREQ_PROG_RES_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prereqProgResCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PrereqProgResCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMBPGEN_ACTIVE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activeInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ActiveInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMBPGEN_CONNECTOR_TRANSFER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("connectorTransfer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ConnectorTransfer { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMBPGEN_CONNECTOR_I_NONTRAD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("connectorINontrad", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ConnectorINontrad { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMBPGEN_CONNECTOR_LAST_INST
        /// </summary>
        [Newtonsoft.Json.JsonProperty("connectorLastInst", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ConnectorLastInst { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMBPGEN_MIN_GPA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minGpa", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MinGpa { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMBPGEN_SINGLE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("singleInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SingleInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMBPGEN_MAX_COURSES_TRANSFER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maxCoursesTransfer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MaxCoursesTransfer { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMBPGEN_CONNECTOR_I_TRAD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("connectorITrad", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ConnectorITrad { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMBPGEN_LAST_EARNED_CREDITS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lastEarnedCredits", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LastEarnedCredits { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMBPGEN_YEAR_RULE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yearRule", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? YearRule { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMBPGEN_REQ_COURSES_OVERALL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reqCoursesOverall", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ReqCoursesOverall { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMBPGEN_MAX_COURSES_I_NONTRAD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maxCoursesINontrad", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MaxCoursesINontrad { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMBPGEN_REQ_COURSES_I_TRAD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reqCoursesITrad", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ReqCoursesITrad { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMBPGEN_LAST_INST_CREDITS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lastInstCredits", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LastInstCredits { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMBPGEN_CONNECTOR_LAST_EARNED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("connectorLastEarned", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ConnectorLastEarned { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMBPGEN_REQ_CREDITS_INST
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reqCreditsInst", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ReqCreditsInst { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMBPGEN_REQ_COURSES_INST
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reqCoursesInst", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ReqCoursesInst { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SMBPGEN_GRDE_CODE_MIN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grdeCodeMin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GrdeCodeMin { get; set; } = default!;

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