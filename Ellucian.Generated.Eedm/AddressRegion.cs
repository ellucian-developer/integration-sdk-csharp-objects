// Copyright 2016 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A designation of a student's progress, based on the number of completed courses
    /// </summary>
    [DataContract]
    public class AddressRegion
    {
        /// <summary>
        /// The code of a region of a country
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// The full name of a region
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue=false)]
        public string Title { get; set; }

    }
}