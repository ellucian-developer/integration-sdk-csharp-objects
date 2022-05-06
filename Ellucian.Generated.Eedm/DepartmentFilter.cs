// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm.Filters
{
    /// <summary>
    /// Department named query
    /// </summary>
    public class DepartmentFilter
    {
        /// <summary>
        /// subject
        /// </summary>        
        [DataMember(Name = "department", EmitDefaultValue = false)]
        [FilterProperty("department")]
        public DepartmentStatus department { get; set; }
    }
    /// <summary>
    /// Department Status Named Query
    /// </summary>
    public class DepartmentStatus
    {
        /// <summary>
        /// subject
        /// </summary>        
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [FilterProperty("department")]
        public Status status { get; set; }
    }
}
