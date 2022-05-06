// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// RequiredPreference
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HousingAssignmentRequiredPreference
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// override
        /// </summary>
        [EnumMember(Value = "override")]
        Override,

        /// <summary>
        /// enforce
        /// </summary>
        [EnumMember(Value = "enforce")]
        Enforce,
    }
}