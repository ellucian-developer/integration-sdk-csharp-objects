// Copyright 2017 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible credit types for a student course transfer
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StudentCourseTransferCreditType
    {
        /// <summary>
        /// Continuing Education
        /// </summary>
        [EnumMember(Value = "ce")]
        ContinuingEducation,
        /// <summary>
        /// Institutional
        /// </summary>
        [EnumMember(Value = "institution")]
        Institutional,
        /// <summary>
        /// Transfer
        /// </summary>
        [EnumMember(Value = "transfer")]
        Transfer,
        /// <summary>
        /// Exchange
        /// </summary>
        [EnumMember(Value = "exchange")]
        Exchange,
        /// <summary>
        /// Exam
        /// </summary>
        [EnumMember(Value = "exam")]
        Exam,
        /// <summary>
        /// WorkLifeExperience
        /// </summary>
        [EnumMember(Value = "workLifeExperience")]
        WorkLifeExperience,
        /// <summary>
        /// Other
        /// </summary>
        [EnumMember(Value = "other")]
        Other,
        /// <summary>
        /// NoCredit
        /// </summary>
        [EnumMember(Value = "noCredit")]
        NoCredit
    }
}