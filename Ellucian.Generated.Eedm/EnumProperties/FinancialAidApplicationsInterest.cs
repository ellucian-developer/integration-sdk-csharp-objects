// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The interest of a financial aid applicant.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FinancialAidApplicationsInterest
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,
        
        /// <summary>
        /// interested
        /// </summary>
        [EnumMember(Value = "interested")]
        Interested,

        /// <summary>
        /// not interested
        /// </summary>
        [EnumMember(Value = "notInterested")]
        NotInterested,
    }
}
