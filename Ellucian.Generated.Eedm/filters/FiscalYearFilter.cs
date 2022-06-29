// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm.Filters
{
    /// <summary>
    /// Subject named query
    /// </summary>
    public class FiscalYearFilter
    {
        /// <summary>
        /// fiscalYear
        /// </summary>        
        [DataMember(Name = "fiscalYear", EmitDefaultValue = false)]
        [FilterProperty("fiscalYear")]
        public GuidObject2 FiscalYear { get; set; }
    }
}
