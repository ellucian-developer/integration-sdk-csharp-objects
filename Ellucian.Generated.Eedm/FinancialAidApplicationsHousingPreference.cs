// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The housing preference of a financial aid applicant.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FinancialAidApplicationsHousingPreference
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// on campus
        /// </summary>
        [EnumMember(Value = "onCampus")]
        OnCampus,

        /// <summary>
        /// off campus
        /// </summary>
        [EnumMember(Value = "offCampus")]
        OffCampus,

        /// <summary>
        /// with parents
        /// </summary>
        [EnumMember(Value = "withParents")]
        WithParents,

        /// <summary>
        /// with relatives
        /// </summary>
        [EnumMember(Value = "withRelatives")]
        WithRelatives,
    }
}
