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

namespace Ellucian.Generated.BpApi.Ban.ContractReview100GetRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ContractReview100GetRequest
    {
        /// <summary>
        /// Lineage reference object : TBVCONR_CHARGE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("charge", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Charge { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBVCONR_STU_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stuId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StuId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : idstudent
        /// </summary>
        [Newtonsoft.Json.JsonProperty("idstudent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Idstudent { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBVCONR_CROSSREF_DETAIL_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crossrefDetailCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CrossrefDetailCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocTermCode, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocTermCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblocTermCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBVCONR_REFUND_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refundInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RefundInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : contractNumber
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contractNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ContractNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBVCONR_TRAN_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tranNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TranNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBVCONR_DETAIL_CODE, Lookup lineage reference object : tbbdetc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detailCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DetailCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBVCONR_FINAL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finalInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FinalInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBVCONR_CROSSREF_SRCE_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crossrefSrceCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CrossrefSrceCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBVCONR_STU_NAME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbvrconrStuName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TbvrconrStuName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBVCONR_BALANCE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("balance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Balance { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBVCONR_TRANS_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TransDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBVCONR_PAYMENT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Payment { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBVCONR_CROSSREF_DCAT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crossrefDcatCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CrossrefDcatCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Id { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBVCONR_CPDT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cpdtInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CpdtInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBVCONR_DETAIL_TRAN_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detailTranNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DetailTranNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBVCONR_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Desc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBVCONR_TERM_CODE, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBVCONR_CONT_NUMBER, Lookup lineage reference object : tbbcont
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ContNumber { get; set; } = default!;

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