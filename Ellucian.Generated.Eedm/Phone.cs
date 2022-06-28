// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about a phone number.
    /// </summary>
    [DataContract]
    public class Phone
    {
        /// <summary>
        /// Globally unique identifier of the phone
        /// </summary>
        [DataMember(Name = "guid")]
        public string Guid { get; set; }

        /// <summary>
        /// The <see cref="PhoneType">type</see> of phone number
        /// </summary>
        [DataMember(Name = "phoneType")]
        public PhoneType? PhoneType { get; set; }

        /// <summary>
        /// The phone number
        /// </summary>
        [DataMember(Name = "phoneNumber")]
        public string Number { get; set; }

        /// <summary>
        /// The phone number extension
        /// </summary>
        [DataMember(Name = "phoneExtension")]
        public string Extension { get; set; }
    }
}