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

namespace Ellucian.Generated.BpApi.Ban.EmployeeLeaveBalancesV100PutRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class EmployeeLeaveBalancesV100PutRequest
    {
        [Newtonsoft.Json.JsonProperty("changeReason", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ChangeReason { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PERLEAV_DATE_AVAIL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dateAvail", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset DateAvail { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.accruedDay", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CriteriaAccruedDay { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PERLEAV_TAKEN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.taken", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CriteriaTaken { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PERLEAV_HRS_BANKED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hrsBanked", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double HrsBanked { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PERLEAV_ACCRUED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.accrued", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CriteriaAccrued { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PERLEAV_BEGIN_BALANCE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("beginBalance", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double BeginBalance { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PERLEAV_LEAV_CODE, Lookup lineage reference object : ptrlvas,ptrleav
        /// </summary>
        [Newtonsoft.Json.JsonProperty("perleavLeavCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PerleavLeavCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PERLEAV_DATE_AVAIL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.dateAvail", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CriteriaDateAvail { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PERLEAV_ACCRUED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accrued", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Accrued { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PERLEAV_TAKEN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taken", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Taken { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.beginBalanceDay", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CriteriaBeginBalanceDay { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Id { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PERLEAV_HRS_BANKED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.hrsBanked", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CriteriaHrsBanked { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PERLEAV_LEAV_CODE, Lookup lineage reference object : ptrlvas,ptrleav
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.leavCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CriteriaLeavCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.hrsBankedDay", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CriteriaHrsBankedDay { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.totalBalanceDay", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CriteriaTotalBalanceDay { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PERLEAV_BEGIN_BALANCE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("criteria.beginBalance", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CriteriaBeginBalance { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("criteria.takenDay", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CriteriaTakenDay { get; set; } = default!;

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