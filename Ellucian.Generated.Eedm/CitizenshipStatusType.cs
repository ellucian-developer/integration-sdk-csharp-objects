// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible types of an Citizenship Status
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CitizenshipStatusType
    {
        /// <summary>
        /// Citizen
        /// </summary>
        [EnumMember(Value = "citizen")]
        Citizen,

        /// <summary>
        /// Non-citizen
        /// </summary>
        [EnumMember(Value = "nonCitizen")]
        NonCitizen,
    }
}