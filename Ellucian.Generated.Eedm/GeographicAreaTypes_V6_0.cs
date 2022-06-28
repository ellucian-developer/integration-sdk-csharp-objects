// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about a geographic area type
    /// </summary>
    [DataContract]
    public class GeographicAreaTypes_V6_0 : CodeItem2
    {
        /// <summary>
        /// The <see cref="GeographicAreaTypeCategory">entity type</see> for the geographic area type categories
        /// </summary>
        [DataMember(Name = "category")]
        public GeographicAreaTypeCategory geographicAreaTypeCategory { get; set; }
    }
}