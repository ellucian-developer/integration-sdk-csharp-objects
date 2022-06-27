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

namespace Ellucian.Generated.BpApi.Ban.GeneralEncumbranceMaintenanceV100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GeneralEncumbranceMaintenanceV100PutRequest
    {
        [Newtonsoft.Json.JsonProperty("distributeInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DistributeInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.distributeInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaDistributeInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBENCH_ESTAB_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.estabDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CriteriaEstabDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBENCH_EDIT_DEFERRAL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.editDeferral", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaEditDeferral { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBENCH_STATUS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.statusInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaStatusInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : documentNumber
        /// </summary>
        [Newtonsoft.Json.JsonProperty("documentNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DocumentNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBENCH_CHANGE_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("changeDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ChangeDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendorId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendorId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBENCH_TYPE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBENCH_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.desc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBENCH_DOC_REF_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.docRefNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaDocRefNum { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBENCH_EDIT_DEFERRAL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("editDeferral", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EditDeferral { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBENCH_STATUS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statusInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatusInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBENCH_TRANS_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset TransDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBENCH_DOC_REF_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("docRefNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DocRefNum { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.vendorId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaVendorId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBENCH_NSF_ON_OFF_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.nsfOnOffInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaNsfOnOffInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBENCH_NSF_ON_OFF_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nsfOnOffInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NsfOnOffInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBENCH_DOC_CHANGE_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.docChangeNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaDocChangeNum { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBENCH_TRANS_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.transDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CriteriaTransDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBENCH_CHANGE_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.changeDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaChangeDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBENCH_ESTAB_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("estabDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset EstabDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBENCH_DOC_CHANGE_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("docChangeNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DocChangeNum { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBENCH_TYPE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaType { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGBENCH_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Desc { get; set; } = default!;

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