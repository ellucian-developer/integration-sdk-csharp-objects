// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The current state of the processing of the invoice.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccountsPayableInvoicesProcessState
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// inProgress
        /// </summary>
        [EnumMember(Value = "inProgress")]
        Inprogress,

        /// <summary>
        /// suspended
        /// </summary>
        [EnumMember(Value = "suspended")]
        Suspended,

        /// <summary>
        /// submitted
        /// </summary>
        [EnumMember(Value = "submitted")]
        Submitted,

        /// <summary>
        /// awaitingReceipt
        /// </summary>
        [EnumMember(Value = "awaitingReceipt")]
        Awaitingreceipt,

        /// <summary>
        /// notApproved
        /// </summary>
        [EnumMember(Value = "notApproved")]
        Notapproved,

        /// <summary>
        /// approved
        /// </summary>
        [EnumMember(Value = "approved")]
        Approved,

        /// <summary>
        /// outstanding
        /// </summary>
        [EnumMember(Value = "outstanding")]
        Outstanding,

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
        /// voided
        /// </summary>
        [EnumMember(Value = "voided")]
        Voided,
    }
}


