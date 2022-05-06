// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A unit of measurement of how well a student completed a course.
    /// Extends the grades definition to contain all data properties instead of pointers to other GUID code entities
    /// </summary>
    [DataContract]
    public class GradeDefinitionsMaximum_V6_0 : BaseModel2
    {
        /// <summary>
        /// Globally unique identifier for Scheme
        /// </summary>
        [DataMember(Name = "scheme", EmitDefaultValue = false)]
        public GradeSchemeProperty GradeScheme { get; set; }

        /// <summary>
        /// The literal value or numeric range of the grade
        /// </summary>
        [DataMember(Name = "grade", EmitDefaultValue = false)]
        public GradeItem GradeItem { get; set; }

        /// <summary>
        /// What degree of credit this grade qualifies for.
        /// </summary>
        [DataMember(Name = "credit")]
        public GradeCmplCreditType GradeCmplCreditType { get; set; }

        /// <summary>
        ///A list of mappings to equivalent grades from other grade schemes.
        /// </summary>
        [DataMember(Name = "equivalentTo", EmitDefaultValue = false)]
        public IEnumerable<GradeDefinitionsMaximumEquivalentTo> EquivalentTo { get; set; }
    }
}