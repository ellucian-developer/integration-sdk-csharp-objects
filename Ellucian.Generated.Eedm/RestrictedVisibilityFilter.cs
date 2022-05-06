// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm.Filters
{
    /// <summary>
    /// Searchable named query
    /// </summary>
    public class RestrictedVisibilityFilter
    {
        /// <summary>
        /// KeywordSearch
        /// </summary>        
        [DataMember(Name = "restrictedVisibility", EmitDefaultValue = false)]
        [FilterProperty("restrictedVisibility")]
        public RestrictedVisibility RestrictedVisibility { get; set; }
    }
}
