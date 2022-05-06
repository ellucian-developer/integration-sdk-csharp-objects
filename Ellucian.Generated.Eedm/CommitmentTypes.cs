// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible reasons for a payroll deduction request..
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CommitmentTypes
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// Pledge
        /// </summary>
        [EnumMember(Value = "pledge")]
        Pledge,

        /// <summary>
        /// Recurring Donation
        /// </summary>
        [EnumMember(Value = "recurringDonation")]
        RecurringDonation,

        /// <summary>
        /// Membership Dues
        /// </summary>
        [EnumMember(Value = "membershipDues")]
        MembershipDues
    }
}