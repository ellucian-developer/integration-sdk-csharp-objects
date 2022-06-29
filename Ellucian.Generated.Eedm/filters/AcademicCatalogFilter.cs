// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm.Filters
{
    /// <summary>
    /// academicCatalog named query
    /// </summary>
    public class AcademicCatalogFilter
    {
        /// <summary>
        /// fiscalYear
        /// </summary>        
        [JsonProperty("academicCatalog")]
        [FilterProperty("academicCatalog")]
        public GuidObject2 AcademicCatalog { get; set; }
    }
}
