// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A specification for how grades should be calculated and reported for a course
    /// </summary>
    [DataContract]
    public class GradeSchemeProperty
    {
        /// <summary>
        /// "The code for the grade scheme that may be used a reference or for reporting
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// The full name of a grade scheme
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// A designation of the level of instruction of a course or a program of study
        /// </summary>
        [DataMember(Name = "academicLevel", EmitDefaultValue = false)]
        public AcademicLevels_V6_0 AcademicLevel { get; set; }

        /// <summary>
        /// The date after which a grade scheme may be used.
        /// </summary>
        [DataMember(Name = "startOn", EmitDefaultValue = false)]
        public DateTime? StartOn { get; set; }

        /// <summary>
        /// The date after which a grade scheme may no longer be used.
        /// </summary>
        [DataMember(Name = "endOn", EmitDefaultValue = false)]
        public DateTime? EndOn { get; set; }

        /// <summary>
        /// The <see cref="GuidObject2">guid</see> for the grade scheme
        /// </summary>
        [DataMember(Name = "detail", EmitDefaultValue = false)]
        public GuidObject2 Detail { get; set; }
    }
}