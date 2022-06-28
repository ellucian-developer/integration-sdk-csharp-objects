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

namespace Ellucian.Generated.BpApi.Ban.EmployeeJobsJobLaborDistribution100GetRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class EmployeeJobsJobLaborDistribution100GetRequest
    {
        /// <summary>
        /// Lineage reference object : NBRJLBD_PROJ_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("projCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProjCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRJLBD_ENC_OVERRIDE_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("encOverrideEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EncOverrideEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRJLBD_ACCT_CODE_EXTERNAL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCodeExternal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCodeExternal { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRJLBD_ACCI_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acciCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcciCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRJLBD_COAS_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coasCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoasCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRJLBD_LOCN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("locnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LocnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRJLBD_ORGN_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orgnCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrgnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRJLBD_ACCT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRJLBD_PERCENT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("percent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Percent { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : posn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("posn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Posn { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : queryDate
        /// </summary>
        [Newtonsoft.Json.JsonProperty("queryDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset QueryDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : suff
        /// </summary>
        [Newtonsoft.Json.JsonProperty("suff", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Suff { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRJLBD_FUND_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fundCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FundCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRJLBD_PROG_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("progCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProgCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRJLBD_CTYP_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ctypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CtypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Id { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : NBRJLBD_ACTV_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("actvCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ActvCode { get; set; } = default!;

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