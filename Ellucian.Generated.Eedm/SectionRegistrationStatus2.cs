// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Section Registration status
    /// </summary>
    [DataContract]
    public class SectionRegistrationStatus2
    {
        /// <summary>
        /// Defines if a person is registered or not registered in a specific section.
        /// The Registration status code is automatically assigned in Colleague.  If the Status
        /// is set to "Registered", the Status Reason must be set to "Registered". 
        /// If the Status is set to "Not Registered", the Status Reason may not be "Registered".
        /// </summary>
        [DataMember(Name = "registrationStatus")]
        public RegistrationStatus2? RegistrationStatus { get; set; }

        /// <summary>
        /// The reason for the status of registered or not registered.
        /// "Registered"
        /// A person is registered in the section.  The Registration Status is automatically updated in Colleague
        /// to the appropriate status of "New" or "Add" based on registration dates.
        /// "Dropped"
        /// A person's registration was removed before the activity had begun.  Colleague automatically sets this
        /// status to either "Dropped" or "Deleted" based on registration dates.
        /// "Withdrawn"
        /// A person's registration was removed after the activity had begun.  Colleague automatically sets this
        /// status to either "Dropped" or "Deleted" based on registration dates.  A status of "Withdrawn" can only
        /// be assigned in Colleague using the Withdrawal Process within Colleague.
        /// "Canceled"
        /// A person's registration was removed because the activity is canceled.  Colleague automatically sets this
        /// status to either "Dropped" or "Deleted" based on registration dates.  A status of "Canceled" can only
        /// be assigned in Colleague using the Section Cancelation Process within Colleague.
        /// "Pending"
        /// A person is waiting for permission to be registered.  This is equivalent to adding a person to a waitlist.
        /// </summary>
        [DataMember(Name = "sectionRegistrationStatusReason")]
        public RegistrationStatusReason2? SectionRegistrationStatusReason { get; set; }

        /// <summary>
        /// Registration Status Code GUID object representing the actual status code of the registration (Optional).
        /// </summary>
        [DataMember(Name = "detail")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 Detail { get; set; }
    }
}