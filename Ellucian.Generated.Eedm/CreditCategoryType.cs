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
    public enum CreditCategoryType
    {
        /// <summary>
        /// The higher-level category of academic credits.
        /// </summary>
        [EnumMember(Value = "Continuing Education")]
        ContinuingEducation,

        /// <summary>
        /// Institution credit
        /// </summary>
        Institutional,

        /// <summary>
        /// Transfer credit
        /// </summary>
        Transfer,

        /// <summary>
        /// Exchange credit
        /// </summary>
        Exchange,

        /// <summary>
        /// Other credit
        /// </summary>
        Other,

        /// <summary>
        /// No credit
        /// </summary>
        None
    }
}