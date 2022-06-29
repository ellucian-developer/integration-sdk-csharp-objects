//Copyright 2017 Ellucian Company L.P. and its affiliates.

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
    public class AdmissionApplicationInstitutionAttendedDtoProperty
    {
        /// <summary>
        /// The ID of the educational institution attended.
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }
    }
}
