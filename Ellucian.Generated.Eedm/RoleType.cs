// Copyright 2014 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible types of person roles
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RoleType
    {
        /// <summary>
        /// Student
        /// </summary>
        Student,

        /// <summary>
        /// Faculty
        /// </summary>
        Faculty
    }
}