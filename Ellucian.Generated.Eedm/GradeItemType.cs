// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A type of Literal
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GradeItemType
    {
        /// <summary>
        /// Literal
        /// </summary>
        [EnumMember(Value = "literal")]
        Literal
    }
}