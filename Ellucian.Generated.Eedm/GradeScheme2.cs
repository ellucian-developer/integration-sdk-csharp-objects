// Copyright 2015-2016 Ellucian Company L.P. and its affiliates.
using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A specification for how grades should be calculated and reported for a course
    /// </summary>
    [DataContract]
    public class GradeScheme2 : CodeItem2
    {
        /// <summary>
        /// The date after which a grade scheme may be applied to a course.
        /// </summary>
        [DataMember(Name = "startOn", EmitDefaultValue= false)]
        public DateTime? StartOn { get; set; }

        /// <summary>
        /// The date after which a grade scheme may no longer be applied to a course.
        /// </summary>
        [DataMember(Name = "endOn", EmitDefaultValue = false)]
        public DateTime? EndOn { get; set; }        
    }
}