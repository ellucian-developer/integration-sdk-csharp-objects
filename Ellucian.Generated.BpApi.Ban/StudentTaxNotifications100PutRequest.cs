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

namespace Ellucian.Generated.BpApi.Ban.StudentTaxNotifications100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class StudentTaxNotifications100PutRequest
    {
        /// <summary>
        /// Lineage reference object : TTBTAXN_FUTURE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("futureInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FutureInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaUserId { get; set; } = default!;

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
        /// Lineage reference object : taxYear
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taxYear", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TaxYear { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_IRS_REPORT_STATUS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.irsReportStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaIrsReportStatus { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_MI
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.mi", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaMi { get; set; } = default!;

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
        /// Lineage reference object : TTBTAXN_LAST_NAME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.lastName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaLastName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_ZIP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.zip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaZip { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.natnDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaNatnDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_SSN_CERT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.ssnCertInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaSsnCertInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_FUTURE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.futureInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaFutureInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_FIRST_NAME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("firstName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_GRAD_STUD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.gradStudInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaGradStudInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_GRAD_STUD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gradStudInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GradStudInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_AMOUNT_4
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.amount4", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CriteriaAmount4 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_AMOUNT_3
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.amount3", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CriteriaAmount3 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_SSN_CERT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssnCertInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsnCertInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_AMOUNT_6
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.amount6", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CriteriaAmount6 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_AMOUNT_5
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.amount5", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CriteriaAmount5 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_AMOUNT_2
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.amount2", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CriteriaAmount2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_AMOUNT_1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.amount1", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CriteriaAmount1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_LAST_NAME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lastName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_CITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? City { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_FIRST_NAME
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.firstName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaFirstName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_STUD_NOTIF_STATUS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.studNotifStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaStudNotifStatus { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_REMOVE_NOTIF_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("removeNotifInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RemoveNotifInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_IRS_REPORT_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.irsReportDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaIrsReportDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_REMOVE_NOTIF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.removeNotifDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaRemoveNotifDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_NATN_CODE, Lookup lineage reference object : stvnatn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.natnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaNatnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblckStudentId
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblckStudentId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblckStudentId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_CITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.city", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaCity { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_STUD_NOTIF_STATUS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("studNotifStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StudNotifStatus { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_SSN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.ssn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaSsn { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_STAT_CODE, Lookup lineage reference object : stvstat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_ADDR_LINE3
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.addrLine3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaAddrLine3 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_NATN_CODE, Lookup lineage reference object : stvnatn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("natnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NatnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_ADDR_LINE2
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.addrLine2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaAddrLine2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_ADDR_LINE1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.addrLine1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaAddrLine1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_HALF_TIME_ENRL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("halfTimeEnrlInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HalfTimeEnrlInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_STUD_NOTIF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.studNotifDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CriteriaStudNotifDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_REMOVE_NOTIF_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.removeNotifInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaRemoveNotifInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.methodChanged", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaMethodChanged { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TTBTAXN_STAT_CODE, Lookup lineage reference object : stvstat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.statCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaStatCode { get; set; } = default!;

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
        /// Lineage reference object : TTBTAXN_HALF_TIME_ENRL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.halfTimeEnrlInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CriteriaHalfTimeEnrlInd { get; set; } = default!;

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