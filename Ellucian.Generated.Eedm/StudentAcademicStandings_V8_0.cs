//Copyright 2017 Ellucian Company L.P. and its affiliates.

using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The calculated academic standings of students. 
    /// </summary>
    [DataContract]
    public class StudentAcademicStandings_V8_0 : BaseModel2
    {

        /// <summary>
        /// The student associated with the academic standing.
        /// </summary>
        [DataMember(Name = "student")]
        public GuidObject2 Student { get; set; }

        /// <summary>
        /// The type of academic standing calculation used to determine the student academic standing (e.g. level, program, academicPeriod).
        /// </summary>
        [DataMember(Name = "type")]
        public StudentAcademicStandingsType Type { get; set; }

        /// <summary>
        /// The academic level associated with the student academic standing.
        /// </summary>
        [DataMember(Name = "level", EmitDefaultValue = false)]
        public GuidObject2 Level { get; set; }

        /// <summary>
        /// The academic program associated with the student academic standing.
        /// </summary>
        [DataMember(Name = "program", EmitDefaultValue = false)]
        public GuidObject2 Program { get; set; }

        /// <summary>
        /// The academic period associated with the student academic standing.
        /// </summary>
        [DataMember(Name = "academicPeriod", EmitDefaultValue = false)]
        public GuidObject2 AcademicPeriod { get; set; }

        /// <summary>
        /// The academic standing calculated for the student.
        /// </summary>
        [DataMember(Name = "standing", EmitDefaultValue = false)]
        public GuidObject2 Standing { get; set; }

        /// <summary>
        /// A manually entered override of the calculated academic standing.
        /// </summary>
        [DataMember(Name = "overrideStanding", EmitDefaultValue = false)]
        public GuidObject2 OverrideStanding { get; set; }

        /// <summary>
        /// The reason the calculated academic standing was overridden.
        /// </summary>
        [DataMember(Name = "overrideReason", EmitDefaultValue = false)]
        public string OverrideReason { get; set; }

    }
}