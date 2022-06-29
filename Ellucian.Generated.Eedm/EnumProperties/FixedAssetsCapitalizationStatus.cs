// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The capitalization status of the fixed asset.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FixedAssetsCapitalizationStatus
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// capitalized
        /// </summary>
        [EnumMember(Value = "capitalized")]
        Capitalized,

        /// <summary>
        /// uncapitalized
        /// </summary>
        [EnumMember(Value = "uncapitalized")]
        Uncapitalized,

        /// <summary>
        /// nonCapital
        /// </summary>
        [EnumMember(Value = "nonCapital")]
        Noncapital,
    }
}