// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The possible types of indicators if the position is exempt or non-exempt.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExemptionType
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// Exempt
        /// </summary>
        [EnumMember(Value = "exempt")]
        Exempt,

        /// <summary>
        /// Non-Exempt
        /// </summary>
        [EnumMember(Value = "nonExempt")]
        NonExempt
       
    }
}