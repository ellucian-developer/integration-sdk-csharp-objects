// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The status of the line items.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LineItemStatus
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

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
        Reconciled,

        /// <summary>
        /// awaitingReceipt (Hold)
        /// </summary>
        [EnumMember(Value = "awaitingReceipt")]
        AwaitingReceipt,

        /// <summary>
        /// outstanding
        /// </summary>
        [EnumMember(Value = "inProgress")]
        InProgress,

        /// <summary>
        /// outstanding
        /// </summary>
        [EnumMember(Value = "notApproved")]
        NotApproved
    }
}