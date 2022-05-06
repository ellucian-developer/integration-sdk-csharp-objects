// Copyright 2017-2020 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The status of the purchase order.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PurchaseOrdersStatus
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

        /// <summary>
        /// inProgress
        /// </summary>
        [EnumMember(Value = "inProgress")]
        InProgress,

        /// <summary>
        /// accepted
        /// </summary>
        [EnumMember(Value = "accepted")]
        Accepted,

        /// <summary>
        /// backordered
        /// </summary>
        [EnumMember(Value = "backordered")]
        Backordered,

        /// <summary>
        /// invoiced
        /// </summary>
        [EnumMember(Value = "invoiced")]
        Invoiced,

        /// <summary>
        /// paid
        /// </summary>
        [EnumMember(Value = "paid")]
        Paid,

        /// <summary>
        /// reconciled
        /// </summary>
        [EnumMember(Value = "reconciled")]
        Reconciled
    }
}