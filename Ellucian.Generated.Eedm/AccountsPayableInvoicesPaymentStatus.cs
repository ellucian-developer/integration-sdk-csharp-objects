// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// An indicator specifying if payment for the invoice is on hold.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccountsPayableInvoicesPaymentStatus
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// hold
        /// </summary>
        [EnumMember(Value = "hold")]
        Hold,

        /// <summary>
        /// noHold
        /// </summary>
        [EnumMember(Value = "noHold")]
        Nohold,
    }
}


