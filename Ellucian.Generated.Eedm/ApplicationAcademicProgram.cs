//Copyright 2019 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Discipline
    /// </summary>
    [DataContract]
    public class ApplicationAcademicProgram
    {
        /// <summary>
        /// Program
        /// </summary>
        [DataMember(Name = "program", EmitDefaultValue = false)]
        public GuidObject2 AcademicProgram { get; set; }

        /// <summary>
        /// Academic Level
        /// </summary>
        [DataMember(Name = "academicLevel", EmitDefaultValue = false)]
        public GuidObject2 AcademicLevel { get; set; }

        /// <summary>
        /// Academic Credentials
        /// </summary>
        [DataMember(Name = "credentials", EmitDefaultValue = false)]
        public List<GuidObject2> AcademicCredentials { get; set; }

        /// <summary>
        /// Program Owner
        /// </summary>
        [DataMember(Name = "programOwner", EmitDefaultValue = false)]
        public GuidObject2 ProgramOwner { get; set; }

        /// <summary>
        /// The list of academic disciplines the applicant chose
        /// </summary>
        [DataMember(Name = "disciplines", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<AdmissionApplicationSubmissionDiscipline> Disciplines { get; set; }

    }
}
