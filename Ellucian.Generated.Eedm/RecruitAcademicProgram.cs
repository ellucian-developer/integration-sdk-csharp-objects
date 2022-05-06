//Copyright 2019 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The person who is interested in attending the institution and the academic program they are considering at the institution. 
    /// </summary>
    [DataContract]
    public class RecruitAcademicProgram
    {
        /// <summary>
        /// The academic program the prospect is considering at the instituion.
        /// </summary>
        [JsonProperty("program", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Program { get; set; }

        /// <summary>
        /// The academic level of study the prospect is considering at the institution.
        /// </summary>
        [JsonProperty("academicLevel", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AcademicLevel { get; set; }

        /// <summary>
        /// The academic credentials associated with the academic program.
        /// </summary>
        [JsonProperty("credentials", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<GuidObject2> Credentials { get; set; }

        /// <summary>
        /// The program owner of the academic program.
        /// </summary>
        [JsonProperty("programOwner", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 ProgramOwner { get; set; }

        /// <summary>
        /// The academic disciplines associated with the academic program.
        /// </summary>
        [JsonProperty("disciplines", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<RecruitAcademicProgramDiscipline> Disciplines { get; set; }

        /// <summary>
        /// An offering by an institution that represents a combination of courses and requirements leading to a degree,
        /// diploma, or certificate for a defined set of majors, minors, or concentrations.
        /// </summary>
        public RecruitAcademicProgram()
        {
            Disciplines = new List<RecruitAcademicProgramDiscipline>();
        }
    }
}