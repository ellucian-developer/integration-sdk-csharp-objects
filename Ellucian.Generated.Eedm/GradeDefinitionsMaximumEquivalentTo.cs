// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    ///  A list of mappings to equivalent grades from other grade schemes
    /// </summary>
    [DataContract]
    public class GradeDefinitionsMaximumEquivalentTo 
    {
        /// <summary>
        /// A named grouping of grades that can be assigned to students at a given academic level
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
        [DataMember(Name = "credit", EmitDefaultValue = false)]
        public GradeCmplCreditType GradeCmplCreditType { get; set; }

        /// <summary>
        /// A grade scheme item in different grade schemes that is the equivalent to this grade scheme item.
        /// </summary>
        [DataMember(Name = "detail", EmitDefaultValue = false)]
        public GuidObject2 Detail { get; set; }
       
    }
}