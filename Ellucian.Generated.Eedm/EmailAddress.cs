// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about an email address
    /// </summary>
    [DataContract]
    public class EmailAddress
    {
        /// <summary>
        /// Globally unique identifier of the email address
        /// </summary>
        [DataMember(Name = "guid")]
        public string Guid { get; set; }

        /// <summary>
        /// The <see cref="EmailAddressType">type</see> of email address
        /// </summary>
        [DataMember(Name = "emailType")]
        public EmailAddressType? EmailAddressType { get; set; }

        /// <summary>
        /// The email address
        /// </summary>
        [DataMember(Name = "emailAddress")]
        public string Address { get; set; }
    }
}