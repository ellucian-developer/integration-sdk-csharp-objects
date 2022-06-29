// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about a phone number.
    /// </summary>
    [DataContract]
    public class PhoneDtoProperty
    {
        /// <summary>
        /// Globally unique identifier of the phone
        /// </summary>
        [DataMember(Name = "guid", EmitDefaultValue = false)]
        public string Guid { get; set; }

        /// <summary>
        /// The <see cref="PhoneType">type</see> of phone number
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public PhoneType? PhoneType { get; set; }

        /// <summary>
        /// The phone number
        /// </summary>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public string Number { get; set; }

        /// <summary>
        /// The phone number extension
        /// </summary>
        [DataMember(Name = "extension", EmitDefaultValue = false)]
        public string Extension { get; set; }
    }
}