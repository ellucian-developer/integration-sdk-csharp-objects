// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;
using System.Collections.Generic;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The details associated with an undefined vendor or an override to an existing vendor's information.
    /// </summary>
    [DataContract]
    public class AccountsPayableInvoicesManualVendorDetailsDtoProperty
    {

        /// <summary>
        /// The name of the vendor.
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// An indication of whether the vendor is a person or an organization.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public AccountsPayableInvoicesVendorType? Type { get; set; }

        /// <summary>
        /// The address lines of the vendor's address, such as a street address, post office box number, or city, region, and postal code.
        /// </summary>
        [DataMember(Name = "addressLines", EmitDefaultValue = false)]
        public List<string> AddressLines { get; set; }

        /// <summary>
        /// A country specific postal region. Postal regions are expressed as a hierarchy of country, region, and sub-region, and as a locality with postal automation codes.
        /// </summary> 
        [DataMember(Name = "place", EmitDefaultValue = false)]
        public AddressPlace Place { get; set; }

        /// <summary>
        /// The contact for the vendor.
        /// </summary>
        [DataMember(Name = "contact", EmitDefaultValue = false)]
        public AccountsPayableInvoicesVendorContactDtoProperty Contact { get; set; }
    }
}