// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The residency type of the applicant as specified in the student system.
    /// </summary>
    [DataContract]
    public class ResidencyTypeDtoProperty
    {
        /// <summary>
        /// The residency type of the applicant as specified in the student system.
        /// </summary>
        [DataMember(Name = "student", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 Student { get; set; }
    }
}
