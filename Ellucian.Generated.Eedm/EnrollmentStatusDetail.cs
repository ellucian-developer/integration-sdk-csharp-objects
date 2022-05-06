// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Property to contain the enrollment status enum and id
    /// </summary>
    [DataContract]
    public class EnrollmentStatusDetail
    {
        /// <summary>
        /// The enrollment status enumerations
        /// </summary>
        [DataMember(Name = "status")]
        [FilterProperty("criteria")]
        public EnrollmentStatusType? EnrollStatus { get; set; }

        /// <summary>
        /// Id of the Enrollment status
        /// </summary>
        [DataMember(Name="detail")]
        public GuidObject2 Detail { get; set; }
    }
}
