// Copyright 2017 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible statuses of Student Aptitude Assessments
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StudentAptitudeAssessmentsStatus
    {
        /// <summary>
        ///Not set 
        /// </summary>
        NotSet = 0,

        /// <summary>
        ///active
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// inactive
        /// </summary>
        [EnumMember(Value = "inactive")]
        Inactive,

        /// <summary>
        /// notational
        /// </summary>
        [EnumMember(Value = "notational")]
        Notational
    }
}