//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
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

namespace Ellucian.Generated.BpApi.Ban.PurchaseOrderBalancingCompletionV100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PurchaseOrderBalancingCompletionV100GetResponse
    {
        /// <summary>
        /// Lineage reference object : displayCurrCode, Lookup lineage reference object : gtvcurr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("displayCurrCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? DisplayCurrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : apprStatus
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apprStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? ApprStatus { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : headDisc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("headDisc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? HeadDisc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : discStatus
        /// </summary>
        [Newtonsoft.Json.JsonProperty("discStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? DiscStatus { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : acctDisc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctDisc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? AcctDisc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : addlStatus
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addlStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? AddlStatus { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : displayCurrDesc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("displayCurrDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? DisplayCurrDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : headAppr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("headAppr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? HeadAppr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : acctAppr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctAppr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? AcctAppr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : commDisc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commDisc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? CommDisc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : headTax
        /// </summary>
        [Newtonsoft.Json.JsonProperty("headTax", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? HeadTax { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : acctTax
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctTax", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? AcctTax { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : taxStatus
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taxStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? TaxStatus { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : commAddl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commAddl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? CommAddl { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : displayConvRate
        /// </summary>
        [Newtonsoft.Json.JsonProperty("displayConvRate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? DisplayConvRate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : acctAddl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctAddl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? AcctAddl { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : commAppr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commAppr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? CommAppr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : commTax
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commTax", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? CommTax { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : fpbpohdMatchBlkRequired
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fpbpohdMatchBlkRequired", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object FpbpohdMatchBlkRequired { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : headAddl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("headAddl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? HeadAddl { get; set; } = default!;

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