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

namespace Ellucian.Generated.BpApi.Ban.EmployeeStatusChangeEmcumbrance100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class EmployeeStatusChangeEmcumbrance100GetResponse
    {
        [Newtonsoft.Json.JsonProperty("pebempl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Pebempl>? Pebempl { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("form_header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Form_header>? Form_header { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Pebempl
    {
        /// <summary>
        /// Lineage reference object : PEBEMPL_FIRST_WORK_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("firstWorkDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FirstWorkDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("lreaDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LreaDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("termBargCbox", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermBargCbox { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PEBEMPL_CURRENT_HIRE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currentHireDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CurrentHireDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PEBEMPL_ADJ_SERVICE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adjServiceDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? AdjServiceDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PEBEMPL_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PEBEMPL_LOA_BEG_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("loaBegDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? LoaBegDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PEBEMPL_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("perbargEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? PerbargEndDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("treaDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TreaDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PEBEMPL_LAST_WORK_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lastWorkDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? LastWorkDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PEBEMPL_LOA_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("loaEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? LoaEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PEBEMPL_TREA_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("treaCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TreaCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PEBEMPL_LREA_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lreaCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LreaCode { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Form_header
    {
        /// <summary>
        /// Lineage reference object : salaryEncumbrance
        /// </summary>
        [Newtonsoft.Json.JsonProperty("salaryEncumbrance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SalaryEncumbrance { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : detailEncumbranceHrs
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detailEncumbranceHrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DetailEncumbranceHrs { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : dataSeparatorLine1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dataSeparatorLine1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DataSeparatorLine1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : contractBeginDate
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contractBeginDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ContractBeginDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : totalSalaryEnc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("totalSalaryEnc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalSalaryEnc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : dataSeparatorLine0
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dataSeparatorLine0", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DataSeparatorLine0 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : contractEndDate
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contractEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ContractEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : totalContractHrs
        /// </summary>
        [Newtonsoft.Json.JsonProperty("totalContractHrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalContractHrs { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : futureSalaryEnc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("futureSalaryEnc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FutureSalaryEnc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : totalEncumbranceHrs
        /// </summary>
        [Newtonsoft.Json.JsonProperty("totalEncumbranceHrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalEncumbranceHrs { get; set; } = default!;

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