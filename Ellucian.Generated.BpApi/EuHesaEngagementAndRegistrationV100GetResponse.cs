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

namespace Ellucian.Generated.BpApi.Ban.EuHesaEngagementAndRegistrationV100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class EuHesaEngagementAndRegistrationV100GetResponse
    {
        [Newtonsoft.Json.JsonProperty("sobenga", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Sobenga>? Sobenga { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("sobencp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Sobencp>? Sobencp { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("sobscaa", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Sobscaa>? Sobscaa { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("sobrelv", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Sobrelv>? Sobrelv { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("sobresi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Sobresi>? Sobresi { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Sobenga
    {
        /// <summary>
        /// Lineage reference object : SOBENGA_RC_STU_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rcStuId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RcStuId { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeFeeEligSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeFeeEligSt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBENGA_SSDT_CODE_LEAD_SCHOOL, Lookup lineage reference object : skvssdt,skvssdt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeLeadSchool", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeLeadSchool { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeFeeStatusSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeFeeStatusSt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeIncExchangeSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeIncExchangeSt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBENGA_SSDT_CODE_RC_STU, Lookup lineage reference object : skvssdt,skvssdt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeRcStu", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeRcStu { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBENGA_SSDT_CODE_FEE_ELIG, Lookup lineage reference object : skvssdt,skvssdt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeFeeElig", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeFeeElig { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBENGA_SSDT_CODE_ENTRYRTE, Lookup lineage reference object : skvssdt,skvssdt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeEntryrte", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeEntryrte { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBENGA_TEACHER_REF_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("teacherRefNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TeacherRefNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBENGA_OWN_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ownId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OwnId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBENGA_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBENGA_INST_NUMHUS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instNumhus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InstNumhus { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBENGA_SSDT_CODE_FEE_STATUS, Lookup lineage reference object : skvssdt,skvssdt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeFeeStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeFeeStatus { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeRcStuSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeRcStuSt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBENGA_SSDT_CODE_EMP_SCHOOL, Lookup lineage reference object : skvssdt,skvssdt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeEmpSchool", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeEmpSchool { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBENGA_INTENTION_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intentionEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? IntentionEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBENGA_SSDT_CODE_QTS, Lookup lineage reference object : skvssdt,skvssdt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeQts", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeQts { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBENGA_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeEmpSchoolSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeEmpSchoolSt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBENGA_SSDT_CODE_STDYINTNTN, Lookup lineage reference object : skvssdt,skvssdt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeStdyintntn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeStdyintntn { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeQtsSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeQtsSt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeStdyintntnSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeStdyintntnSt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBENGA_SSDT_CODE_INC_EXCHANGE, Lookup lineage reference object : skvssdt,skvssdt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeIncExchange", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeIncExchange { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBENGA_SSDT_CODE_NHS_EMPLOYER, Lookup lineage reference object : skvssdt,skvssdt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeNhsEmployer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeNhsEmployer { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeEntryrteSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeEntryrteSt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeLeadSchoolSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeLeadSchoolSt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeNhsEmployerSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeNhsEmployerSt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBENGA_START_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? StartDate { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Sobencp
    {
        /// <summary>
        /// Lineage reference object : SOBENCP_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBENCP_PARTNER_SID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partnerSid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PartnerSid { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBENCP_PARTNER_UKPRN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partnerUkprn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PartnerUkprn { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBENCP_PARTNER_NUMHUS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partnerNumhus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PartnerNumhus { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeColprotypIdSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeColprotypIdSt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBENCP_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBENCP_SSDT_CODE_COLPROTYP_ID, Lookup lineage reference object : skvssdt,skvssdt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeColprotypId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeColprotypId { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Sobscaa
    {
        /// <summary>
        /// Lineage reference object : SOBSCAA_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBSCAA_SSDT_CODE_ACCRED_ID, Lookup lineage reference object : skvssdt,skvssdt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeAccredId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SsdtCodeAccredId { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeAccredIdSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeAccredIdSt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBSCAA_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Sobrelv
    {
        /// <summary>
        /// Lineage reference object : SOBRELV_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeRsnEngendSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeRsnEngendSt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBRELV_ENG_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("engEndDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset EngEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBRELV_INTENDED_DESTINATION
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intendedDestination", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IntendedDestination { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBRELV_SSDT_CODE_RSN_ENGEND, Lookup lineage reference object : skvssdt,skvssdt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeRsnEngend", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SsdtCodeRsnEngend { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBRELV_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Sobresi
    {
        /// <summary>
        /// Lineage reference object : SOBRESI_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBRESI_SSDT_CODE_INIT_ID, Lookup lineage reference object : skvssdt,skvssdt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeInitId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SsdtCodeInitId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBRESI_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeInitIdSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeInitIdSt { get; set; } = default!;

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