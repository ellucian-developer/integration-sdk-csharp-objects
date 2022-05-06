// Copyright 2018 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Attributes;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Academic Disciplines offered by an organization
    /// </summary>
    [DataContract]
    public class AcademicDisciplines_V15_0 : AbbreviationItem
    {
        /// <summary>
        /// The <see cref="AcademicDisciplineType">Academic Discipline type</see>
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        public AcademicDisciplineType2 Type { get; set; }
        /// <summary>
        /// Holds the reporting country (USA) and the CIP code of the major or minor, if available
        /// </summary>
        [DataMember(Name = "reporting", EmitDefaultValue = false)]
        public List<ReportingDtoProperty> Reporting { get; set; }
    }
}