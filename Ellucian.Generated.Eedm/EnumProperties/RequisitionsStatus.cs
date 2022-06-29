// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The status of the requisition.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RequisitionsStatus
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
        /// cancelled
        /// </summary>
        [EnumMember(Value = "cancelled")]
        Cancelled,

        /// <summary>
        /// purchaseOrderCreated
        /// </summary>
        [EnumMember(Value = "purchaseOrderCreated")]
        Purchaseordercreated,

        /// <summary>
        /// inProgress
        /// </summary>
        [EnumMember(Value = "inProgress")]
        Inprogress,
    }
}


