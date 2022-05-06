// Copyright 2016 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A designation of a student's progress, based on the number of completed courses
    /// </summary>
    [DataContract]
    public class AddressPlace
    {
        /// <summary>
        /// The country where the address is located
        /// </summary> 
        [DataMember(Name = "country")]
        public AddressCountry Country { get; set; }

    }
}