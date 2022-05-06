// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Operational units of an educational institution, such as a department
    /// </summary>
    [DataContract]
    public class EducationalInstitutionUnits_V7_0 : BaseModel2
    {
        /// <summary>
        /// The full name of the unit
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// The description of the unit
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The type of the unit (e.g., school, division, department, etc.)
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [FilterProperty("type")]
        public EducationalInstitutionUnitType EducationalInstitutionUnitType { get; set; }

         /// <summary>
        /// The type of the unit (e.g., school, division, department, etc.)
        /// </summary>
        [DataMember(Name = "parents", EmitDefaultValue = false)]
        public EducationalInstitutionUnitParentDtoProperty Parents { get; set; }

        /// <summary>
        /// Colleague code for department, division, or school
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

    }
}