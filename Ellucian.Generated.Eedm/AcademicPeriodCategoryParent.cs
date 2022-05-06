// Copyright 2018 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about an Academic Period Category
    /// </summary>
    [DataContract]
    public class AcademicPeriodCategoryParent
    {
        /// <summary>
        /// Globally unique Identifier (GUID) for terms with a category of 'subterm'
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Globally unique identifier for parentId
        /// </summary>
        [DataMember(Name = "academicPeriod", EmitDefaultValue = false)]
        public GuidObject2 AcademicPeriod { get; set; }

        /// <summary>
        /// For a category of 'term', the parent academic year when we don't have a GUID to represent a year.
        /// </summary>
        [DataMember(Name = "academicYear", EmitDefaultValue= false)]
        public int Year { get; set; }

    }
}
