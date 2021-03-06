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

namespace Ellucian.Generated.BpApi.Ban.ApplicantPellGrant100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ApplicantPellGrant100PutRequest
    {
        /// <summary>
        /// Lineage reference object : RORSTAT_VER_PAY_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verPayInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VerPayInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_PELL_LT_HALF_COA
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pellLtHalfCoa", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PellLtHalfCoa { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_PELL_DISB_LOCK_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pellDisbLockInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PellDisbLockInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_PRI_SAR_PGI
        /// </summary>
        [Newtonsoft.Json.JsonProperty("priSarPgi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PriSarPgi { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_APRD_CODE_PELL, Lookup lineage reference object : rtvaprd,robaprd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aprdCodePell", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AprdCodePell { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_SAR_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sarDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? SarDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("sarSsnV", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SarSsnV { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblckAidyCode, Lookup lineage reference object : robinst
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckAidyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblckAidyCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_SAR_TRAN_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sarTranNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SarTranNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblckId
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblckId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_SEC_SAR_PGI
        /// </summary>
        [Newtonsoft.Json.JsonProperty("secSarPgi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SecSarPgi { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displaySarInit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplaySarInit { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RORSTAT_AUTO_ZERO_EFC_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("autoZeroEfcInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AutoZeroEfcInd { get; set; } = default!;

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