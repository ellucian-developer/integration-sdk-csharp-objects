// Copyright 2014-2016 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A building on a site.
    /// </summary>
    [DataContract]
    public class Buildings_V6_0 : CodeItem2
    {
        /// <summary>
        /// A physical location
        /// </summary>
        [DataMember(Name = "site", EmitDefaultValue = false)]
        public GuidObject2 SiteGuid { get; set; }
    }
}