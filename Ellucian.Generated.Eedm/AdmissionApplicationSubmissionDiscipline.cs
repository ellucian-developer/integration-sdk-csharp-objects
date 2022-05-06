//Copyright 2019 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Discipline
    /// </summary>
    [DataContract]
    public class AdmissionApplicationSubmissionDiscipline
    {
        /// <summary>
        /// The academic discipline associated with the academic program.
        /// </summary>
        [DataMember(Name = "discipline", EmitDefaultValue = false)]
        public GuidObject2 Discipline { get; set; }

        /// <summary>
        /// The administering institution unit associated with the discipline.
        /// </summary>
        [DataMember(Name = "administeringInstitutionUnit", EmitDefaultValue = false)]
        public GuidObject2 AdministeringInstitutionUnit { get; set; }

        /// <summary>
        /// The date on which the discipline begins for the academic program the applicant has applied to.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [DataMember(Name = "startOn", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartOn { get; set; }
    }
}
