// Copyright 2020 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The default address(es) associated with the vendor.
    /// </summary>
    [DataContract]
    public class VendorsAddressesDtoProperty
    {
        /// <summary>
        ///  The default address associated  with the vendor.
        /// </summary>
        [DataMember(Name = "address")]
        public GuidObject2 Address { get; set; }

        /// <summary>
        /// The usage associated with the address.
        /// </summary>
        [DataMember(Name = "usage")]
        public GuidObject2 Usage { get; set; }
    }
}