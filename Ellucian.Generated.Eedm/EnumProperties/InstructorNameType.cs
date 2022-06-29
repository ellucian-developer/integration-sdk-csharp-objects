// Copyright 2015 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible instructor name types
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InstructorNameType
    {
        /// <summary>
        /// Primary
        /// </summary>
        [EnumMember(Value = "primary")]
        Primary
    }
}