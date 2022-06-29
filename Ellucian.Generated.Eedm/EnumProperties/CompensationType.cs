// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The possible types of compensation awarded (e.g. salary, wages, etc.)
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CompensationType
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// Salary
        /// </summary>
        [EnumMember(Value = "salary")]
        Salary,

        /// <summary>
        /// Wages
        /// </summary>
        [EnumMember(Value = "wages")]
        Wages       
    }
}