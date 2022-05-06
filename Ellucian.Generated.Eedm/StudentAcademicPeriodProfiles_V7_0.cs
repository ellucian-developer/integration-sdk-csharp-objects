// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about a student for a specified academic period
    /// </summary>
    [DataContract]
    public class StudentAcademicPeriodProfiles_V7_0 : BaseModel2
    {
        /// <summary>
        /// A reference to link a student to the common HEDM persons entity.
        /// </summary>
        [DataMember(Name = "person")]
        [FilterProperty("criteria")]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// A term within an academic year (for example, Semester).
        /// </summary>
        [DataMember(Name = "academicPeriod")]
        [FilterProperty("criteria")]
        public GuidObject2 AcademicPeriod { get; set; }

        /// <summary>
        /// Status of the student for a given academic period.
        /// </summary>
        [DataMember(Name = "studentStatus", EmitDefaultValue = false)]
        public GuidObject2 StudentStatus { get; set; }

        /// <summary>
        /// Type of the student for the academic period .
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public GuidObject2 Type { get; set; }

        /// <summary>
        /// The residency type of the student for the academic period (e.g.: international, in state, out of state, etc.).
        /// </summary>
        [DataMember(Name = "residency", EmitDefaultValue = false)]
        public GuidObject2 Residency { get; set; }

        /// <summary>
        /// Status of the student enrollment for a given academic period
        /// </summary>
        [DataMember(Name = "academicPeriodEnrollmentStatus", EmitDefaultValue = false)]
        public GuidObject2 AcademicPeriodEnrollmentStatus { get; set; }

        /// <summary>
        /// A list of custom defined attributes or characteristics (tags) assigned to the student
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<GuidObject2> Tags { get; set; }

        /// <summary>
        /// The relative load (full-time, part-time, overload) of a student during the academic period based 
        ///     on the number of contact hours or credits.
        /// </summary>
        [DataMember(Name = "academicLoad", EmitDefaultValue = false)]
        public AcademicLoad AcademicLoad { get; set; }

        /// <summary>
        /// Measures (GPA, year classification) associated with the student for the academic period by academic level.
        /// </summary>
        [DataMember(Name = "measures", EmitDefaultValue = false)]
        public List<PerformanceMeasureDtoProperty> Measures { get; set; }

    }
}