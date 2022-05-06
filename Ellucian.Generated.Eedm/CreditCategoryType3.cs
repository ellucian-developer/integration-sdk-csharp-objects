// Copyright 2016 Ellucian Company L.P. and its affiliates.
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The kind of Credit associated with a Course.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CreditCategoryType3
    {
        /// <summary>
        /// Default to handle nulls
        /// </summary>
        NotSet = 0,
        /// <summary>
        /// Continuing Education
        /// </summary>
        [EnumMember(Value = "ce")]
        ContinuingEducation,

        /// <summary>
        /// Institution credit
        /// </summary>
        [EnumMember(Value = "institution")]
        Institutional,

        /// <summary>
        /// Transfer credit
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