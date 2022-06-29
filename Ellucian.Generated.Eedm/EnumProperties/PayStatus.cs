// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible pay statuses of the employee (with pay, without pay or partial pay).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PayStatus
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// With Pay
        /// </summary>
        [EnumMember(Value = "withPay")]
        WithPay,

        /// <summary>
        /// Without Pay
        /// </summary>
        [EnumMember(Value = "withoutPay")]
        WithoutPay,

        /// <summary>
        /// Partial Pay
        /// </summary>
        [EnumMember(Value = "partialPay")]
        PartialPay
    }
}