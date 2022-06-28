// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A designation of a student's progress, based on the number of completed courses
    /// </summary>
    [DataContract]
    public class AcademicLevels_V6_1_0 : CodeItem2
    {
        /// <summary>
        /// The category associated with the academic level
        /// </summary>
        [DataMember(Name = "categories", EmitDefaultValue = false)]
        public IEnumerable<AcademicLevelCategory?> Category { get; set; }
    }
}