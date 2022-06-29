// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible types of person roles
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PersonRoleType
    {

        /// <summary>
        /// Default for when the enumeration is not set
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// Student
        /// </summary>
        [EnumMember(Value = "student")]
        Student,

        /// <summary>
        /// Instructor
        /// </summary>
        [EnumMember(Value = "instructor")]
        Instructor,

        /// <summary>
        /// Employee
        /// </summary>
        [EnumMember(Value = "employee")]
        Employee,

        /// <summary>
        /// Vendor
        /// </summary>
        [EnumMember(Value = "vendor")]
        Vendor,

        /// <summary>
        /// Alumni
        /// </summary>
        [EnumMember(Value = "alumni")]
        Alumni,

        /// <summary>
        /// Prospective Student
        /// </summary>
        [EnumMember(Value = "prospectiveStudent")]
        ProspectiveStudent,

        /// <summary>
        /// Advisor
        /// </summary>
        [EnumMember(Value = "advisor")]
        Advisor
    }
}