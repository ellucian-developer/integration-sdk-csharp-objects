// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about a location type
    /// </summary>
    [DataContract]
    public class LocationTypeItem : CodeItem2
    {
        /// <summary>
        /// The <see cref="LocationType">entity type</see> for the location
        /// </summary>
        [DataMember(Name = "type")]
        public LocationType Type { get; set; }
    }
}