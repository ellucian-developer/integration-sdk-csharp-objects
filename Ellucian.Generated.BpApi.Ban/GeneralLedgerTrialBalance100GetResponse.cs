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

namespace Ellucian.Generated.BpApi.Ban.GeneralLedgerTrialBalance100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GeneralLedgerTrialBalance100GetResponse
    {
        [Newtonsoft.Json.JsonProperty("fgvtbl1_block", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Fgvtbl1_block>? Fgvtbl1_block { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("fgvtbl1_block_tot", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Fgvtbl1_block_tot>? Fgvtbl1_block_tot { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Fgvtbl1_block
    {
        [Newtonsoft.Json.JsonProperty("displayBegBal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DisplayBegBal { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGVTBL1_ACCT_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fgvtbl1AcctTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Fgvtbl1AcctTitle { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("begDrCrDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BegDrCrDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("curDrCrDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CurDrCrDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayBegBalDrCr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayBegBalDrCr { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayCurrBalDrCr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayCurrBalDrCr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FGVTBL1_ACCT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fgvtbl1AcctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Fgvtbl1AcctCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayCurrBal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DisplayCurrBal { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Fgvtbl1_block_tot
    {
        /// <summary>
        /// Lineage reference object : totalTitle
        /// </summary>
        [Newtonsoft.Json.JsonProperty("totalTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TotalTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : displayTotCurrDrCr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("displayTotCurrDrCr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayTotCurrDrCr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : holdCurrTot
        /// </summary>
        [Newtonsoft.Json.JsonProperty("holdCurrTot", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? HoldCurrTot { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : begTotDrCrDesc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begTotDrCrDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BegTotDrCrDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : holdBegTot
        /// </summary>
        [Newtonsoft.Json.JsonProperty("holdBegTot", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? HoldBegTot { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : curTotDrCrDesc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("curTotDrCrDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CurTotDrCrDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : displayTotBegDrCr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("displayTotBegDrCr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayTotBegDrCr { get; set; } = default!;

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