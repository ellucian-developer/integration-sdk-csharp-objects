// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible types of an Employment Classification Type
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EmploymentClassificationType
    {
        /// <summary>
        /// Position
        /// </summary>
        [EnumMember(Value = "position")]
        Position,

        /// <summary>
        /// Employee
        /// </summary>
        [EnumMember(Value = "employee")]
        Employee,
    }
}