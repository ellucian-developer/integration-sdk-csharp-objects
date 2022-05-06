// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The details associated with an existing vendor.
    /// </summary>
    [DataContract]
    public class AccountsPayableInvoicesExistingVendorDtoProperty
    {
        /// <summary>
        /// The vendor associated with the invoice.
        /// </summary>
        [DataMember(Name = "vendor")]
        public GuidObject2 Vendor { get; set; }

        /// <summary>
        /// The vendor address to be used for this invoice (defaults to the vendors primary address).
        /// </summary>
        [DataMember(Name = "alternativeVendorAddress", EmitDefaultValue = false)]
        public GuidObject2 AlternativeVendorAddress { get; set; }
    }
}