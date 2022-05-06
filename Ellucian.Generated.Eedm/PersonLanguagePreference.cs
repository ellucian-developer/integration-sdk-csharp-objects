// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of language preference indicator.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PersonLanguagePreference
    {
        /// <summary>
        /// Primary
        /// </summary>
        [EnumMember(Value = "primary")]
        Primary,
        /// <summary>
        /// Secondary.
        /// </summary>
        [EnumMember(Value = "secondary")]
        Secondary
    }
}