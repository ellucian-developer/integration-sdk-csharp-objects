// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Type of the charge the student incurred. 
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StudentChargeTypes
    {
        /// <summary>
        /// No value set for this enumeration
        /// </summary>
        notset = 0,
        /// <summary>
        /// Tuition
        /// </summary>
        [EnumMember(Value = "tuition")]
        tuition,
        /// <summary>
        /// Fees
        /// </summary>
        [EnumMember(Value = "fee")]
        fee,
        /// <summary>
        /// Housing
        /// </summary>
        [EnumMember(Value = "housing")]
        housing,
        /// <summary>
        /// Meal Plans
        /// </summary>
        [EnumMember(Value = "meal")]
        meal
    }
}