// Copyright 2020 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The type of accounts payable invoice, i.e. Procurement, eProcurement, or Travel.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccountsPayableInvoicesType
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// procurement
        /// </summary>
        [EnumMember(Value = "procurement")]
        Procurement,

        /// <summary>
        /// eprocurement
        /// </summary>
        [EnumMember(Value = "eprocurement")]
        Eprocurement,

        /// <summary>
        /// travel
        /// </summary>
        [EnumMember(Value = "travel")]
        Travel,
    }
}