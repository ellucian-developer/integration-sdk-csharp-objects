// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Approval requirements for registration
    /// </summary>
    [DataContract]
    public class Approval
    {
        /// <summary>
        /// The type of approval.  Currently, the only supported value is "All" (optional, defaults to "All").
        /// </summary>
        [DataMember(Name = "approvalType")]
        public ApprovalType? ApprovalType { get; set; }

        /// <summary>
        /// The entity by which approval is obtained (optional, defaults to "System").
        /// </summary>
        [DataMember(Name = "approvalEntity")]
        public ApprovalEntity? ApprovalEntity { get; set; }
    }
}