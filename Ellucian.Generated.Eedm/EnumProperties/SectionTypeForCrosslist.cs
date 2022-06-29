// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of section types for crosslist
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SectionTypeForCrosslist
    {
        /// <summary>
        /// Primary Section
        /// </summary>
        [EnumMember(Value = "primary")]
        Primary,

        /// <summary>
        /// Secondary Section
        /// </summary>
        [EnumMember(Value = "secondary")]
        Secondary
    }
}