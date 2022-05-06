// Copyright 2015-2019 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Academic Disciplines offered by an organization
    /// </summary>
    [DataContract]
    public class RecruitAcademicProgramDiscipline
    {
        /// <summary>
        /// The academic discipline associated with the academic program.
        /// </summary>
        [DataMember(Name = "discipline")]
        public GuidObject2 Discipline { get; set; }

        /// <summary>
        /// The administering institution unit associated with the discipline.
        /// </summary>
        [DataMember(Name = "administeringInstitutionUnit", EmitDefaultValue = false)]
        public GuidObject2 AdministeringInstitutionUnit { get; set; }

        /// <summary>
        /// The effective start date of the cohort.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? StartOn { get; set; }
       
        /// <summary>
        /// The academic disciplines offered as part of an academic program.
        /// </summary>
        public RecruitAcademicProgramDiscipline()
        {
            
        }
    }
}