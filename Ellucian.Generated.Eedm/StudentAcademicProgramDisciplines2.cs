// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The academic disciplines offered as part of the academic program. 
    /// </summary>
    [DataContract]
    public class StudentAcademicProgramDisciplines2
    {
        /// <summary>
        /// An academic discipline associated with the academic program.
        /// </summary>
        [DataMember(Name = "discipline")]
        public GuidObject2 Discipline { get; set; }

        /// <summary>
        /// The institutional unit that administers the discipline (major, minor, concentration), typically a department within a school or college.
        /// </summary>
        [DataMember(Name = "administeringInstitutionUnit", EmitDefaultValue = false)]
        public GuidObject2 AdministeringInstitutionUnit { get; set; }

        /// <summary>
        /// The date on which the discipline begins for the student academic program.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? StartOn { get; set; }

        /// <summary>
        /// The date on which the discipline ends for the student academic program.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? EndOn { get; set; }

        /// <summary>
        /// The academic discipline that is one level higher in the discipline hierarchy.
        /// </summary>
        [JsonProperty("parentDiscipline", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 ParentDiscipline { get; set; }

        /// <summary>
        /// The state of a student's discipline within a program.
        /// </summary>
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 EnrollmentStatus { get; set; }

        /// <summary>
        /// The academic disciplines offered as part of an academic program.
        /// </summary>
        public StudentAcademicProgramDisciplines2()
        {
            Discipline = new GuidObject2();
        }
    }
}