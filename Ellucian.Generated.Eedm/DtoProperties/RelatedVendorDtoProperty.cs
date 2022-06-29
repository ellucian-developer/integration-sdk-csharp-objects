// Copyright 2016-2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The vendor assigned to receive payment for this vendor or the parent vendor.
    /// </summary>
    [DataContract]
    public class RelatedVendorDtoProperty
    {
        /// <summary>
        ///  The type of related vendor.
        /// </summary>
        [DataMember(Name = "type")]
        [FilterProperty("criteria")]
        public VendorType? Type { get; set; }

        /// <summary>
        /// The related vendor
        /// </summary>
        [DataMember(Name = "vendor")]
        //[FilterProperty("criteria")]
        //[JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 Vendor { get; set; }
    }
}