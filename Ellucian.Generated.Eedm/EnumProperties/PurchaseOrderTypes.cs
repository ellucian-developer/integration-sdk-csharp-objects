// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The type of purchase order, i.e. Procurement, eProcurement, or Travel.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PurchaseOrdersTypes
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
        /// eProcurement
        /// </summary>
        [EnumMember(Value = "eProcurement")]
        Eprocurement,

        /// <summary>
        /// travel
        /// </summary>
        [EnumMember(Value = "travel")]
        Travel,

    }
}