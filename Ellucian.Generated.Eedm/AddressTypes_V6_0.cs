// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about a address type
    /// </summary>
    [DataContract]
    public class AddressTypes_V6_0 : CodeItem2
    {
        /// <summary>
        /// The <see cref="AddressTypeList">type</see> of address
        /// </summary>
        [DataMember(Name = "addressType")]
        public AddressTypeList AddressTypeList { get; set; }
    }
}
