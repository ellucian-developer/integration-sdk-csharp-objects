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

namespace Ellucian.Generated.BpApi.Ban.ApplicantHighSchoolAndAdmissionData100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ApplicantHighSchoolAndAdmissionData100PutRequest
    {
        /// <summary>
        /// Lineage reference object : RORHSDT_REQ_COURSES
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reqCourses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReqCourses { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORHSDT_ATBT_COD_TEST_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("testCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TestCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORHSDT_TADM_COD_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("testAdmin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TestAdmin { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORHSDT_HS_GRAD_STATE_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hsGrad", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HsGrad { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORHSDT_ATBT_COD_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("eligibility", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Eligibility { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORHSDT_ATBT_CDST_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stateCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StateCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblckId
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Id { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORHSDT_AP_IB_COURSES
        /// </summary>
        [Newtonsoft.Json.JsonProperty("placementCourses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlacementCourses { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORHSDT_HS_GRAD_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gradDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? GradDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORHSDT_ATBT_COMP_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("compDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CompDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORHSDT_ADV_HONORS_PROG_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stateRecon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StateRecon { get; set; } = default!;

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