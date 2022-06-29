// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The contact for the vendor.
    /// </summary>
    [DataContract]
    public class AccountsPayableInvoicesVendorContactDtoProperty
    {

        /// <summary>
        /// The name of the contact.
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The email of the contact.
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }
    }
}