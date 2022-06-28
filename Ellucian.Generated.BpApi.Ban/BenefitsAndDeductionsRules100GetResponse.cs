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

namespace Ellucian.Generated.BpApi.Ban.BenefitsAndDeductionsRules100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BenefitsAndDeductionsRules100GetResponse
    {
        /// <summary>
        /// Lineage reference object : PTRBDCA_AMT1_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt1Ind", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Amt1Ind { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_AMT1_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt1Desc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Amt1Desc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_AMT5_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt5Title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Amt5Title { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_BDTY_CODE, Lookup lineage reference object : ptvbdty
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bdtyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BdtyCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_WEEK5_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("week5Ind", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Week5Ind { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_AMT5_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt5Ind", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Amt5Ind { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_OPTION2_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("option2Ind", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Option2Ind { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_OPTION5_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("option5Ind", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Option5Ind { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_WEEK2_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("week2Ind", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Week2Ind { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_YTD_START_MONTH
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ytdStartMonth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? YtdStartMonth { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_BDCL_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bdclCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BdclCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_OVERLOAD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("overloadInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OverloadInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_AMT6_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt6Title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Amt6Title { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_ACA_MLY_PREM_SELF_AMT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acaMlyPremSelfAmt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AcaMlyPremSelfAmt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_AMT2_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt2Ind", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Amt2Ind { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_DISP_WEB_PAYSTUB_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dispWebPaystubInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DispWebPaystubInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_AMT3_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt3Desc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Amt3Desc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_AMT6_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt6Ind", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Amt6Ind { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_WEEK4_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("week4Ind", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Week4Ind { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_PRIORITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("priority", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Priority { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_OPTION1_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("option1Ind", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Option1Ind { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_AMT4_WEB_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt4WebDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Amt4WebDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_OPTION1_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("option1Title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Option1Title { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_OPTION4_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("option4Title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Option4Title { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_OPTION1_WEB_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("option1WebDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Option1WebDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_AMT2_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt2Desc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Amt2Desc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_WEEK1_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("week1Ind", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Week1Ind { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_SHORT_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shortDesc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ShortDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_AMT2_WEB_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt2WebDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Amt2WebDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_AMT6_WEB_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt6WebDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Amt6WebDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_BENEFICIARY_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("beneficiaryInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BeneficiaryInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_1099_CODE, Lookup lineage reference object : ptv1099
        /// </summary>
        [Newtonsoft.Json.JsonProperty("1099Code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? _1099Code { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_OPTION5_WEB_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("option5WebDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Option5WebDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_AMT3_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt3Ind", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Amt3Ind { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_COVERAGE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coverageInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CoverageInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_OPTION3_WEB_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("option3WebDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Option3WebDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_OPTION4_WEB_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("option4WebDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Option4WebDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_CALC_RULE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("calcRule", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CalcRule { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_AMT5_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt5Desc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Amt5Desc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_AMT7_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt7Ind", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Amt7Ind { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_OPTION2_WEB_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("option2WebDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Option2WebDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_AMT2_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt2Title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Amt2Title { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_OPTION3_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("option3Title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Option3Title { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_OPTION4_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("option4Ind", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Option4Ind { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_APPLGROSS_WPAYSTB_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applgrossWpaystbInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ApplgrossWpaystbInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_ACA_OFFER_COVERAGE_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acaOfferCoverageCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcaOfferCoverageCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_AMT7_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt7Desc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Amt7Desc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_AMT3_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt3Title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Amt3Title { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_AMT4_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt4Desc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Amt4Desc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_ARREAR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("arrearInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ArrearInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_ACA_4980H_SAFE_HBR_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aca4980hSafeHbrCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Aca4980hSafeHbrCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_OPTION2_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("option2Title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Option2Title { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_ACA_HEALTH_PROVIDR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acaHealthProvidrInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcaHealthProvidrInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_AMT1_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt1Title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Amt1Title { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_WEB_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_AMT4_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt4Title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Amt4Title { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_AMT7_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt7Title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Amt7Title { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_OPTION5_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("option5Title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Option5Title { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_AMT4_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt4Ind", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Amt4Ind { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_OPTION3_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("option3Ind", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Option3Ind { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_WEB_INFO_URL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webInfoUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? WebInfoUrl { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_AMT3_WEB_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt3WebDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Amt3WebDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_AMT5_WEB_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt5WebDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Amt5WebDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_WEEK3_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("week3Ind", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Week3Ind { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_BENEFIT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("benefitInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BenefitInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_TXCD_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("txcdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TxcdCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("bdclDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BdclDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_AMT1_WEB_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt1WebDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Amt1WebDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_AMT7_WEB_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt7WebDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Amt7WebDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_AMT6_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amt6Desc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Amt6Desc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PTRBDCA_LONG_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("longDesc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LongDesc { get; set; } = default!;

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