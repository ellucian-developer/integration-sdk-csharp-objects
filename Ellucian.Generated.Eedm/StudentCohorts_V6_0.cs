// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The type of students cohort.
    /// </summary>
    [DataContract]
    public class StudentCohorts_V6_0 : CodeItem2
    {
        /// <summary>
        /// Student Cohort Type.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public CohortType StudentCohortType { get; set; }
    }
}