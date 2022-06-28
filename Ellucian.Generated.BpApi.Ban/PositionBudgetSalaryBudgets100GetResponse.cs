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

namespace Ellucian.Generated.BpApi.Ban.PositionBudgetSalaryBudgets100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PositionBudgetSalaryBudgets100GetResponse
    {
        /// <summary>
        /// Lineage reference object : NBRPTOT_OBUD_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("obudCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ObudCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRPTOT_SGRP_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sgrpCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SgrpCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRPTOT_OBPH_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("obphCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ObphCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRPTOT_ENCUMB
        /// </summary>
        [Newtonsoft.Json.JsonProperty("encumb", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Encumb { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRPTOT_COAS_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coasCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CoasCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRPTOT_CREATE_JFTE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("createJfteInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CreateJfteInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRPTOT_ORGN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orgnCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrgnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRPTOT_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ptotAvail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PtotAvail { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRPTOT_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRPTOT_APPT_PCT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apptPct", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double ApptPct { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRPTOT_BASE_UNITS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("baseUnits", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double BaseUnits { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRPTOT_BUDG_BASIS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budgBasis", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double BudgBasis { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRPTOT_EXPEND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expend", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Expend { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRPTOT_FISC_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fiscCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FiscCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRPTOT_FTE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fte", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Fte { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRPTOT_ANN_BASIS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("annBasis", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double AnnBasis { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRPTOT_COMMENT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("comment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Comment { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRPTOT_EFFECTIVE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effectiveDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset EffectiveDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRPTOT_BUDGET
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budget", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Budget { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRPTOT_STATUS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Status { get; set; } = default!;

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