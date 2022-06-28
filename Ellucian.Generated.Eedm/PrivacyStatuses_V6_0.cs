// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about a privacy status
    /// </summary>
    [DataContract]
    public class PrivacyStatuses_V6_0 : CodeItem2
    {
        /// <summary>
        /// The <see cref="PrivacyStatusType">entity type</see> for the privacy status type
        /// </summary>
        [DataMember(Name = "privacyCategory")]
        public PrivacyStatusType privacyStatusType { get; set; }
    }
}