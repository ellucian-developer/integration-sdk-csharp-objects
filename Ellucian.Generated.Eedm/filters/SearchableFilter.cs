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
    public class SearchableFilter
    {
        /// <summary>
        /// KeywordSearch
        /// </summary>        
        [DataMember(Name = "searchable", EmitDefaultValue = false)]
        [FilterProperty("searchable")]
        public SectionsSearchable Search { get; set; }
    }
}
