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

namespace Ellucian.Generated.BpApi.Ban._1098TTaxInformations100QapiPost
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class _1098TTaxInformations100QapiPost
    {
        /// <summary>
        /// Lineage reference object : TTB1098_TRAN_TIN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tranTin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TranTin { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_TRAN_CO_ZIP_CODE, Lookup lineage reference object : gtvzipc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tranCoZipCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TranCoZipCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_TRAN_FOREIGN_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tranForeignInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TranForeignInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_TRAN_CO_NATN_CODE, Lookup lineage reference object : stvnatn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tranCoNatnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TranCoNatnCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("tranCoNatnDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TranCoNatnDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_TRAN_CTRL_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tranCtrlCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TranCtrlCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_TRAN_NAME1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tranName1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TranName1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_TRAN_CO_NAME1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tranCoName1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TranCoName1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_TRAN_NAME2
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tranName2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TranName2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_TRAN_CO_NAME2
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tranCoName2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TranCoName2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_TRAN_CONT_NAME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tranContName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TranContName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_TRAN_CO_ADDRESS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tranCoAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TranCoAddress { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_TRAN_CONT_PH_AREA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tranContPhArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TranContPhArea { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_TRAN_CONT_PH_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tranContPhNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TranContPhNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_TRAN_CONT_PH_EXT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tranContPhExt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TranContPhExt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_TRAN_CO_CITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tranCoCity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TranCoCity { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_TRAN_CONT_EMAIL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tranContEmail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TranContEmail { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_TRAN_CO_ST_CODE, Lookup lineage reference object : stvstat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tranCoStCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TranCoStCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_INST_TIN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instTin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InstTin { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_INST_ST_CODE, Lookup lineage reference object : stvstat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instStCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InstStCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_INST_FOREIGN_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instForeignInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InstForeignInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_INST_ZIP_CODE, Lookup lineage reference object : gtvzipc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instZipCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InstZipCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_INST_NAME1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instName1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InstName1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_INST_NATN_CODE, Lookup lineage reference object : stvnatn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instNatnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InstNatnCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("instNatnDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InstNatnDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_INST_NAME2
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instName2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InstName2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_INST_CONT_PH_AREA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instContPhArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InstContPhArea { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_INST_CONT_PH_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instContPhNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InstContPhNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_INST_CONT_PH_EXT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instContPhExt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InstContPhExt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_INST_ADDRESS1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instAddress1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InstAddress1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_INST_NAME_CTRL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instNameCtrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InstNameCtrl { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_INST_ADDRESS2
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instAddress2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InstAddress2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_INST_OFFICE_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instOfficeCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InstOfficeCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTB1098_INST_CITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instCity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InstCity { get; set; } = default!;

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