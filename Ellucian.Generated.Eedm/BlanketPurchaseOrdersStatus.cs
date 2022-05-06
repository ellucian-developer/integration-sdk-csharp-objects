// Copyright 2019 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The status of the blanket purchase order.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BlanketPurchaseOrdersStatus
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// notApproved
        /// </summary>
        [EnumMember(Value = "notApproved")]
        Notapproved,

        /// <summary>
        /// outstanding
        /// </summary>
        [EnumMember(Value = "outstanding")]
        Outstanding,

        /// <summary>
        /// voided
        /// </summary>
        [EnumMember(Value = "voided")]
        Voided,

        /// <summary>
        /// closed
        /// </summary>
        [EnumMember(Value = "closed")]
        Closed,
    }
}