// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The vendor associated with the invoice.
    /// </summary>
    [DataContract]
    public class AccountsPayableInvoicesVendorDtoProperty
    {

        /// <summary>
        /// The details associated with an existing vendor.
        /// </summary>
        [DataMember(Name = "existingVendor", EmitDefaultValue = false)]
        public AccountsPayableInvoicesExistingVendorDtoProperty ExistingVendor { get; set; }

        /// <summary>
        /// The details associated with an undefined vendor or an override to an existing vendor's information.
        /// </summary>
        [DataMember(Name = "manualVendorDetails", EmitDefaultValue = false)]
        public AccountsPayableInvoicesManualVendorDetailsDtoProperty ManualVendorDetails { get; set; }
    }
}