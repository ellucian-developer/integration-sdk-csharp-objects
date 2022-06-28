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

namespace Ellucian.Generated.BpApi.Ban.TermControlProjectedRegistration100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TermControlProjectedRegistration100GetResponse
    {
        /// <summary>
        /// Lineage reference object : SOBPROJ_PROJ_ELEC_REG_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("projElecRegCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProjElecRegCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPROJ_ATTR_CODE, Lookup lineage reference object : stvattr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attrCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AttrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPROJ_FAILED_MOSTPROB_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("failedMostprobInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FailedMostprobInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPROJ_PROJ_PASSED_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("projPassedCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProjPassedCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPROJ_INCL_FAILED_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inclFailedInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InclFailedInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPROJ_PROJ_MAND_REG_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("projMandRegCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProjMandRegCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPROJ_PROJ_WEB_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("projWebInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProjWebInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPROJ_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvrestDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvrestDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPROJ_PROJ_TRANSFERRED_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("projTransferredCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProjTransferredCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPROJ_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPROJ_PROJ_INPROGRESS_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("projInprogressCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProjInprogressCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPROJ_ELECTIVE_RULE_KEY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("electiveRuleKey", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ElectiveRuleKey { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPROJ_DATA_ORIGIN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dataOrigin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DataOrigin { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPROJ_NULL_PROJ_RESTRICT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nullProjRestrictInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NullProjRestrictInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPROJ_PROJ_ROLL_TO_AH_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("projRollToAhCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProjRollToAhCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPROJ_REST_CODE, Lookup lineage reference object : stvrest
        /// </summary>
        [Newtonsoft.Json.JsonProperty("restCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RestCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPROJ_MANDATORY_RULE_KEY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mandatoryRuleKey", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MandatoryRuleKey { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPROJ_PROJ_RESTRICT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("projRestrictInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProjRestrictInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvattrDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvattrDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPROJ_TERM_CODE
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