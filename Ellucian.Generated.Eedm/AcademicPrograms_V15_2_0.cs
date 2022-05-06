//Copyright 2018-2019 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// An offering by an institution that represents a combination of courses and requirements leading to a degree, diploma, or certificate for a defined set of majors, minors, or concentrations. 
    /// </summary>
    [DataContract]
    public class AcademicPrograms_V15_2_0 : CodeItem2
    {
        /// <summary>
        /// The institutional unit that authorizes the academic program.
        /// </summary>
        [JsonProperty("authorizing", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AcademicProgramAuthorizing Authorizing { get; set; }

        /// <summary>
        /// The sites (campuses) the program is offered at
        /// </summary>
        [JsonProperty("sites", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<GuidObject2> Sites { get; set; }

        /// <summary>
        /// The level of academic progress that is associated with an academic program.
        /// </summary>
        [JsonProperty("academicLevel", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 AcademicLevel { get; set; }

        /// <summary>
        /// The academic credentials that can be awarded for completing an academic program.
        /// </summary>
        [JsonProperty("credentials", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<GuidObject2> Credentials { get; set; }

        /// <summary>
        /// The owners of the academic program.
        /// </summary>
        [JsonProperty("programOwners", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<GuidObject2> ProgramOwners { get; set; }

        /// <summary>
        /// The academic disciplines offered as part of an academic program.
        /// </summary>
        [JsonProperty("disciplines", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<AcademicProgramDiscipline2> Disciplines { get; set; }

        /// <summary>
        /// The status of an academic program.
        /// </summary>
        [JsonProperty("status")]
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
        /// The date that an academic program starts.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The date that an academic program ends.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? EndDate { get; set; }
    }
}