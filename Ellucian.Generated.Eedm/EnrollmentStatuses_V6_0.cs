// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about a enrollment status
    /// </summary>
    [DataContract]
    public class EnrollmentStatuses_V6_0 : CodeItem2
    {
        /// <summary>
        /// The <see cref="EnrollmentStatusType">entity type</see> for the enrollment status type
        /// </summary>
        [DataMember(Name = "status")]
        public EnrollmentStatusType enrollmentStatusType { get; set; }
    }
}