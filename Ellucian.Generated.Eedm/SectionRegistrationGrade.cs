using Newtonsoft.Json;
// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Grades that have been assigned to this section registration.
    /// </summary>
    [DataContract]
    public class SectionRegistrationGrade
    {
        /// <summary>
        /// The type of section grade.
        /// </summary>
        [DataMember(Name = "type")]
        public GuidObject2 SectionGradeType { get; set; }

        /// <summary>
        /// The grade awarded to the student by the instructor.
        /// </summary>
        [DataMember(Name = "grade")]
        public GuidObject2 SectionGrade { get; set; }

        /// <summary>
        /// Properties related to the submission of the section grade.
        /// </summary>
        [DataMember(Name = "submission")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Submission Submission { get; set; }
    }
}
