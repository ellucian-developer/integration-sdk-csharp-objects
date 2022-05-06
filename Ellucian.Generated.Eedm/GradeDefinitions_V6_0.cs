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
    /// </summary>
    [DataContract]
    public class GradeDefinitions_V6_0 :BaseModel2
    {
        /// <summary>
        /// Globally unique identifier for Scheme
        /// </summary>
        [DataMember(Name = "scheme", EmitDefaultValue = false)]
        public GuidObject2 GradeScheme { get; set; }

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
        [DataMember(Name = "equivalentTo", EmitDefaultValue= false)]
        public IEnumerable<GuidObject2> EquivalentTo { get; set; }
    }
}