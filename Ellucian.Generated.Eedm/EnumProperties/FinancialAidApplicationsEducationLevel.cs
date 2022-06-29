// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The parent education level for financial aid applicant.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FinancialAidApplicationsEducationLevel
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,
        
        /// <summary>
        /// middle school
        /// </summary>
        [EnumMember(Value = "middleSchool")]
        MiddleSchool,

        /// <summary>
        /// high school
        /// </summary>
        [EnumMember(Value = "highSchool")]
        HighSchool,

        /// <summary>
        /// college
        /// </summary>
        [EnumMember(Value = "college")]
        College,

        /// <summary>
        /// other
        /// </summary>
        [EnumMember(Value = "other")]
        Other
    }
}
