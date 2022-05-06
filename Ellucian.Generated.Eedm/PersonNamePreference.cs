// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible person name preferences
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PersonNamePreference
    {
        /// <summary>
        /// personal
        /// </summary>
        [EnumMember(Value = "preferred")]
        Preferred
    }
}