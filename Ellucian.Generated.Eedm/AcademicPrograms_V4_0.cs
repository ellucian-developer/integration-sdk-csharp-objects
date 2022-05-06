using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Academic Disciplines offered by an organization
    /// </summary>
    [DataContract]
    public class AcademicPrograms_V4_0 : CodeItem2
    {
        /// <summary>
        /// The top level organization that offers an academic program.
        /// </summary>
        [DataMember(Name = "owningOrganization")]
        public GuidObject2 OwningOrganization { get; set; }

        /// <summary>
        /// The organizations that grant an academic credentials for the program.
        /// </summary>
        [DataMember(Name = "grantingOrganizations")]
        public List<GuidObject2> GrantingOrganizations { get; set; }

        /// <summary>
        /// The level of academic progress that is associated with an academic program.
        /// </summary>
        [DataMember(Name = "academicLevel")]
        public GuidObject2 AcademicLevel { get; set; }

        /// <summary>
        /// The level of academic progress that is associated with an academic program.
        /// </summary>
        [DataMember(Name = "credentials")]
        public List<GuidObject2> Credentials { get; set; }

        /// <summary>
        /// The academic disciplines offered as part of an academic program.
        /// </summary>
        [DataMember(Name = "disciplines")]
        public List<AcademicProgramDisciplines> Disciplines { get; set; }

        /// <summary>
        /// The status of an academic program.
        /// </summary>
        [DataMember(Name = "status")]
        public AcademicProgramStatus Status
        {
            get
            {
                if (this.EndDate.HasValue)
                {
                    return AcademicProgramStatus.inactive;
                }
                else
                {
                    return AcademicProgramStatus.active;
                }
            }
        }

        /// <summary>
        /// Start
        /// </summary>
        [DataMember(Name = "startOn")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// End
        /// </summary>
        [DataMember(Name = "endOn", EmitDefaultValue = false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// An offering by an institution that represents a combination of courses and requirements leading to a degree,
        /// diploma, or certificate for a defined set of majors, minors, or concentrations.
        /// </summary>
        public AcademicPrograms_V4_0()
        {
            OwningOrganization = new GuidObject2();
            GrantingOrganizations = new List<GuidObject2>();
            AcademicLevel = new GuidObject2();
            Credentials = new List<GuidObject2>();
            Disciplines = new List<AcademicProgramDisciplines>();
        }
    }
}