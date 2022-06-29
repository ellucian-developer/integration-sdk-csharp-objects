// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Preference
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PersonPreference
    {
        /// <summary>
        /// Primary phone.
        /// </summary>
        [EnumMember(Value = "primary")]
        Primary
    }
}
