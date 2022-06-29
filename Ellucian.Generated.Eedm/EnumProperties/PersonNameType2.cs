// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible person name types
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PersonNameType2
    {
        /// <summary>
        /// personal
        /// </summary>
        [EnumMember(Value = "personal")]
        Personal,
        /// <summary>
        /// birth
        /// </summary>
        [EnumMember(Value = "birth")]
        Birth,
        /// <summary>
        /// legal
        /// </summary>
        [EnumMember(Value = "legal")]
        Legal,
        /// <summary>
        /// favored
        /// </summary>
        [EnumMember(Value = "favored")]
        Favored
    }
}