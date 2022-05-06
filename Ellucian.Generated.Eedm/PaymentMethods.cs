// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The payment method used for the transaction.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentMethod
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// check
        /// </summary>
        [EnumMember(Value = "check")]
        Check,

        /// <summary>
        /// directDeposit
        /// </summary>
        [EnumMember(Value = "directDeposit")]
        Directdeposit,

        /// <summary>
        /// wire
        /// </summary>
        [EnumMember(Value = "wire")]
        Wire,

        /// <summary>
        /// eCheck
        /// </summary>
        [EnumMember(Value = "eCheck")]
        Echeck,

        /// <summary>
        /// creditCard
        /// </summary>
        [EnumMember(Value = "creditCard")]
        Creditcard,

        /// <summary>
        /// debitCard
        /// </summary>
        [EnumMember(Value = "debitCard")]
        Debitcard,
    }
}