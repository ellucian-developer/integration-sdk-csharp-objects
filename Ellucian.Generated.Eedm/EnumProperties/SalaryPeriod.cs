// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The time period of the salary
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SalaryPeriod
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,         

        /// <summary>
        /// Hour
        /// </summary>
        [EnumMember(Value = "hour")]
        Hour,

        /// <summary>
        /// Year
        /// </summary>
        [EnumMember(Value = "year")]
        Year,

        /// <summary>
        /// Contract
        /// </summary>
        [EnumMember(Value = "contract")]
        Contract
    }
}