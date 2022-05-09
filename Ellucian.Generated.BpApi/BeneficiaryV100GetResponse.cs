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

namespace Ellucian.Generated.BpApi.Ban.BeneficiaryV100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BeneficiaryV100GetResponse
    {
        /// <summary>
        /// Lineage reference object : PDRBENE_BREL_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brelCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BrelCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PDRBENE_ADDED_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addedDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? AddedDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PDRBENE_SEQ_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seqNo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double SeqNo { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("mrtlDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MrtlDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("persAge", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PersAge { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("beneMi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BeneMi { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvmrtl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("beneMrtlCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BeneMrtlCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PDRBENE_SPOUSE_EMPLOYED_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spouseEmployedInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SpouseEmployedInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("beneSsn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BeneSsn { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("birthDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? BirthDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("brelDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BrelDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PDRBENE_COLLEGE_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("collegeEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CollegeEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PDRBENE_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PDRBENE_COLLEGE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("collegeInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CollegeInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PDRBENE_COLLEGE_BEGIN_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("collegeBeginDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CollegeBeginDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PDRBENE_DISABILITY_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("disabilityInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisabilityInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PDRBENE_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PDRBENE_ACA_CHILD_REPORT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acaChildReportInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcaChildReportInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PDRBENE_ACTIVE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activeInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ActiveInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("beneIdNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BeneIdNo { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("beneFirstName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BeneFirstName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : PDRBENE_MEMBER_TYPE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("memberType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MemberType { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("sexInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SexInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("beneLastName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BeneLastName { get; set; } = default!;

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