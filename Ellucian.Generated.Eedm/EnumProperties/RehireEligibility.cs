// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible eligibility statuses for being rehired.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RehireEligibility
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// Eligible
        /// </summary>
        [EnumMember(Value = "eligible")]
        Eligible,

        /// <summary>
        /// Ineligible
        /// </summary>
        [EnumMember(Value = "ineligible")]
        Ineligible
    }
}