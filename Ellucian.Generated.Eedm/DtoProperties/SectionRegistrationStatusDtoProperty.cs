// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Section Registration status
    /// </summary>
    [DataContract]
    public class SectionRegistrationStatusDtoProperty
    {
        /// <summary>
        /// The status of this person's registration in the section.
        /// </summary>
        [DataMember(Name = "registrationStatus")]
        public RegistrationStatus3 RegistrationStatus { get; set; }

        /// <summary>
        /// Status reason for non-registration.        
        /// </summary>
        [DataMember(Name = "sectionRegistrationStatusReason")]
        public RegistrationStatusReason3 SectionRegistrationStatusReason { get; set; }

        /// <summary>
        /// Additional details about the status.
        /// </summary>
        [DataMember(Name = "detail")]
        public GuidObject2 Detail { get; set; }
    }
}