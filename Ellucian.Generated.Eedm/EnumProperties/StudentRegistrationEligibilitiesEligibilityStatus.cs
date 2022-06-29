// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The indication if the student is eligible to register for the academic period.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StudentRegistrationEligibilitiesEligibilityStatus
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// eligible
        /// </summary>
        [EnumMember(Value = "eligible")]
        Eligible,

        /// <summary>
        /// ineligible
        /// </summary>
        [EnumMember(Value = "ineligible")]
        Ineligible,
    }
}


