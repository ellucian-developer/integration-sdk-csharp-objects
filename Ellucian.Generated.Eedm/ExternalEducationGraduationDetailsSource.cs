// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The source of educational institution where the person graduated.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExternalEducationGraduationDetailsSource
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// SecondarySchool
        /// </summary>
        [EnumMember(Value = "secondarySchool")]
        SecondarySchool
    }
}