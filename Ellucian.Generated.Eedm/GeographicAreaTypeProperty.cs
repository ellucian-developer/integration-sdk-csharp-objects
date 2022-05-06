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
    public class GeographicAreaTypeProperty
    {
        /// <summary>
        /// The <see cref="GeographicAreaTypeCategory">entity type</see> for the geographic area type categories
        /// </summary>
        [DataMember(Name = "category")]
        public GeographicAreaTypeCategory category { get; set; }

        /// <summary>
        /// The <see cref="GuidObject2">guid</see> for the geographic area type
        /// </summary>
        [DataMember(Name = "detail")]
        public GuidObject2 detail { get; set; }
    }
}