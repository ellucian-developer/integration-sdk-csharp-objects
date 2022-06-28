//Copyright 2017 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about individuals who provide instruction at an educational institution. 
    /// </summary>
    [DataContract]
    public class Instructors_V9_0 : BaseModel2
    {
        /// <summary>
        /// A link to the person filling the instructor role.
        /// </summary>

        [DataMember(Name = "instructor", EmitDefaultValue = false)]
        public GuidObject2 IndividualInstructor { get; set; }

        /// <summary>
        /// Information about the institutional units to which the instructor is assigned.
        /// </summary>

        [DataMember(Name = "institutionalUnits", EmitDefaultValue = false)]
        public IEnumerable<InstructorsInstitutionalUnit2> InstitutionalUnits { get; set; }

        /// <summary>
        /// The location where the instructor typically performs his/her duties.
        /// </summary>

        [DataMember(Name = "primaryLocation", EmitDefaultValue = false)]
        public GuidObject2 PrimaryLocation { get; set; }

        /// <summary>
        /// The category to which the instructor belongs (e.g. professor, associate professor, adjunct professor, auxiliary, etc.)
        /// </summary>

        [DataMember(Name = "category", EmitDefaultValue = false)]
        public GuidObject2 Category { get; set; }

        /// <summary>
        /// The staff type of the instructor (e.g. full time, part time, continuing education).
        /// </summary>

        [DataMember(Name = "staffType", EmitDefaultValue = false)]
        public GuidObject2 StaffType { get; set; }

        /// <summary>
        /// The tenure of the instructor.
        /// </summary>

        [DataMember(Name = "tenure", EmitDefaultValue = false)]
        public InstructorsTenure Tenure { get; set; }

    }
}