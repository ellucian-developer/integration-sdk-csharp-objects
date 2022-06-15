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

namespace Ellucian.Generated.BpApi.Ban.EuHesaEngagementAndRegistrationEntryProfileV100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class EuHesaEngagementAndRegistrationEntryProfileV100GetResponse
    {
        [Newtonsoft.Json.JsonProperty("ssdtCodePrevProvSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodePrevProvSt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORENEP_CREDIT_TOWARDS_STUDY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creditTowardsStudy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CreditTowardsStudy { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORENEP_SSDT_CODE_DEPENDANT, Lookup lineage reference object : skvssdt,skvssdt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeDependant", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeDependant { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeDependantSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeDependantSt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeHighQualSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeHighQualSt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORENEP_SSDT_CODE_CRED_SCHEME, Lookup lineage reference object : skvssdt,skvssdt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeCredScheme", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeCredScheme { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeEstrangedSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeEstrangedSt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORENEP_SSDT_CODE_CARELEAVER, Lookup lineage reference object : skvssdt,skvssdt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeCareleaver", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeCareleaver { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORENEP_SSDT_CODE_PREV_PROV, Lookup lineage reference object : skvssdt,skvssdt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodePrevProv", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodePrevProv { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORENEP_SSDT_CODE_ACCESS_PROG, Lookup lineage reference object : skvssdt,skvssdt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeAccessProg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeAccessProg { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORENEP_SSDT_CODE_SEC, Lookup lineage reference object : skvssdt,skvssdt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeSec", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeSec { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeSecSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeSecSt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORENEP_UCAS_SCHEME_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ucasSchemeCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UcasSchemeCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORENEP_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeCredSchemeSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeCredSchemeSt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeMarStatusSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeMarStatusSt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORENEP_SSDT_CODE_SOC2010, Lookup lineage reference object : skvssdt,skvssdt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeSoc2010", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeSoc2010 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORENEP_SSDT_CODE_APEL_CRED, Lookup lineage reference object : skvssdt,skvssdt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeApelCred", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeApelCred { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORENEP_PERM_ADDR_POSTCODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("permAddrPostcode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PermAddrPostcode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORENEP_YEAR_LAST_PROV
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yearLastProv", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? YearLastProv { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeAccessProgSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeAccessProgSt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeParentEduSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeParentEduSt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeRelBgroundSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeRelBgroundSt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORENEP_SSDT_CODE_PARENT_EDU, Lookup lineage reference object : skvssdt,skvssdt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeParentEdu", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeParentEdu { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORENEP_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORENEP_SSDT_CODE_COUNTRY_PERM, Lookup lineage reference object : skvssdt,skvssdt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeCountryPerm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeCountryPerm { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeCountryPermSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeCountryPermSt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeApelCredSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeApelCredSt { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeCareleaverSt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeCareleaverSt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORENEP_SSDT_CODE_MAR_STATUS, Lookup lineage reference object : skvssdt,skvssdt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeMarStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeMarStatus { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORENEP_SSDT_CODE_ESTRANGED, Lookup lineage reference object : skvssdt,skvssdt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeEstranged", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeEstranged { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORENEP_SSDT_CODE_HIGH_QUAL, Lookup lineage reference object : skvssdt,skvssdt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeHighQual", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeHighQual { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SORENEP_SSDT_CODE_REL_BGROUND, Lookup lineage reference object : skvssdt,skvssdt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssdtCodeRelBground", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeRelBground { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssdtCodeSoc2010St", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsdtCodeSoc2010St { get; set; } = default!;

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