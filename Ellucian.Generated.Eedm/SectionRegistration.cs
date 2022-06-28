// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A record of a person's registration in a section..
    /// </summary>
    [DataContract]
    public class SectionRegistration : BaseModel
    {
        /// <summary>
        /// A person registering for a section represented by the GUID (required).
        /// </summary>
        [DataMember(Name = "registrant")]
        public GuidObject Registrant { get; set; }

        /// <summary>
        /// An instance of a Section represented by the GUID (required).
        /// </summary>
        [DataMember(Name = "section")]
        public GuidObject Section { get; set; }

        /// <summary>
        /// Approval type and agent of approval (required).
        /// </summary>
        [DataMember(Name = "approvals")]
        public IEnumerable<Approval> Approvals { get; set; }

        /// <summary>
        /// The Registration Action to perform or status to assign (required).
        /// </summary>
        [DataMember(Name = "status")]
        public SectionRegistrationStatus Status { get; set; }

        /// <summary>
        /// SectionRegistration constructor.
        /// </summary>
        public SectionRegistration() : base()
        {
        }
    }
}