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

namespace Ellucian.Generated.BpApi.Ban._20172018ApplicantOverrideV100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class _20172018ApplicantOverrideV100PutRequest
    {
        /// <summary>
        /// Lineage reference object : RNROVRD_CHG_DEPEND_FM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chgDependFm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ChgDependFm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_TUIT_EXP_IM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parTuitExpIm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ParTuitExpIm { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("seqNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SeqNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_CHG_DEPEND_IM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chgDependIm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ChgDependIm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_OTH_ASSET_IM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parOthAssetIm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ParOthAssetIm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_ASSET_ALLOW_IM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("assetAllowIm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AssetAllowIm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_CALC_US_TAX_IM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("calcUsTaxIm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CalcUsTaxIm { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("verificationMessage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VerificationMessage { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_BUDG_DUR_IM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budgDurIm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BudgDurIm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_MED_DENT_EXP_IM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parMedDentExpIm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ParMedDentExpIm { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("lockCurrRecord", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LockCurrRecord { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblckStudentId
        /// </summary>
        [Newtonsoft.Json.JsonProperty("studentId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? StudentId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_BUDG_DUR_FM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budgDurFm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BudgDurFm { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("fmRecord", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FmRecord { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_OTH_INC_ALLOW_IM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parOthIncAllowIm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ParOthIncAllowIm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_MED_DENT_EXP_IM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("medDentExpIm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MedDentExpIm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_CALC_PC_IM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("calcPcIm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CalcPcIm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_OTH_INC_ALLOW_IM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("othIncAllowIm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OthIncAllowIm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_CALC_PC_FM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("calcPcFm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CalcPcFm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_OTH_ASSET_IM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("othAssetIm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OthAssetIm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_ASSET_ALLOW_IM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parAssetAllowIm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ParAssetAllowIm { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : RNROVRD_PAR_CALC_US_TAX_IM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parCalcUsTaxIm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ParCalcUsTaxIm { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("lockIMRecord", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LockIMRecord { get; set; } = default!;

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