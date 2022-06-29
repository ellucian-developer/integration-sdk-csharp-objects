// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm.Filters
{
    /// <summary>
    /// Grade Date named query
    /// </summary>
    public class GradeDateFilter
    {
        /// <summary>
        /// Grade Date
        /// </summary>        
        [DataMember(Name = "gradeDate", EmitDefaultValue = false)]
        [FilterProperty("gradeDate")]
        public DateTime? GradeDate { get; set; }
    }
}
