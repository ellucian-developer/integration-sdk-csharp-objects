// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// An indicator whether the instructor may override the default final grade.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FinalGradeDefaultOverridability
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// overridable
        /// </summary>
        [EnumMember(Value = "overridable")]
        Overridable,

        /// <summary>
        /// notOverridable
        /// </summary>
        [EnumMember(Value = "notOverridable")]
        NotOverridable
    }
}