// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Academic Disciplines offered by an organization
    /// </summary>
    [DataContract]
    public class AcademicDisciplines_V6_0 : AbbreviationItem
    {
        /// <summary>
        /// The <see cref="AcademicDisciplineType">Academic Discipline type</see>
        /// </summary>
        [DataMember(Name = "type")]
        public AcademicDisciplineType Type { get; set; }
    }
}