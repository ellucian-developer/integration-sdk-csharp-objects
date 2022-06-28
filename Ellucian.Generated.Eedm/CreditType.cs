// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The kind of Credit associated with a Course.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CreditType
    {
        /// <summary>
        /// Continuing Education credit
        /// </summary>
        [EnumMember(Value = "Continuing Education")]
        ContinuingEducation,

        /// <summary>
        /// Institution credit
        /// </summary>
        Institutional,

        /// <summary>
        /// Other credit
        /// </summary>
        Other,

        /// <summary>
        /// Transfer credit
        /// </summary>
        Transfer
    }
}