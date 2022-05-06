// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The status of the payment transaction.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentTransactionsStatus
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// reconciled
        /// </summary>
        [EnumMember(Value = "reconciled")]
        Reconciled,

        /// <summary>
        /// outstanding
        /// </summary>
        [EnumMember(Value = "outstanding")]
        Outstanding,

        /// <summary>
        /// void
        /// </summary>
        [EnumMember(Value = "void")]
        Void,
    }
}