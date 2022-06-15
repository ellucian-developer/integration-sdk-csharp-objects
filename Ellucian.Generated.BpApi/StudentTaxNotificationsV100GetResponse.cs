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

namespace Ellucian.Generated.BpApi.Ban.StudentTaxNotificationsV100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class StudentTaxNotificationsV100GetResponse
    {
        [Newtonsoft.Json.JsonProperty("ttbtaxn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Ttbtaxn>? Ttbtaxn { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ttvxrpt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Ttvxrpt>? Ttvxrpt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ttvxrcn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Ttvxrcn>? Ttvxrcn { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ttvxrct", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Ttvxrct>? Ttvxrct { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ttrtaxr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Ttrtaxr>? Ttrtaxr { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ttvxsum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Ttvxsum>? Ttvxsum { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Ttbtaxn
    {
        [Newtonsoft.Json.JsonProperty("natnDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NatnDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_FUTURE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("futureInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FutureInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_LAST_NAME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lastName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_CITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? City { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_REMOVE_NOTIF_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("removeNotifInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RemoveNotifInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_IRS_REPORT_STATUS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("irsReportStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IrsReportStatus { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_SSN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Ssn { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_AMOUNT_6
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount6", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Amount6 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_AMOUNT_5
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount5", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Amount5 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_AMOUNT_4
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount4", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Amount4 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_AMOUNT_1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount1", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Amount1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_STUD_NOTIF_STATUS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("studNotifStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StudNotifStatus { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_MI
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mi", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Mi { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_ZIP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("zip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Zip { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_STAT_CODE, Lookup lineage reference object : stvstat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_NATN_CODE, Lookup lineage reference object : stvnatn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("natnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NatnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_STUD_NOTIF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("studNotifDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? StudNotifDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_HALF_TIME_ENRL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("halfTimeEnrlInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HalfTimeEnrlInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("methodChanged", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MethodChanged { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_FIRST_NAME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("firstName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_IRS_REPORT_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("irsReportDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? IrsReportDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_GRAD_STUD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gradStudInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GradStudInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_ADDR_LINE3
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addrLine3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddrLine3 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_ADDR_LINE2
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addrLine2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddrLine2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_ADDR_LINE1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addrLine1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddrLine1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_SSN_CERT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssnCertInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsnCertInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_REMOVE_NOTIF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("removeNotifDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? RemoveNotifDate { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Ttvxrpt
    {
        /// <summary>
        /// Lineage reference object : TTVXRPT_DETAIL_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detailDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DetailDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXRPT_FUTURE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("futureInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FutureInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXRPT_PRO_RATED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("proRated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProRated { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXRPT_FUTURE_IND_SG
        /// </summary>
        [Newtonsoft.Json.JsonProperty("futureIndSg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FutureIndSg { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("taxDateSrc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TaxDateSrc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXRPT_TAX_AMOUNT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taxAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TaxAmount { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXRPT_DETAIL_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detailCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DetailCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXRPT_FUTURE_IND_PR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("futureIndPr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FutureIndPr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXRPT_TAX_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taxDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TaxDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXRPT_TERM_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermCode { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Ttvxrcn
    {
        [Newtonsoft.Json.JsonProperty("equalSign1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EqualSign1 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("minusSign", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MinusSign { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("equalSign2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EqualSign2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXRCN_CURR_DEC_PREV_CHRG
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currDecPrevChrg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CurrDecPrevChrg { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXRCN_PREV_CB
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prevCb", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PrevCb { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXRCN_CURRENT_PR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currentPr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CurrentPr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXRCN_CURRENT_CB
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currentCb", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CurrentCb { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXRCN_ADJUST_PAY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adjustPay", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AdjustPay { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXRCN_CURRENT_REPORT_PR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currentReportPr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CurrentReportPr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXRCN_PREV_REPORT_PR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prevReportPr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PrevReportPr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXRCN_UNREPORTED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unReported", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UnReported { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXRCN_CUM_CB
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cumCb", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CumCb { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXRCN_CAP_PR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("capPr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CapPr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXRCN_CUM_PR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cumPr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CumPr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXRCN_TAX_YEAR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taxYear", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TaxYear { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("addSign1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddSign1 { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Ttvxrct
    {
        [Newtonsoft.Json.JsonProperty("equalSign3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EqualSign3 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXRCT_CUM_CB
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cumCb", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CumCb { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXRCT_PREVIOUS_CB
        /// </summary>
        [Newtonsoft.Json.JsonProperty("previousCb", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PreviousCb { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXRCT_CURRENT_PR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currentPr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CurrentPr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXRCT_CURRENT_CB
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currentCb", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CurrentCb { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("addSign1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddSign1 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("addSign2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddSign2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXRCT_DECREASE_CB
        /// </summary>
        [Newtonsoft.Json.JsonProperty("decreaseCB", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DecreaseCB { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXRCT_TERM_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermCode { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Ttrtaxr
    {
        /// <summary>
        /// Lineage reference object : TTRTAXR_DETAIL_ACCESS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detailAccessInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DetailAccessInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("reptDesc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReptDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTRTAXR_TOTAL_ACCESS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("totalAccessInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TotalAccessInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTRTAXR_REPT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reptCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReptCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("reptTotalAmount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double ReptTotalAmount { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("reptDescDisp2", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReptDescDisp2 { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Ttvxsum
    {
        /// <summary>
        /// Lineage reference object : TTVXSUM_FUTURE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("futureInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FutureInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXSUM_TAX_REPT_BOX_SG
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taxReptBoxSg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TaxReptBoxSg { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("proratedInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProratedInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("taxDateSrc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TaxDateSrc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXSUM_DETAIL_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detailCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DetailCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXSUM_TAX_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taxDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TaxDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXSUM_TAX_REPT_BOX
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taxReptBox", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TaxReptBox { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXSUM_TAX_REPT_YEAR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taxReptYear", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TaxReptYear { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXSUM_DCAT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dcatCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DcatCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXSUM_REPT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reptCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ReptCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXSUM_TAX_AMOUNT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taxAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TaxAmount { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXSUM_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Desc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTVXSUM_TERM_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermCode { get; set; } = default!;

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