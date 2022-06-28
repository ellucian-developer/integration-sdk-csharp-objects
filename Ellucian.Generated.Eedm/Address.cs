// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about an address
    /// </summary>
    [DataContract]
    public class Address
    {
        /// <summary>
        /// Globally unique identifier of the address
        /// </summary>
        [DataMember(Name = "guid")]
        public string Guid { get; set; }

        /// <summary>
        /// The <see cref="AddressType">type</see> of address
        /// </summary>
        [DataMember(Name = "addressType")]
        public AddressTypeDtoProperty? AddressType { get; set; }

        /// <summary>
        /// Street address line 1
        /// </summary>
        [DataMember(Name = "streetAddress1")]
        public string StreetAddress1 { get; set; }

        /// <summary>
        /// Street address line 2
        /// </summary>
        [DataMember(Name = "streetAddress2")]
        public string StreetAddress2 { get; set; }

        /// <summary>
        /// Street address line 3
        /// </summary>
        [DataMember(Name = "streetAddress3")]
        public string StreetAddress3 { get; set; }

        /// <summary>
        /// The city
        /// </summary>
        [DataMember(Name = "city")]
        public string City { get; set; }

        /// <summary>
        /// The region
        /// </summary>
        [DataMember(Name = "region")]
        public string Region { get; set; }

        /// <summary>
        /// The county
        /// </summary>
        [DataMember(Name = "county")]
        public string County { get; set; }

        /// <summary>
        /// The <see cref="Country">country</see>
        /// </summary>
        [DataMember(Name = "country")]
        public Country Country { get; set; }

        /// <summary>
        /// The postal code
        /// </summary>
        [DataMember(Name = "postalCode")]
        public string PostalCode { get; set; }
    }
}