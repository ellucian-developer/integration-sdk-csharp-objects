// Copyright 2020 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm.Filters
{
    /// <summary>
    /// personByInstitutionType named query
    /// </summary>
    public class PersonByInstitutionFilter
    {
        /// <summary>
        /// personByInstitutionType
        /// </summary>        
        [DataMember(Name = "personByInstitutionType", EmitDefaultValue = false)]
        [FilterProperty("personByInstitutionType")]
        public PersonByInstitutionType PersonByInstitutionType { get; set; }
    }

    /// <summary>
    ///  PersonByInstitution
    /// </summary>
    public class PersonByInstitutionType
    {
        /// <summary>
        /// person
        /// </summary>        
        [DataMember(Name = "person", EmitDefaultValue = false)]
        [FilterProperty("personByInstitutionType")]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// The type of the institution
        /// </summary>
        [DataMember(Name = "educationalInstitutionType")]
        [FilterProperty("personByInstitutionType")]
        public EducationalInstitutionType? Type { get; set; }

    }
}