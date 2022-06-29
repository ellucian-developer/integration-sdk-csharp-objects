// Copyright 2020 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The type of advanced search (advancedSearchAvailable or advancedSearchRequired).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AdvanceSearchType
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// With Benefits
        /// </summary>
        [EnumMember(Value = "advancedSearchAvailable")]
        AdvancedSearchAvailable,

        /// <summary>
        /// Without Benefits
        /// </summary>
        [EnumMember(Value = "advancedSearchRequired")]
        AdvancedSearchRequired
    }
}