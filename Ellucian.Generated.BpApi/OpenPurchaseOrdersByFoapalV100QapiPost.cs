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

namespace Ellucian.Generated.BpApi.Ban.OpenPurchaseOrdersByFoapalV100QapiPost
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OpenPurchaseOrdersByFoapalV100QapiPost
    {
        [Newtonsoft.Json.JsonProperty("displayAcciCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayAcciCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayAcctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayAcctCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayActvCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayActvCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayCoasCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DisplayCoasCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayFundCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayFundCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayLocnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayLocnCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayOrgnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayOrgnCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayProgCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayProgCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayProjCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayProjCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPRPODT_COMM_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CommCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPRPODT_ITEM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Item { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPRPODT_POHD_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pohdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PohdCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPRPODT_QTY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qty", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Qty { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPRPODT_UNIT_PRICE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unitPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UnitPrice { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FPRPODT_UOMS_CODE, Lookup lineage reference object : ftvuoms
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uomsCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UomsCode { get; set; } = default!;

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