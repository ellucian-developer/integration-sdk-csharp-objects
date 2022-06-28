using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
// Copyright 2016 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Academic Disciplines offered by an organization
    /// </summary>
    [DataContract]
    public class AcademicPrograms_V10_0 : CodeItem2
    {
        /// <summary>
        /// Authorizing institute of academic program.
        /// </summary>
        [DataMember(Name = "authorizing", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AcademicProgramAuthorizing Authorizing { get; set; }

        /// <summary>
        /// The sites (campuses) the program is offered at. 
        /// </summary>
        [DataMember(Name = "sites", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<GuidObject2> Sites { get; set; }

        /// <summary>
        /// The level of academic progress that is associated with an academic program.
        /// </summary>
        [DataMember(Name = "academicLevel", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 AcademicLevel { get; set; }

        /// <summary>
        /// The level of academic progress that is associated with an academic program.
        /// </summary>
        [DataMember(Name = "credentials", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<GuidObject2> Credentials { get; set; }

        /// <summary>
        /// The owner of the academic program.
        /// </summary>
        [DataMember(Name = "programOwners", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<GuidObject2> ProgramOwners { get; set; }

        /// <summary>
        /// The academic disciplines offered as part of an academic program.
        /// </summary>
        [DataMember(Name = "disciplines", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// An offering by an institution that represents a combination of courses and requirements leading to a degree,
        /// diploma, or certificate for a defined set of majors, minors, or concentrations.
        /// </summary>
        public AcademicPrograms_V10_0()
        {
            Sites = new List<GuidObject2>();
            AcademicLevel = new GuidObject2();
            Credentials = new List<GuidObject2>();
            Disciplines = new List<AcademicProgramDisciplines>();
            ProgramOwners = new List<GuidObject2>();
        }
    }
}