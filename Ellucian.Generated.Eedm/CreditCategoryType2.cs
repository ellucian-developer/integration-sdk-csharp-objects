// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The kind of Credit associated with a Course.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CreditCategoryType2
    {
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
        Transfer
    }
}