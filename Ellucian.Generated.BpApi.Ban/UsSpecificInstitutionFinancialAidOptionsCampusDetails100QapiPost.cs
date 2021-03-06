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

namespace Ellucian.Generated.BpApi.Ban.UsSpecificInstitutionFinancialAidOptionsCampusDetails100QapiPost
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UsSpecificInstitutionFinancialAidOptionsCampusDetails100QapiPost
    {
        [Newtonsoft.Json.JsonProperty("keyblckAidyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblckAidyCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_CAMP_CODE, Lookup lineage reference object : stvcamp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("campCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CampCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_EL_BRANCH_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("elBranchCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ElBranchCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_COMMON_SCHOOL_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commonSchoolId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CommonSchoolId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_PAYMENT_METHOD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("paymentMethod", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PaymentMethod { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayReportingId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayReportingId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_ACAD_CAL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acadCal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AcadCal { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displaySourceId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplaySourceId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_EXPECT_HRS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expectHrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExpectHrs { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_PELL_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pellId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PellId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_EXPECT_WKS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expectWks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ExpectWks { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_PELL_FUND_CODE, Lookup lineage reference object : rfrbase
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pellFundCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PellFundCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_HRS_IN_YR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hrsInYr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? HrsInYr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_FED_SCHOOL_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fedSchoolCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FedSchoolCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_WKS_IN_YR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wksInYr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? WksInYr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_OPEID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("opeid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Opeid { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayNbrMthsPay", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DisplayNbrMthsPay { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_OPEID_BRANCH
        /// </summary>
        [Newtonsoft.Json.JsonProperty("opeidBranch", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OpeidBranch { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_TURN_OFF_PELL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("turnOffPellInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TurnOffPellInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_DL_SCHOOL_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dlSchoolCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DlSchoolCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_APPLY_FYFTB_RULE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applyFyftbRuleInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ApplyFyftbRuleInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_EL_SCHOOL_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("elSchoolCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ElSchoolCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_INST_XREF_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instXrefInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InstXrefInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_TITLE_IV_RET_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("titleIvRetInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TitleIvRetInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORCAMP_TITLE_IV_ROUND_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("titleIvRoundInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TitleIvRoundInd { get; set; } = default!;

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