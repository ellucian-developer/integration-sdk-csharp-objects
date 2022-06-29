// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The indendence criteria for financial aid applicant.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FinancialAidApplicationsIndependenceCriteria
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// risk of homelessness
        /// </summary>
        [EnumMember(Value = "riskOfHomelessness")]
        RiskOfHomelessness,

        /// <summary>
        /// advanced degree student
        /// </summary>
        [EnumMember(Value = "advancedDegreeStudent")]
        AdvancedDegreeStudent,

        /// <summary>
        /// supporting children
        /// </summary>
        [EnumMember(Value = "supportingChildren")]
        SupportingChildren,

        /// <summary>
        /// supporting dependents
        /// </summary>
        [EnumMember(Value = "supportingDependents")]
        SupportingDependents,

        /// <summary>
        /// orphan ward of court foster care
        /// </summary>
        [EnumMember(Value = "orphanWardOfCourtFosterCare")]
        OrphanWardOfCourtFosterCare,

        /// <summary>
        /// emancipated minor
        /// </summary>
        [EnumMember(Value = "emancipatedMinor")]
        EmancipatedMinor,

        /// <summary>
        /// legal guardianship
        /// </summary>
        [EnumMember(Value = "legalGuardianship")]
        LegalGuardianship,

        /// <summary>
        /// unaccompanied youth by school
        /// </summary>
        [EnumMember(Value = "unaccompaniedYouthBySchool")]
        UnaccompaniedYouthBySchool,

        /// <summary>
        /// unaccompanied youth by HUD
        /// </summary>
        [EnumMember(Value = "unaccompaniedYouthByHud")]
        UnaccompaniedYouthByHud,

        /// <summary>
        /// independent age
        /// </summary>
        [EnumMember(Value = "independentAge")]
        IndependentAge,

        /// <summary>
        /// married
        /// </summary>
        [EnumMember(Value = "married")]
        Married,

        /// <summary>
        /// veteran
        /// </summary>
        [EnumMember(Value = "veteran")]
        Veteran,

        /// <summary>
        /// active duty
        /// </summary>
        [EnumMember(Value = "activeDuty")]
        ActiveDuty
    }
}
