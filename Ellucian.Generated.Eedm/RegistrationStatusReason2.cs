// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Valid status reasons for section registration (required).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RegistrationStatusReason2
    {
        /// <summary>
        /// A person is registered in the section.  The Registration Status is automatically updated in Colleague
        /// to the appropriate status of "New" or "Add" based on registration dates.
        /// </summary>
        [EnumMember(Value = "registered")]
        Registered,
        /// <summary>
        /// A person's registration was removed before the activity had begun.  Colleague automatically sets this
        /// status to either "Dropped" or "Deleted" based on registration dates.
        /// </summary>
        [EnumMember(Value = "dropped")]
        Dropped, 
        /// <summary>
        /// A person's registration was removed after the activity had begun.  Colleague automatically sets this
        /// status to either "Dropped" or "Deleted" based on registration dates.  A status of "Withdrawn" can only
        /// be assigned in Colleague using the Withdrawal Process within Colleague.
        /// </summary>
        [EnumMember(Value = "withdrawn")]
        Withdrawn,
        /// <summary>
        /// A person's registration was removed because the activity is canceled.  Colleague automatically sets this
        /// status to either "Dropped" or "Deleted" based on registration dates.  A status of "Canceled" can only
        /// be assigned in Colleague using the Section Cancelation Process within Colleague.
        /// </summary>
        [EnumMember(Value = "canceled")]
        Canceled,
        /// <summary>
        /// A person is waiting for permission to be registered.  This is equivalent to adding a person to a waitlist.
        /// To remove from a waitlist you would need to set the status to "Registered" with a reason of "Registered".
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending
    }
}
