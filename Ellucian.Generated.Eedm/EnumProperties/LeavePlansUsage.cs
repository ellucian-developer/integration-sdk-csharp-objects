// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// An indication whether the leave plan can be used before accrual or after accrual.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LeavePlansUsage
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// beforeAccrued
        /// </summary>
        [EnumMember(Value = "beforeAccrued")]
        Beforeaccrued,

        /// <summary>
        /// afterAccrued
        /// </summary>
        [EnumMember(Value = "afterAccrued")]
        Afteraccrued,
    }
}
