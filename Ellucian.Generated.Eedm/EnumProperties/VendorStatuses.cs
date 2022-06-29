// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The statuses (active, approved, stop payment) that apply to the vendor.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VendorsStatuses
    {
        /// <summary>
        /// active
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// holdPayment
        /// </summary>
        [EnumMember(Value = "holdPayment")]
        Holdpayment,

        /// <summary>
        /// approved
        /// </summary>
        [EnumMember(Value = "approved")]
        Approved,
    }
}


