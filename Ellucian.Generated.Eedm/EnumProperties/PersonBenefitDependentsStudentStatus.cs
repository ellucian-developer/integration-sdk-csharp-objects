// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// An indication whether the dependent is attending an educational institution.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PersonBenefitDependentsStudentStatus
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// fullTime
        /// </summary>
        [EnumMember(Value = "fullTime")]
        Fulltime,

        /// <summary>
        /// partTime
        /// </summary>
        [EnumMember(Value = "partTime")]
        Parttime,

        /// <summary>
        /// notStudent
        /// </summary>
        [EnumMember(Value = "notStudent")]
        Notstudent,
    }
}


