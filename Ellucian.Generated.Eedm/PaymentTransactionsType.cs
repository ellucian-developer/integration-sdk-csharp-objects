// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The void type of the transaction.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentTransactionsType
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// payableReestablished
        /// </summary>
        [EnumMember(Value = "payableReestablished")]
        Payablereestablished,

        /// <summary>
        /// payableNotReestablished
        /// </summary>
        [EnumMember(Value = "payableNotReestablished")]
        Payablenotreestablished,
    }
}