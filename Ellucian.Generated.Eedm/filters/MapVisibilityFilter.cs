// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm.Filters
{
    /// <summary>
    /// MapVisibility named query
    /// </summary>
    public class MapVisibilityFilter
    {
        /// <summary>
        /// BuildingMapVisibility
        /// </summary>        
        [DataMember(Name = "mapVisibility", EmitDefaultValue = false)]
        [FilterProperty("mapVisibility")]
        public BuildingMapVisibility Visibility { get; set; }
    }
}
